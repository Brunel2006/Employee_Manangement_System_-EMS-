using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StaffPro_V1._0
{
    class DataDashboard
    {

        

        public string NomEmploye { set; get; }

        public string PosteEmploye { set; get; }

        public string Departement { set; get; }

        public string DateInsertion { set; get; }


        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\brunel\Projet\EMS\StaffPro V1.0\StaffPro V1.0\BD_StaffPro.mdf;Integrated Security=True;Connect Timeout=30");

        public List<DataDashboard> DashboadListData(DateTime startDate, DateTime endDate)
        {
            List<DataDashboard> listdata = new List<DataDashboard>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    

                    string selectData = @"select NomEmploye, PosteEmploye, Departement, DateInsertion from employe where DateInsertion between @fromdate and @todate; ";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        
                        cmd.Parameters.AddWithValue("@fromdate", startDate);
                        cmd.Parameters.AddWithValue("@todate", endDate);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DataDashboard ed = new DataDashboard();
                            ed.NomEmploye = reader["Nom Employe"].ToString();
                            ed.PosteEmploye = reader["Poste Employe"].ToString();
                            ed.Departement = reader["Departement"].ToString();
                            ed.DateInsertion = reader["Date Insertion"].ToString();


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
