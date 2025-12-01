using System;
using System.Collections.Generic;
using System.ComponentModel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace StaffPro_V1._0
{
    public partial class DashBoard : UserControl
    {
        

        SqlConnection connect
            = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\BRUNEL\PROJET\EMS\STAFFPRO V1.0\STAFFPRO V1.0\BD_STAFFPRO.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public DashBoard()
        {
            InitializeComponent();
            display_TE();
            display_AE();
            display_IE();
            LoadData();
            
            

          

            
        }
        public void RefreshData() 
        {
            if (InvokeRequired) 
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            display_TE();
            display_IE();
            display_AE();
            LoadData();
            
        }

        public void display_TE() 
        {

            if (connect.State != ConnectionState.Open) 
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(*) FROM employe";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect)) 
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read()) 
                        {
                            int count = Convert.ToInt32(reader[0]);
                            lblNbreEmploye.Text = count.ToString();
                        
                        }
                        reader.Close();
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

        public void display_AE()
        {

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(*) FROM employe WHERE StatutEmploye = 'EN SERVICE'";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            lblNbreEmployeActif.Text = count.ToString();

                        }
                        reader.Close();
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

        public void display_IE()
        {

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(*) FROM employe WHERE StatutEmploye = 'HORS SERVICE'";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            lblNbreEmployeInactif.Text = count.ToString();

                        }
                        reader.Close();
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

        private void DashBoard_Load(object sender, EventArgs e)
        {
            display_TE();
            display_AE();
            display_IE();
            LoadData();


        }

        private void LoadData()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "select d.NomDepartement, count(*) AS nombre from employe e, departement d WHERE d.NumDepartement = e.Departement Group by d.NomDepartement;";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        stats.Series["series1"].Points.Clear();
                        while (reader.Read())
                        {
                            string departement = reader["NomDepartement"].ToString();
                            int employeeCount = int.Parse(reader["nombre"].ToString());
                            stats.Series["series1"].Points.AddXY(departement, employeeCount);
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

        public void btnRecherche_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            LoadEmployeesByDateRange(startDate, endDate);
            LoadData();
        }

        void LoadEmployeesByDateRange(DateTime startDate, DateTime endDate)
        {
            btnPdf.Visible = true;

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = @"select IdEmploye, NomEmploye, PosteEmploye, d.NomDepartement, DateInsertion from employe e, departement d where d.NumDepartement = e.Departement AND DateInsertion between @fromdate and @todate; ";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@fromdate", startDate);
                        cmd.Parameters.AddWithValue("@todate", endDate);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable employeesTable = new DataTable();
                        adapter.Fill(employeesTable);
                        dgvListEmploye.DataSource = employeesTable;
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

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void ExportToPDF(int i)
        {
            // Créer un document PDF
            Document doc = new Document(PageSize.A4.Rotate());


            string nom = "Liste_Employe_Par_Intervalle(" + i + ")";
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

                logo2.Alignment = iTextSharp.text.Image.ALIGN_CENTER;

                doc.Add(logo2);
            }

            // Titre du document
            DateTime today = DateTime.Now;
            Paragraph title = new Paragraph("Liste des employés enregistrés du " + dtpStartDate.Value + " au " + dtpEndDate.Value , new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            title.Alignment = Element.ALIGN_CENTER;
            title.Font = FontFactory.GetFont("Arial", BaseFont.IDENTITY_H, true, 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            doc.Add(title);

            // Espacement
            doc.Add(new Paragraph("\n"));

            // Créer un tableau pour afficher les données du DataGridView
            PdfPTable table = new PdfPTable(5);
            table.WidthPercentage = 100;

            iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
            string[] customHeaders = { "Identifiant", "Nom", "Poste", "Departement", "Embauche" };
            foreach (string header in customHeaders)
            {
                PdfPCell headerCell = new PdfPCell(new Phrase(header, headerFont));
                headerCell.BackgroundColor = BaseColor.GRAY;
                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                headerCell.Padding = 5f;
                table.AddCell(headerCell);
            }

            float totalGrid = 0f;
            foreach (DataGridViewColumn col in dgvListEmploye.Columns)
            {
                totalGrid += col.Width;
            }

            //Définir la largeur des colonnes
            float[] columnWidths = new float[dgvListEmploye.Columns.Count];
            for (int j = 0; j < dgvListEmploye.Columns.Count; j++)
            {
                //columnWidths[j] = 20f;
                columnWidths[j] = dgvListEmploye.Columns[i].Width / totalGrid * 100;
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
            foreach (DataGridViewRow row in dgvListEmploye.Rows)
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
        private void btnPdf_Click(object sender, EventArgs e)
        {
            i = i + 1;
            ExportToPDF(i);
        }
        
       

        public void btnChart_Click(object sender, EventArgs e)
        {

        }
    }


    }

