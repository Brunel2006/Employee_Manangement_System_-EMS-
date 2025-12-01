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
    public partial class Recrutement : UserControl
    {
        Sanction sanction = new Sanction();

        SqlConnection connect
            = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\BRUNEL\PROJET\EMS\STAFFPRO V1.0\STAFFPRO V1.0\BD_STAFFPRO.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Recrutement()
        {
            InitializeComponent();
            populate();
            sanction.AfficherNotificationSanction();
            //Charger les données de la base de données jusqu'au DATA GRID VIEW

            RefreshData();
            StatutEmployeRecrutement.Text = StatutEmployeRecrutement.Items[0].ToString();

            //imageColumn.HeaderText = "Photo";
            //imageColumn.Name = "Photo";
            //dataRecrutement.Columns.Add(imageColumn);
        }

        private void ExportToPDF(int i)
        {
            // Créer un document PDF
            Document doc = new Document(PageSize.A4.Rotate());


            string nom = "Liste_Employe(" + i + ")";
            // Choisir l'emplacement du fichier de sortie
            string pdfFilePath = "C:\\Users\\b\\Desktop\\Rapports_PDF\\" + nom+".pdf";
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
            Paragraph title = new Paragraph("Liste des employés   " + today, new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            title.Alignment = Element.ALIGN_CENTER;
            title.Font = FontFactory.GetFont("Arial", BaseFont.IDENTITY_H, true, 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            doc.Add(title);

            // Espacement
            doc.Add(new Paragraph("\n"));

            // Créer un tableau pour afficher les données du DataGridView
            PdfPTable table = new PdfPTable(12);
            table.WidthPercentage = 100;

            iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
            string[] customHeaders = { "Identifiant", "Nom", "Prenom", "Sexe", "Poste", "Embauche", "Modification", "Contrat", "Departement", "Telephone", "Statut", "Salaire" };
            foreach(string header in customHeaders)
            {
                PdfPCell headerCell = new PdfPCell(new Phrase(header, headerFont));
                headerCell.BackgroundColor = BaseColor.GRAY;
                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                headerCell.Padding = 5f;
                table.AddCell(headerCell);
            }

            float totalGrid = 0f;
            foreach(DataGridViewColumn col in dataRecrutement.Columns)
            {
                totalGrid += col.Width;
            }
     
            //Définir la largeur des colonnes
            float[] columnWidths = new float[dataRecrutement.Columns.Count];
            for(int j = 0; j < dataRecrutement.Columns.Count; j++)
            {
                //columnWidths[j] = 8.3f;
                columnWidths[j] = dataRecrutement.Columns[i].Width / totalGrid * 100;
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
            foreach (DataGridViewRow row in dataRecrutement.Rows)
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
            int i = 1;
        // Gestion du bouton "Exporter en PDF"
        private void btnPdf_Click(object sender, EventArgs e)
        {
            i = i + 1;
            ExportToPDF(i);
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            populate();
        }

        private void populate() 
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }

            string selectData = "select IdEmploye, NomEmploye, PrenomEmploye, SexeEmploye, PosteEmploye, d.NomDepartement, TelEmploye, StatutEmploye, SalaireEmploye, DureeContrat, DateInsertion, FinContrat, DerniereModification from employe e, departement d where d.NumDepartement = e.Departement; ";
            //string query = "SELECT * FROM employe";
            SqlDataAdapter sda = new SqlDataAdapter(selectData, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataRecrutement.DataSource = ds.Tables[0];

            SqlCommand cmd = new SqlCommand("SELECT * FROM departement", connect);
            SqlDataAdapter adapteur = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapteur.Fill(data, "departement");
            DepartementEmployeRecrutement.DataSource = data.Tables["departement"];
            DepartementEmployeRecrutement.DisplayMember = "NomDepartement";
            DepartementEmployeRecrutement.ValueMember = "NumDepartement";
            connect.Close();
        }

        private void CleanAll()
        {
            
            NomEmployeRecrutement.Clear();
            PrenomEmployeRecrutement.Clear();
            TelEmployeRecrutement.Clear();
            SexeEmployeRecrutement.ResetText();
            PosteEmployeRecrutement.Clear();
            ContratEmployeRecrutement.Clear();
            DepartementEmployeRecrutement.ResetText();
            
        }

        private void Recrutement_Load(object sender, EventArgs e)
        {
         

            populate();
        }



        private void btnAnnulerRecrutement_Click(object sender, EventArgs e)
        {
            CleanAll();
            btnFiche.Visible = false;
            ContratEmployeRecrutement.Enabled = true;
            StatutEmployeRecrutement.Enabled = false;

        }

        private void btnModifierRecrutement_Click(object sender, EventArgs e)
        {


            if ( NomEmployeRecrutement.Text == ""
                || PrenomEmployeRecrutement.Text == ""
                || TelEmployeRecrutement.Text == ""
                || DepartementEmployeRecrutement.Text == ""
                || SexeEmployeRecrutement.Text == ""
                || PosteEmployeRecrutement.Text == "")
            {
                MessageBox.Show("Données manquantes dans les champs !!",
                    "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                DialogResult check = MessageBox.Show("Etes vous sures de vouloir modifier les données de : "+NomEmployeRecrutement.Text+ " ?", "Message de confirmation"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {

                    try
                    {

                        connect.Open();
                        DateTime today = DateTime.Now;
                        int dureeContrat = int.Parse(ContratEmployeRecrutement.Text);
                        DateTime finContrat = today.AddMonths(dureeContrat);
                        if (StatutEmployeRecrutement.Text == "HORS SERVICE")
                        {
                            int resetSalaire = 0;
                            string updateData = "UPDATE employe set NomEmploye = '" + NomEmployeRecrutement.Text + "', " +
                        " PrenomEmploye = '" + PrenomEmployeRecrutement.Text + "', TelEmploye =  '" + TelEmployeRecrutement.Text + "', " +
                        " SexeEmploye = '" + SexeEmployeRecrutement.SelectedItem.ToString() + "', PosteEmploye =  '" + PosteEmployeRecrutement.Text + "', " +
                         " Departement =  '" + DepartementEmployeRecrutement.SelectedValue + "', " +
                        " DerniereModification = '" + today.ToString("yyyy-MM-dd") + "', StatutEmploye = '" + StatutEmployeRecrutement.SelectedItem.ToString() + "', SalaireEmploye = " + resetSalaire + " WHERE NomEmploye = '" + NomEmployeRecrutement.Text + "' AND PrenomEmploye = '" + PrenomEmployeRecrutement.Text + "' ";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {

                                cmd.ExecuteNonQuery();

                                populate();

                                MessageBox.Show("Modification reussie !!!",
                "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }

                        }
                        else
                        {
                  
                            string updateData = "UPDATE employe set NomEmploye = '" + NomEmployeRecrutement.Text + "', " +
                        " PrenomEmploye = '" + PrenomEmployeRecrutement.Text + "', TelEmploye =  '" + TelEmployeRecrutement.Text + "', " +
                        " SexeEmploye = '" + SexeEmployeRecrutement.SelectedItem.ToString() + "', PosteEmploye =  '" + PosteEmployeRecrutement.Text + "', " +
                         " Departement =  '" + DepartementEmployeRecrutement.SelectedValue + "', " +
                        " DerniereModification = '" + today.ToString("yyyy-MM-dd") + "', StatutEmploye = '" + StatutEmployeRecrutement.SelectedItem.ToString() + "' WHERE NomEmploye = '" + NomEmployeRecrutement.Text + "' AND PrenomEmploye = '" + PrenomEmployeRecrutement.Text + "' ";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {

                                cmd.ExecuteNonQuery();

                                populate();

                                MessageBox.Show("Modification reussie !!!",
                "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }

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
        private Employe selectedEmploye;

        private void dataRecrutement_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex != -1)
            {
                connect.Open();
                
                DataGridViewRow row = dataRecrutement.Rows[e.RowIndex];
                string req = "SELECT NomDepartement FROM departement WHERE NomDepartement = '" + row.Cells[5].Value.ToString()+ "';";
                SqlCommand cmd = new SqlCommand(req, connect);
                object result = cmd.ExecuteScalar();
                NomEmployeRecrutement.Text = row.Cells[1].Value.ToString();
                PrenomEmployeRecrutement.Text = row.Cells[2].Value.ToString();
                TelEmployeRecrutement.Text = row.Cells[6].Value.ToString();
                SexeEmployeRecrutement.Text = row.Cells[3].Value.ToString();
                PosteEmployeRecrutement.Text = row.Cells[4].Value.ToString();
                ContratEmployeRecrutement.Text = row.Cells[9].Value.ToString();
                DepartementEmployeRecrutement.Text = result.ToString();

                ContratEmployeRecrutement.Enabled = false;
                StatutEmployeRecrutement.Enabled = true;
                connect.Close();
                string id = row.Cells["IdEmploye"].Value.ToString();
                string nom = row.Cells["NomEmploye"].Value.ToString();
                string prenom = row.Cells["PrenomEmploye"].Value.ToString();
                string tel = row.Cells["TelEmploye"].Value.ToString();
                string sexe = row.Cells["SexeEmploye"].Value.ToString();
                string poste = row.Cells["PosteEmploye"].Value.ToString();
                string departement = row.Cells["NomDepartement"].Value.ToString();
                DateTime dateInsertion = Convert.ToDateTime(row.Cells["DateInsertion"].Value);
                DateTime derniereModofication = Convert.ToDateTime(row.Cells["DerniereModification"].Value);
                string statut = row.Cells["StatutEmploye"].Value.ToString();
                string salaire = row.Cells["SalaireEmploye"].Value.ToString();
                string duree = row.Cells["DureeContrat"].Value.ToString();

                selectedEmploye = new Employe
                {
                    Id = id,
                    Nom = nom,
                    Prenom = prenom,
                    Tel = tel,
                    Sexe = sexe,
                    Poste = poste,
                    Departement = departement,
                    DateInsertion = dateInsertion,
                    DerniereModification = derniereModofication,
                    Statut = statut,
                    Salaire = salaire,
                    Duree = duree


                };
                btnFiche.Visible = true;

                connect.Close();
            }
        }

        private void btnAjouterRecrutement_Click_1(object sender, EventArgs e)
        {
            if (NomEmployeRecrutement.Text == ""
                || PrenomEmployeRecrutement.Text == ""
                || TelEmployeRecrutement.Text == ""
                || DepartementEmployeRecrutement.Text == ""
                || SexeEmployeRecrutement.Text == ""
                || PosteEmployeRecrutement.Text == ""
                || ContratEmployeRecrutement.Text == "")
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
                        string prefix = "EM";
                        int number = new Random().Next(10000, 99999);
                        string matricule = prefix + number.ToString();
                        string checkEmID = "SELECT count(*) FROM employe WHERE IdEmploye = @emId";


                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emId", matricule);
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(NomEmployeRecrutement.Text.Trim() + " a deja été recruté !!",
                    "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                int salaire = 0;
                                int dureeContrat = int.Parse(ContratEmployeRecrutement.Text);
                                DateTime finContrat = today.AddMonths(dureeContrat);

                                string insertData = "INSERT INTO employe " +
                                    "(IdEmploye, NomEmploye, PrenomEmploye," +
                                    " SexeEmploye, PosteEmploye, DateInsertion, DerniereModification, " +
                                "DureeContrat, Departement, TelEmploye, StatutEmploye, SalaireEmploye, FinContrat) VALUES " +
                                "('" + matricule + "', '" + NomEmployeRecrutement.Text + "', '" + PrenomEmployeRecrutement.Text + "', '" + SexeEmployeRecrutement.SelectedItem.ToString() + "', '"  + PosteEmployeRecrutement.Text + "',  '" + today.ToString("yyyy-MM-dd") + "', '" + today.ToString("yyyy-MM-dd") + "','" + ContratEmployeRecrutement.Text + "','" + DepartementEmployeRecrutement.SelectedValue.ToString() + "','" + TelEmployeRecrutement.Text + "','" + StatutEmployeRecrutement.SelectedItem.ToString() + "','"+ salaire +"','" + finContrat.ToString("yyyy-MM-dd") + "')";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.ExecuteNonQuery();
                                    populate();
                                    MessageBox.Show("Recrutement éffectué avec succes !!!",
                    "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CleanAll();
                                    connect.Close();
                                }
                            }
                        }
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
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            populate();
            
        }

        private void btnFiche_Click(object sender, EventArgs e)
        {  

            Employee employee = new Employee();
            //employee.AfficherDetails(selectedEmploye.Id, selectedEmploye.Nom, selectedEmploye.Prenom, selectedEmploye.Tel, selectedEmploye.Sexe, selectedEmploye.Poste, selectedEmploye.Departement, selectedEmploye.DateInsertion, selectedEmploye.DerniereModification, selectedEmploye.Statut, selectedEmploye.Salaire, selectedEmploye.Duree);
            employee.Show();
        }

        private void TelEmployeRecrutement_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                float tel = float.Parse(TelEmployeRecrutement.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Veuillez entrer un numero");
                e.Cancel = true;
            }
        }

        private void TelEmployeRecrutement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ContratEmployeRecrutement_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContratEmployeRecrutement_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                float contrat = float.Parse(ContratEmployeRecrutement.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez entrer le nombre de mois \n Valeur incorrect");
                e.Cancel = true;
            }

        }
        //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
        private void btnFiche_Click_1(object sender, EventArgs e)
        {
           
            Employee employee = new Employee();
            employee.AfficherDetails(selectedEmploye.Id, selectedEmploye.Nom, selectedEmploye.Prenom, selectedEmploye.Tel, selectedEmploye.Sexe, selectedEmploye.Poste, selectedEmploye.Departement, selectedEmploye.DateInsertion, selectedEmploye.DerniereModification, selectedEmploye.Statut, selectedEmploye.Salaire, selectedEmploye.Duree);
            //employee.LoadImage(selectedEmploye.Id);
            employee.Show();
        }

        private void ContratEmployeRecrutement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
