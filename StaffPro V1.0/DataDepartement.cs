using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StaffPro_V1._0
{
    class DataDepartement
    {

        public string NumDepartement { set; get; }

        public string NomDepartement { set; get; }


        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\brunel\Projet\EMS\StaffPro V1.0\StaffPro V1.0\BD_StaffPro.mdf;Integrated Security=True;Connect Timeout=30");

        public List<DataDepartement> DepartementListData() 
        {
            List<DataDepartement> listdata = new List<DataDepartement>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM departement";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DataDepartement ed = new DataDepartement();
                            ed.NumDepartement = reader["Num Departement"].ToString();
                            ed.NomDepartement = reader["Nom Departement"].ToString();


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
