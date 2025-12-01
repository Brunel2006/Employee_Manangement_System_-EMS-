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

namespace StaffPro_V1._0
{
    public partial class Salaire : UserControl
    {

        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\brunel\Projet\EMS\StaffPro V1.0\StaffPro V1.0\BD_StaffPro.mdf;Integrated Security=True;Connect Timeout=30");


        public Salaire()
        {
            InitializeComponent();
            displaySalaire();
            populate();
            disableFields();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displaySalaire();
            disableFields();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CleanAll()
        {
            IdEmployeSalaire.Clear();
            NomEmployeSalaire.Clear();
            SalaireEmployeSalaire.Clear();
            PosteEmployeSalaire.Clear();

        }


        private void btnModifierSalaire_Click(object sender, EventArgs e)
        {


                        if (IdEmployeSalaire.Text == "" || NomEmployeSalaire.Text == "" || PosteEmployeSalaire.Text == "" || SalaireEmployeSalaire.Text == "")
            {
                MessageBox.Show("Données manquantes dans les champs !!",
                    "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                DialogResult check = MessageBox.Show("Etes vous sures de vouloir modifier le salaire de : "+NomEmployeSalaire.Text+ " ?", "Message de confirametion"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {

                    try
                    {

                        connect.Open();
                        DateTime today = DateTime.Now;
                        string updateData = "UPDATE employe set SalaireEmploye = "+SalaireEmployeSalaire.Text+", DerniereModification = '"+today.ToString("yyyy-MM-dd")+"'  WHERE IdEmploye = '" + IdEmployeSalaire.Text + "' ";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {

                            cmd.ExecuteNonQuery();

                            displaySalaire();

                            MessageBox.Show("Modification reussie !!!",
            "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        connect.Close();
                        CleanAll();
                        populate();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex,
                        "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
                else 
                {
                    MessageBox.Show("Tentative annulée !!",
                            "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                
            
            }

            
        

        }

        public void displaySalaire() 
        {
            DataSalaire ed = new DataSalaire();
            List<DataSalaire> listData = ed.SalaryEmployeListData();

            dataSalaire.DataSource = listData;
        }

        private void populate()
        {
            connect.Open();
            string query = "SELECT IdEmploye, NomEmploye, PosteEmploye, SalaireEmploye FROM employe WHERE StatutEmploye = 'EN SERVICE'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataSalaire.DataSource = ds.Tables[0];
            connect.Close();
        }

        public void disableFields() 
        {

            IdEmployeSalaire.Enabled = false;
            NomEmployeSalaire.Enabled = false;
            PosteEmployeSalaire.Enabled = false;
        }

        private void dataSalaire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataSalaire.Rows[e.RowIndex];
                IdEmployeSalaire.Text = row.Cells[0].Value.ToString();
                NomEmployeSalaire.Text = row.Cells[1].Value.ToString();
                PosteEmployeSalaire.Text = row.Cells[2].Value.ToString();
                SalaireEmployeSalaire.Text = row.Cells[3].Value.ToString();
                
    

            }
        }

        private void btnAnnulerSalaire_Click(object sender, EventArgs e)
        {
            CleanAll();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void SalaireEmployeSalaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void ExportToPDF(int i)
        {
            // Créer un document PDF
            Document doc = new Document(PageSize.A4.Rotate());


            string nom = "Liste_Salaire_Des_Employés(" + i + ")";
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
            Paragraph title = new Paragraph("Liste des salaires des employés ", new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            title.Alignment = Element.ALIGN_CENTER;
            title.Font = FontFactory.GetFont("Arial", BaseFont.IDENTITY_H, true, 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            doc.Add(title);

            // Espacement
            doc.Add(new Paragraph("\n"));

            // Créer un tableau pour afficher les données du DataGridView
            PdfPTable table = new PdfPTable(4);
            table.WidthPercentage = 100;

            iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
            string[] customHeaders = { "Identifiant", "Nom", "Poste", "Salaire" };
            foreach (string header in customHeaders)
            {
                PdfPCell headerCell = new PdfPCell(new Phrase(header, headerFont));
                headerCell.BackgroundColor = BaseColor.GRAY;
                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                headerCell.Padding = 5f;
                table.AddCell(headerCell);
            }

            float totalGrid = 0f;
            foreach (DataGridViewColumn col in dataSalaire.Columns)
            {
                totalGrid += col.Width;
            }

            //Définir la largeur des colonnes
            float[] columnWidths = new float[dataSalaire.Columns.Count];
            for (int j = 0; j < dataSalaire.Columns.Count; j++)
            {
                //columnWidths[j] = 20f;
                columnWidths[j] = dataSalaire.Columns[i].Width / totalGrid * 100;
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
            foreach (DataGridViewRow row in dataSalaire.Rows)
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
        private void btnImprimerSalaire_Click(object sender, EventArgs e)
        {
            i = i + 1;
            ExportToPDF(i);
        }
    }
}
