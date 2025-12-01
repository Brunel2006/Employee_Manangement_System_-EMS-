using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StaffPro_V1._0
{
    public partial class Inscription : Form
    {
        SqlConnection connect 
            = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\brunel\Projet\EMS\StaffPro V1.0\StaffPro V1.0\BD_StaffPro.mdf;Integrated Security=True;Connect Timeout=30");
        public Inscription()
        {
            InitializeComponent();
        }

        private void lblInscription_Click(object sender, EventArgs e)
        {

        }

        private void ImageInscription_Click(object sender, EventArgs e)
        {

        }

        private void NomUtilisateurInscription_Click(object sender, EventArgs e)
        {
            NomUtilisateurInscription.Clear();
        }

        private void EmailInscription_Click(object sender, EventArgs e)
        {
            EmailInscription.Clear();
        }

        private void MotDePasseInscription_Click(object sender, EventArgs e)
        {
            MotDePasseInscription.Clear();
        }

        private void NomUtilisateurInscription_TextChanged(object sender, EventArgs e)
        {
            NomUtilisateurInscription.ForeColor = Color.Black;
        }

        private void EmailInscription_TextChanged(object sender, EventArgs e)
        {
            EmailInscription.ForeColor = Color.Black;
        }

        private void MotDePasseInscription_TextChanged(object sender, EventArgs e)
        {
            MotDePasseInscription.ForeColor = Color.Black;
        }

        private void chkAfficherMotDePasse_CheckedChanged(object sender, EventArgs e)
        {
            MotDePasseInscription.PasswordChar = chkAfficherMotDePasse.Checked ? '\0' : '*';
        }

        private void QuitterInscription_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();

            this.Hide();
            connexion.Show();
        }

        private void ImageAcceuil_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();

            this.Hide();
            acceuil.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();

            this.Hide();
            acceuil.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();

            this.Hide();
            acceuil.Show();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {

        }

        private void ValiderInscription_Click(object sender, EventArgs e)
        {
            if ((NomUtilisateurInscription.Text == "" || EmailInscription.Text == ""
                || MotDePasseInscription.Text == "") || (NomUtilisateurInscription.Text == "Nom Utilisateur"
                || EmailInscription.Text == "Email" || MotDePasseInscription.Text == "Mot de passe"))
            {

                lblErreur.Text = "Veuillez remplir tous les champs !!";
            }
            else {
                if (connect.State != ConnectionState.Open) {
                    try
                    {
                        connect.Open();

                        //Verification si l'utilisateur existe deja dans la base de données
                        string selectUserName = "SELECT COUNT(Username) FROM Users WHERE UserName = @UserName";
                        using (SqlCommand checkUser = new SqlCommand(selectUserName, connect)) 
                        {
                            checkUser.Parameters.AddWithValue("@Username", NomUtilisateurInscription.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(NomUtilisateurInscription.Text.Trim() + " est deja enregistré"
                                , "Message d'erreur ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else 
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO Users" +
                                    "(UserName, UserEmail, UserMdp, DateInscription)" +
                                    "VALUES(@UserName, @UserEmail, @UserMdp, @datelog)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@UserName", NomUtilisateurInscription.Text.Trim());
                                    cmd.Parameters.AddWithValue("@UserEmail", EmailInscription.Text.Trim());
                                    cmd.Parameters.AddWithValue("@UserMdp", MotDePasseInscription.Text.Trim());
                                    cmd.Parameters.AddWithValue("@datelog", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Inscription effectuée avec succes !!!"
                                        , "Confirmation ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Connexion connexion = new Connexion();
                                    connexion.Show();
                                    this.Hide();
                        
                            
                            }
                        
                        }

                        
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex, 
                            "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally 
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void QuitterInscription_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
