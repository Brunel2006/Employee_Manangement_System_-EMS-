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
    public partial class Connexion : Form
    {
        SqlConnection connect
            = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\BRUNEL\PROJET\EMS\STAFFPRO V1.0\STAFFPRO V1.0\BD_STAFFPRO.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Connexion()
        {
            InitializeComponent();
            this.progressBar1.Hide();
        }

        private void NomUtilisateurConnexion_Click(object sender, EventArgs e)
        {
            NomUtilisateurConnexion.Clear();
        }

        private void MotDePasseConnexion_Click(object sender, EventArgs e)
        {
            MotDePasseConnexion.Clear();
        }

        private void chkAfficherMotDePasseConnexion_CheckedChanged(object sender, EventArgs e)
        {
            MotDePasseConnexion.PasswordChar = chkAfficherMotDePasseConnexion.Checked ? '\0' : '*';
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();

            this.Hide();
            inscription.Show();
        }

        private void QuitterConnexion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ovalShape1_Click(object sender, EventArgs e)
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

        private void ValiderConnexion_Click(object sender, EventArgs e)
        {
            if ((NomUtilisateurConnexion.Text == "" || MotDePasseConnexion.Text == "") ||
                (NomUtilisateurConnexion.Text == "Nom Utilisateur" || MotDePasseConnexion.Text == "Mot de passe"))
            {

                lblErreur.Text = "Veuillez remplir tous les champs !!";
            }
            else 
            {
                if (connect.State == ConnectionState.Closed) 
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM Users WHERE UserName = @UserName " +
                            "AND UserMdp = @UserMdp";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect)) 
                        {
                            cmd.Parameters.AddWithValue("@UserName", NomUtilisateurConnexion.Text.Trim());
                            cmd.Parameters.AddWithValue("@UserMdp", MotDePasseConnexion.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Connexion éffectuée avec succes !!",
                                    "Confirmation ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.timer1.Start();
                                this.ValiderConnexion.Hide();
                                this.progressBar1.Show();
                                

                                if (progressBar1.Value >= progressBar1.Maximum)
                                {

                                    timer1.Stop();
                                    Menu menu = new Menu();
                                    menu.Show();
                                    this.Hide();
                                }


                            }
                            else 
                            {
                                MessageBox.Show("Nom d'utilisateur ou Mot de passe Incorrect !!!",
                                    "Message Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void NomUtilisateurConnexion_TextChanged(object sender, EventArgs e)
        {
            NomUtilisateurConnexion.ForeColor = Color.Black;
        }

        private void MotDePasseConnexion_TextChanged(object sender, EventArgs e)
        {
            MotDePasseConnexion.ForeColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(2);
            if (progressBar1.Value >= progressBar1.Maximum)
            {

                timer1.Stop();
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }

            
        }

        private void QuitterConnexion_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblConnexion_Click(object sender, EventArgs e)
        {

        }
    }
}
