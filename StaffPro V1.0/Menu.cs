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
    public partial class Menu : Form
    {

        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\brunel\Projet\EMS\StaffPro V1.0\StaffPro V1.0\BD_StaffPro.mdf;Integrated Security=True;Connect Timeout=30");

        public Menu()
        {
            InitializeComponent();
            
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Etes vous sure de vouloir quitter ???",
                "Message de Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes) 
            {
                Connexion connexion = new Connexion();
                this.Hide();
                connexion.Show();
            }
        }

        private void btnTableauDeBord_Click(object sender, EventArgs e)
        {
            
            dashBoard1.Visible = true;
            recrutement1.Visible = false;
            salaire1.Visible = false;
            sanction1.Visible = false;
            departement1.Visible = false;


            btnTableauDeBord.BackColor = Color.PaleTurquoise;
            btnRecrutement.BackColor = Color.DodgerBlue;
            btnSalaire.BackColor = Color.DodgerBlue;
            btnSanction.BackColor = Color.DodgerBlue;
            btnDepartement.BackColor = Color.DodgerBlue;

 
            DashBoard dashForm = dashBoard1 as DashBoard;
            if (dashForm != null) 
            {

                dashForm.RefreshData();
            }
        }

        private void btnRecrutement_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            recrutement1.Visible = true;
            salaire1.Visible = false;
            sanction1.Visible = false;
            departement1.Visible = false;

            btnTableauDeBord.BackColor = Color.DodgerBlue;
            btnRecrutement.BackColor = Color.PaleTurquoise;
            btnSalaire.BackColor = Color.DodgerBlue;
            btnSanction.BackColor = Color.DodgerBlue;
            btnDepartement.BackColor = Color.DodgerBlue;





        }

        private void btnSalaire_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            recrutement1.Visible = false;
            salaire1.Visible = true;
            sanction1.Visible = false;
            departement1.Visible = false;

            btnTableauDeBord.BackColor = Color.DodgerBlue;
            btnRecrutement.BackColor = Color.DodgerBlue;
            btnSalaire.BackColor = Color.PaleTurquoise;
            btnSanction.BackColor = Color.DodgerBlue;
            btnDepartement.BackColor = Color.DodgerBlue;

        }

        private void btnSanction_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            recrutement1.Visible = false;
            salaire1.Visible = false;
            sanction1.Visible = true;
            departement1.Visible = false;

            btnTableauDeBord.BackColor = Color.DodgerBlue;
            btnRecrutement.BackColor = Color.DodgerBlue;
            btnSalaire.BackColor = Color.DodgerBlue;
            btnSanction.BackColor = Color.PaleTurquoise;
            btnDepartement.BackColor = Color.DodgerBlue;


        }

        private void btnDepartement_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            recrutement1.Visible = false;
            salaire1.Visible = false;
            sanction1.Visible = false;
            departement1.Visible = true;


            btnTableauDeBord.BackColor = Color.DodgerBlue;
            btnRecrutement.BackColor = Color.DodgerBlue;
            btnSalaire.BackColor = Color.DodgerBlue;
            btnSanction.BackColor = Color.DodgerBlue;
            btnDepartement.BackColor = Color.PaleTurquoise;


        }

        private void QuitterMenu_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Etes vous sure de vouloir quitter ???",
                "Message de Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
