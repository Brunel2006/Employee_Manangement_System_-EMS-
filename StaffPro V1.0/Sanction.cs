using System;
using System.Collections.Generic;
using System.ComponentModel;
using iTextSharp.text;
using iTextSharp.text.pdf;
//using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;
using System.IO;
using Tulpep.NotificationWindow;
using Tulpep;

namespace StaffPro_V1._0
{
    public partial class Sanction : UserControl
    {

        SqlConnection connect
            = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\BRUNEL\PROJET\EMS\STAFFPRO V1.0\STAFFPRO V1.0\BD_STAFFPRO.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Sanction()
        {
            InitializeComponent();
            DisplaySanction();
            AfficherNotificationSanction();
            ShowSanctionAlert();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void NomEmployeSanction_TextChanged(object sender, EventArgs e)
        {

        }

        public DateTime CalculateEndDate(DateTime startDate)
        {
       
            startDate = DateSanction.Value;
            int duree = Convert.ToInt32(DureeSanction.Text);
            DateTime endDate = startDate.AddDays(duree);
          

            return endDate;
        }

        private void DisplaySanction()
        {
            
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
                
            string query = "SELECT s.IdSanction, e.NomEmploye, s.TypeSanction, s.Motif, s.DateSanction, s.Duree, s.Statut, s.DateFin FROM sanction s, employe e WHERE e.IdEmploye = s.IdEmploye";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            dgvListeSanction.DataSource = ds;

            SqlCommand cmd = new SqlCommand("SELECT NomEmploye, IdEmploye FROM employe", connect);
            SqlDataAdapter adapteur = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapteur.Fill(data, "employe");
            NomEmployeSanction.DataSource = data.Tables["employe"];
            NomEmployeSanction.DisplayMember = "NomEmploye";
            NomEmployeSanction.ValueMember = "IdEmploye";

            DateTime today = DateTime.Now.Date;
            string requete = "UPDATE sanction set Statut = 'Terminée' WHERE DateFin <= '" + today.ToString("yyyy-MM-dd") + "';";
            using (SqlCommand command = new SqlCommand(requete, connect))
            {
                command.ExecuteNonQuery();
            }

                connect.Close();
        }
        private void CleanAll()
        {

            NomEmployeSanction.ResetText();
            TypeSanction.ResetText();
            MotifSanction.Clear();
            DureeSanction.Clear();
            DateSanction.ResetText();
            StatutSanction.ResetText();

        }

        private void btnAjouterSanction_Click(object sender, EventArgs e)
        {
            if (NomEmployeSanction.Text == "" || TypeSanction.Text == "" || MotifSanction.Text == "" || DureeSanction.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !!",
                    "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string prefix = "SAN";
                        int number = new Random().Next(10000, 99999);
                        string matricule = prefix + number.ToString();
                        DateTime dateSanction = DateSanction.Value;
                        DateTime EndDate = CalculateEndDate(dateSanction);
                        string query = "INSERT INTO sanction (IdSanction, IdEmploye, TypeSanction, Motif, DateSanction, Duree, Statut, DateFin) VALUES ('" + matricule + "', '" + NomEmployeSanction.SelectedValue.ToString()+ "', '" + TypeSanction.SelectedItem.ToString() + "', '" + MotifSanction.Text + "', '" + dateSanction.ToString("yyyy-MM-dd") + "', " + Convert.ToInt32(DureeSanction.Text) + ", '" + StatutSanction.SelectedItem.ToString() + "', '" + EndDate.ToString("yyyy-MM-dd") + "')";
                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            cmd.ExecuteNonQuery();
                            DisplaySanction();
                            MessageBox.Show("Sanction enregistrée avec succes !!!",
                    "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connect.Close();
                            CleanAll();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error : " + ex,
                   "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            DisplaySanction();
        }
        public void AfficherNotificationSanction()
        {
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = "Alerte Sanction";
            notifyIcon.BalloonTipText = "Une Sanction arrive à son terme dans moins de 2 jours+";
            notifyIcon.ShowBalloonTip(10000);
        }

        private void dgvListeSanction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (connect.State == ConnectionState.Closed)
                {

                    connect.Open();
                }
                DataGridViewRow row = dgvListeSanction.Rows[e.RowIndex];
                NomEmployeSanction.Text = row.Cells[1].Value.ToString();
                TypeSanction.Text = row.Cells[2].Value.ToString();
                MotifSanction.Text = row.Cells[3].Value.ToString();
                DureeSanction.Text = row.Cells[5].Value.ToString();
                StatutSanction.Text = row.Cells[6].Value.ToString();

                NomEmployeSanction.Enabled = false;
                TypeSanction.Enabled = false;
                MotifSanction.Enabled = false;
                DureeSanction.Enabled = false;
                StatutSanction.Enabled = true;
                DateSanction.Enabled = false;

                connect.Close();
            }
        }

        private void btnModifierSanction_Click(object sender, EventArgs e)
        {
            if (NomEmployeSanction.Text == "" || TypeSanction.Text == "" || MotifSanction.Text == "" || DureeSanction.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !!",
                    "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Etes vous sures de vouloir modifier ces données ?", "Message de confirmation"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        
                        string requete = "UPDATE sanction set Statut = '" + StatutSanction.Text + "';";
                        using (SqlCommand cmd = new SqlCommand(requete, connect))
                        {

                            cmd.ExecuteNonQuery();
                            DisplaySanction();
                            MessageBox.Show("Modification reussie !!!",
            "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error : " + ex,
                        "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
       
        private void btnAnnulerSanction_Click(object sender, EventArgs e)
        {
            CleanAll();
            NomEmployeSanction.Enabled = true;
            TypeSanction.Enabled = true;
            MotifSanction.Enabled = true;
            DureeSanction.Enabled = true;
            StatutSanction.Enabled = true;
            DateSanction.Enabled = true;
            DisplaySanction();
        }

        private void DureeSanction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Sanction_Load(object sender, EventArgs e)
        {
            
        }
        public void alertTime_Tick(object sender, EventArgs e)
        {
    
        }

        public void ShowSanctionAlert()
        {
            if (connect.State == ConnectionState.Closed)
            {

                connect.Open();
            }



            DateTime today = DateTime.Now.Date;
            DateTime tomorrow = today.AddDays(1);

            string query = @"SELECT e.NomEmploye FROM sanction s, employe e WHERE e.IdEmploye = s.IdEmploye AND s.DateFin = @Fin ;";
            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@Fin", tomorrow.Date);
                SqlDataReader reader = cmd.ExecuteReader();
                // Créer un StringBuilder pour accumuler les noms des employés
                StringBuilder alertMessage = new StringBuilder();
                bool hasAlert = false;
                while (reader.Read())
                {
                    // Ajouter chaque nom d'employé à l'alerte
                    alertMessage.AppendLine(reader["NomEmploye"].ToString());
                    hasAlert = true;
                }

                reader.Close();
                // Vérifier si des sanctions expirent demain
                if (hasAlert)
                {
                    //string nomEmploye = reader["NomEmploye"].ToString();

                    //MessageBox.Show("ALerte : La sanction de " + nomEmploye + " se termine demain !!", "Alerte de sanction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Afficher l'alerte avec les noms des employés concernés
                    //MessageBox.Show("Alerte : Les sanctions des employés suivants expirent demain :\n\n" + alertMessage.ToString(), "Alerte de sanction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Properties.Resources.icons8_macbook_de_performance_50;
                    popup.TitleText = "Notification StaffPro";
                    popup.TitleFont = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);

                    popup.ContentText = "Alerte : La sanction de l'employé suivant expire demain:\n" + alertMessage.ToString();
                    popup.Delay = 10000;
                    popup.ContentFont = new System.Drawing.Font("Arial", 13, System.Drawing.FontStyle.Bold);



                    popup.Popup();
                    
                }
            }
            
        }


        private void ExportToPDF(int i)
        {
            // Créer un document PDF
            Document doc = new Document(PageSize.A4.Rotate());


            string nom = "Liste_Des_Sanctions(" + i + ")";
            // Choisir l'emplacement du fichier de sortie
            string pdfFilePath = "C:\\Users\\b\\Desktop\\Rapports_PDF\\" + nom + ".pdf";
            PdfWriter.GetInstance(doc, new System.IO.FileStream(pdfFilePath, System.IO.FileMode.Create));

            // Ouvrir le document pour ajouter du contenu
            doc.Open();

            //Ajouter le logo au PDF

            string logopath2 = @"C:\brunel\Projet\EMS\StaffPro V1.0\StaffPro V1.0\Resources\logo_softwify.JPG";
            if (File.Exists(logopath2))
            {

                iTextSharp.text.Image logo2 = iTextSharp.text.Image.GetInstance(logopath2);

                logo2.ScaleToFit(150f, 150f);

                logo2.Alignment = Image.ALIGN_CENTER;

                doc.Add(logo2);
            }

            // Titre du document
            DateTime today = DateTime.Now;
            Paragraph title = new Paragraph("Liste des sanctions ", new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            title.Alignment = Element.ALIGN_CENTER;
            title.Font = FontFactory.GetFont("Arial", BaseFont.IDENTITY_H, true, 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            doc.Add(title);

            // Espacement
            doc.Add(new Paragraph("\n"));

            // Créer un tableau pour afficher les données du DataGridView
            PdfPTable table = new PdfPTable(8);
            table.WidthPercentage = 100;

            iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
            string[] customHeaders = { "Identifiant", "Nom", "Type", "Motif", "Date Debut", "Durée (jours)", "Statut", "Date Fin"};
            foreach (string header in customHeaders)
            {
                PdfPCell headerCell = new PdfPCell(new Phrase(header, headerFont));
                headerCell.BackgroundColor = BaseColor.GRAY;
                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                headerCell.Padding = 5f;
                table.AddCell(headerCell);
            }

            float totalGrid = 0f;
            foreach (DataGridViewColumn col in dgvListeSanction.Columns)
            {
                totalGrid += col.Width;
            }

            //Définir la largeur des colonnes
            float[] columnWidths = new float[dgvListeSanction.Columns.Count];
            for (int j = 0; j < dgvListeSanction.Columns.Count; j++)
            {
                //columnWidths[j] = 20f;
                columnWidths[j] = dgvListeSanction.Columns[i].Width / totalGrid * 100;
            }

            table.SetWidths(columnWidths);

            // Ajouter les en-têtes de colonnes
            //foreach (DataGridViewColumn column in dataRecrutement.Columns)
            // {
            //     PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
            //    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            //   cell.BorderWidth = 1f; // Bordure autour de chaque cellule
            //    cell.Padding = 8f; // Padding pour ajouter de l'espace autour du texte
            //   cell.HorizontalAlignment = Element.ALIGN_CENTER; // Centrer le texte
            //   table.AddCell(cell);
            // }

            // Ajouter les lignes du DataGridView
            foreach (DataGridViewRow row in dgvListeSanction.Rows)
            {
                // Ignore la dernière ligne vide
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(cell.Value.ToString());
                    }
                }
            }

            // Ajouter le tableau au document PDF
            doc.Add(table);

            doc.Add(new Paragraph("\n"));

            String currentDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            //Ajouter la date de creation du pdf
            Paragraph footer = new Paragraph("Fait le : " + currentDate)
            {
                Alignment = Element.ALIGN_RIGHT,
                Font = FontFactory.GetFont("Arial", BaseFont.IDENTITY_H, true, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
            };
            doc.Add(footer);

            // Fermer le document
            doc.Close();

            // Message de confirmation
            MessageBox.Show("Exportation en PDF réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        int i;
        private void btnImprimerSanction_Click(object sender, EventArgs e)
        {
            i = i + 1;
            ExportToPDF(i);
        }
    }
}
