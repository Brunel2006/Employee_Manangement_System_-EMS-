using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StaffPro_V1._0
{
    class DataSanction
    {

        public string IdSanction { set; get; }

        public string NomEmploye { set; get; }

        public string DateDebut { set; get; }

        public string DateFin { set; get; }

        public string TypeSanction { set; get; }

        public string Raison { set; get; }

        public string Commentaire { set; get; }



        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\brunel\Projet\EMS\StaffPro V1.0\StaffPro V1.0\BD_StaffPro.mdf;Integrated Security=True;Connect Timeout=30");



        public List<DataSanction> SanctionListData() 
        {

            List<DataSanction> listdata = new List<DataSanction>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM Sanction";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect)) 
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()) 
                        {
                            DataSanction ed = new DataSanction();
                            ed.IdSanction = reader["Id Sanction"].ToString();
                            ed.NomEmploye = reader["Nom Employe"].ToString();
                            ed.DateDebut = reader["Date de debut"].ToString();
                            ed.DateFin = reader["Date de fin"].ToString();
                            ed.TypeSanction = reader["Type de sanction"].ToString();
                            ed.Raison = reader["Raison"].ToString();
                            ed.Commentaire = reader["Commentaire"].ToString();


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
