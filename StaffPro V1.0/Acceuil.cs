using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffPro_V1._0
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void QuitterAcceuil_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            
            Inscription inscription = new Inscription();

            inscription.Show();
            this.Hide();

        }

        private void lnkConnexion_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();

            connexion.Show();
            this.Hide();
        }
    }
}
