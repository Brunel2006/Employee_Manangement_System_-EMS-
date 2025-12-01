using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StaffPro_V1._0
{
    class DataSalaire
    {
        public string IdEmploye { set; get; }

        public string Nom { set; get; }

        public string Poste { set; get; }

        public string Salaire { set; get; }



        SqlConnection connect
           = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\brunel\Projet\EMS\StaffPro V1.0\StaffPro V1.0\BD_StaffPro.mdf;Integrated Security=True;Connect Timeout=30");



        public List<DataSalaire> SalaryEmployeListData()
        {

            List<DataSalaire> listdata = new List<DataSalaire>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT IdEmploye, NomEmploye, PosteEmploye, SalaireEmploye FROM employe WHERE StatutEmploye = 'EN SERVICE'";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DataSalaire ed = new DataSalaire();
                            ed.IdEmploye = reader["Id"].ToString();
                            ed.Nom = reader["Nom"].ToString();
                            ed.Poste = reader["Poste"].ToString();
                            ed.Salaire = (reader["Salaire"]).ToString();



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
