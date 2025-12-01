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

namespace StaffPro_V1._0
{
    public partial class Employee : Form
    {
        SqlConnection connect
            = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\BRUNEL\PROJET\EMS\STAFFPRO V1.0\STAFFPRO V1.0\BD_STAFFPRO.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        

        public Employee()
        {
            InitializeComponent();

            
        }



        public void AfficherDetails(string id, string nom, string prenom, string tel, string sexe, string poste, string departement, DateTime DateInsertion, DateTime DerniereModification, string statut, string salaire, string duree)
        {
            string photo = null;
            lblIdentifiantEmploye.Text = id;
            lblNomEmploye.Text = nom;
            lblPrenomEmploye.Text = prenom;
            lblNumTelEmploye.Text = tel;
            lblSexeEmploye.Text = sexe;
            lblPosteEmploye.Text = poste;
            lblDepartementEmploye.Text = departement;
            lblDateInsertionEmploye.Text = DateInsertion.ToString("dd/MM/yyyy");
            lblDerniereModificationEmploye.Text = DerniereModification.ToString("dd/MM/yyyy");
            lblSalaireEmploye.Text = salaire.ToString();
            lblStatutEmploye.Text = statut;
            lblDureeContratEmploye.Text = duree.ToString();

            //LoadImage(id);

            if (!string.IsNullOrEmpty(photo))
            {
                pbAfficherPhoto.Image = System.Drawing.Image.FromFile(photo);

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        

        private void btnAjouterPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
            openFile.Title = "Selectionner une image";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                pbAfficherPhoto.Image = System.Drawing.Image.FromFile(openFile.FileName);
                //Covertir l'image en un tableau d'octets
                byte[] imagesBytes = ImageToByteArray(pbAfficherPhoto.Image);

                //Sauvegarder l'image dans la base de données
                //SaveImageToDataBase(imagesBytes);
            }
        }
        //Fonction pour Covertir l'image en un tableau d'octets

        private byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }

        }
        // Fonction pour sauvegarder l'image dans la base de données
        public void SaveImageToDataBase(byte[] imageBytes)
        {
            connect.Open();
            string query = "UPDATE employe SET Photo = @photo WHERE IdEmploye = @idEmploye";
            using(SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@photo", imageBytes);
                cmd.Parameters.AddWithValue("@idEmploye", lblIdentifiantEmploye.Text);
            }
            connect.Close();
        }
        public void LoadImage(string IdEmploye)
        {
            using(SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\brunel\Projet\EMS\StaffPro V1.0\StaffPro V1.0\BD_StaffPro.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();
                string query = "SELECT Photo FROM employe WHERE IdEmploye = @idEmploye";
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idEmploye", IdEmploye);
                    byte[] imageBytes = cmd.ExecuteScalar() as byte[];
                    if(imageBytes != null)
                    {
                        //Convertir le tableau d'octets en une image et l'afficher dans le pictureBox
                        using(MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pbAfficherPhoto.Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                }
            }
        }

        public void CreatePDF()
        {
            // Créer un document PDF
            Document doc = new Document(PageSize.A4);


            string nom = "Fiche_Personnelle_De_" + lblNomEmploye.Text + "";
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
            Paragraph title = new Paragraph("Fiche personnelle ", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            title.Alignment = Element.ALIGN_CENTER;
            title.Font = FontFactory.GetFont("Arial", BaseFont.IDENTITY_H, true, 20, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            doc.Add(title);


            // Espacement
            doc.Add(new Paragraph("\n"));


            //Ajouter les informations personnelles
            PdfPTable table = new PdfPTable(2);
            table.WidthPercentage = 100;

            PdfPCell id = new PdfPCell(new Phrase("IDENTIFIANT :" + lblIdentifiantEmploye.Text));
            id.PaddingBottom = 10f;
            id.BorderWidth = 0f;
            table.AddCell(id);

            PdfPCell noms = new PdfPCell(new Phrase("NOM : " + lblNomEmploye.Text));
            noms.PaddingBottom = 10f;
            noms.BorderWidth = 0f;
            table.AddCell(noms);

            PdfPCell prenom = new PdfPCell(new Phrase("PRENOM : " + lblPrenomEmploye.Text));
            prenom.PaddingBottom = 10f;
            prenom.BorderWidth = 0f;
            table.AddCell(prenom);

            PdfPCell sexe = new PdfPCell(new Phrase("SEXE : " + lblSexeEmploye.Text));
            sexe.PaddingBottom = 10f;
            sexe.BorderWidth = 0f;
            table.AddCell(sexe);

            PdfPCell tel = new PdfPCell(new Phrase("NUMERO DE TELEPHONE : " + lblNumTelEmploye.Text));
            tel.PaddingBottom = 10f;
            tel.BorderWidth = 0f;
            table.AddCell(tel);

            PdfPCell poste = new PdfPCell(new Phrase("POSTE : " + lblPosteEmploye.Text));
            poste.PaddingBottom = 10f;
            poste.BorderWidth = 0f;
            table.AddCell(poste);

            PdfPCell departement = new PdfPCell(new Phrase("DEPARTEMENT : " + lblDepartementEmploye.Text));
            departement.PaddingBottom = 10f;
            departement.BorderWidth = 0f;
            table.AddCell(departement);

            PdfPCell duree = new PdfPCell(new Phrase("DUREE CONTRAT : " + lblDureeContratEmploye.Text + " Mois"));
            duree.PaddingBottom = 10f;
            duree.BorderWidth = 0f;
            table.AddCell(duree);

            PdfPCell recrutement = new PdfPCell(new Phrase("DATE DE RECRUTEMENT : " + lblDateInsertionEmploye.Text));
            recrutement.PaddingBottom = 10f;
            recrutement.BorderWidth = 0f;
            table.AddCell(recrutement);

            PdfPCell modif = new PdfPCell(new Phrase("DERNIERE MODIFICATION : " + lblDerniereModificationEmploye.Text));
            modif.PaddingBottom = 10f;
            modif.BorderWidth = 0f;
            table.AddCell(modif);

            PdfPCell salaire = new PdfPCell(new Phrase("SALAIRE : " + lblSalaireEmploye.Text + " FCFA"));
            salaire.PaddingBottom = 10f;
            salaire.BorderWidth = 0f;
            table.AddCell(salaire);

            PdfPCell statut = new PdfPCell(new Phrase("STATUT : " + lblStatutEmploye.Text));
            statut.PaddingBottom = 10f;
            statut.BorderWidth = 0f;
            table.AddCell(statut);

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
        private void btnImprimerFiche_Click(object sender, EventArgs e)
        {
            i = i + 1;
            CreatePDF();


        }

        private void lblStatutEmploye_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPoste_Click(object sender, EventArgs e)
        {

        }

        private void lblPosteEmploye_Click(object sender, EventArgs e)
        {

        }
    }
}
