using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StaffPro_V1._0
{
    class DataEmploye
    {

        public string IdEmploye { set; get; }

        public string Nom { set; get; }

        public string Prenom { set; get; }

        public string Tel { set; get; }

        public string Sexe { set; get; }

        public string Poste { set; get; }

        public string DureeContrat { set; get; }

        public string Departement { set; get; }

        public string DateInsertion { set; get; }

        public string DateModification { set; get; }

        public string StatutEmploye { set; get; }

        public string SalaireEmploye { set; get; }




        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\brunel\Projet\EMS\StaffPro V1.0\StaffPro V1.0\BD_StaffPro.mdf;Integrated Security=True;Connect Timeout=30");



        public List<DataEmploye> EmployeListData() 
        {

            List<DataEmploye> listdata = new List<DataEmploye>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employe";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect)) 
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()) 
                        {
                            DataEmploye ed = new DataEmploye();
                            ed.IdEmploye = reader["IdEmploye"].ToString();
                            ed.Nom = reader["Nom Employe"].ToString();
                            ed.Prenom = reader["Prenom Employe"].ToString();
                            ed.Tel = reader["TelEmploye"].ToString();
                            ed.Sexe = reader["SexeEmploye"].ToString();
                            ed.Poste = reader["PosteEmploye"].ToString();
                            ed.DureeContrat = reader["DureeContrat"].ToString();
                            ed.Departement = reader["Departement"].ToString();
                            ed.DateInsertion = reader["DateInsertion"].ToString();
                            ed.DateModification = reader["DateModification"].ToString();
                            ed.StatutEmploye = reader["StatutEmploye"].ToString();
                            ed.SalaireEmploye = reader["SalaireEmploye"].ToString();

                            listdata.Add(ed);
                        }
                    
                    }

                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);

                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }



        


    }
}
