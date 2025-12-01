using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StaffPro_V1._0
{
    public partial class Departement : UserControl
    {
        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\brunel\Projet\EMS\StaffPro V1.0\StaffPro V1.0\BD_StaffPro.mdf;Integrated Security=True;Connect Timeout=30");

        public Departement()
        {
            InitializeComponent();
            populate();
            displayDepartementData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayDepartementData();
        }
        private void populate()
        {
            connect.Open();
            string query = "SELECT * FROM departement";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataDepartement.DataSource = ds.Tables[0];
            connect.Close();
        }
        private void CleanAll()
        {
            NumDepartement.Clear();
            NomDepartement.Clear();
            NumDepartement.Enabled = true;

        }

        public void displayDepartementData()
        {
            DataDepartement ed = new DataDepartement();
            List<DataDepartement> listData = ed.DepartementListData();

            dataDepartement.DataSource = listData;
        }

        private void btnAjouterDepartement_Click(object sender, EventArgs e)
        {
            if (NumDepartement.Text == "" || NomDepartement.Text == "")
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

                        string checkEmID = "SELECT count(*) FROM departement WHERE NumDepartement = '"+ NumDepartement.Text +"'";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Le departement "+NomDepartement.Text+" existe deja !!!",
                    "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO departement " +
                                    "(NumDepartement, NomDepartement) VALUES ('"+NumDepartement.Text+"', '"+NomDepartement.Text+"') ";
                                

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.ExecuteNonQuery();
                                    displayDepartementData();
                                    MessageBox.Show("Departement ajouté avec succès !!!",
                    "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CleanAll();
                                    connect.Close();
                                    populate();
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

        private void Departement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataDepartement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NumDepartement.Text = dataDepartement.SelectedRows[0].Cells[0].Value.ToString();
            NomDepartement.Text = dataDepartement.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnAnnulerDepartement_Click(object sender, EventArgs e)
        {
            CleanAll();
        }

        private void btnModifierDepartment_Click(object sender, EventArgs e)
        {

            if (NumDepartement.Text == "" || NomDepartement.Text == "")
            {
                MessageBox.Show("Données manquantes dans les champs !!",
                   "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {



                try
                {

                    connect.Open();
                    DateTime today = DateTime.Now;
                    string updateData = "UPDATE departement set NomDepartement ='" + NomDepartement.Text + "' where NumDepartement = '"+ NumDepartement.Text +"' ";
                    using (SqlCommand cmd = new SqlCommand(updateData, connect))
                    {

                        cmd.ExecuteNonQuery();

                        displayDepartementData();

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

        }

        private void dataDepartement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                connect.Open();
                DataGridViewRow row = dataDepartement.Rows[e.RowIndex];
                NumDepartement.Text = row.Cells[0].Value.ToString();
                NomDepartement.Text = row.Cells[1].Value.ToString();

                NumDepartement.Enabled = false;
                connect.Close();
            }
        }
    }
}
