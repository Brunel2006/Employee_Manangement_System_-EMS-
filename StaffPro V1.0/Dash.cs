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
    public class Dash
    {
        SqlConnection connect
           = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\brunel\Projet\EMS\StaffPro V1.0\StaffPro V1.0\BD_StaffPro.mdf;Integrated Security=True;Connect Timeout=30");

        private DateTime startDate;
        private DateTime endDate;

        public int NumEmployes { get; private set; }
        public int NumEmployesByDate { get; set; }
        public List<KeyValuePair<string,int>> EmployeList { get; private set; }
        public List<KeyValuePair<string, string>> EmployeByDateList { get; private set; }


        public Dash()
        {

        }

        public void GetNumberEmploye()
        {

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    EmployeList = new List<KeyValuePair<string, int>>();
                    

                        //Nombre d'employés par departement

                        string selectData = "select NomDepartement, count(NomDepartement) from employe E, departement D where E.Departement = D.NomDepartement Group by NomDepartement order by NomDepartement asc; ";
                        using (SqlCommand command = new SqlCommand(selectData, connect))
                        {

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            EmployeList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                        }
                        reader.Close();
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
        
        public void GetEmployeByDate()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    EmployeByDateList = new List<KeyValuePair<string, string>>();

                    string selectData = @"select NomEmploye, PosteEmploye, Departement, DateInsertion from employe where DateInsertion between @fromdate and @todate; ";
                    using (var command = new SqlCommand(selectData, connect))
                    {
                        
                        //Nombre d'employé inscrit pendant une date precise
                        
                        command.Parameters.Add("@fromdate", System.Data.SqlDbType.DateTime).Value = startDate;
                        command.Parameters.Add("@todate", System.Data.SqlDbType.DateTime).Value = endDate;

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            EmployeByDateList.Add(new KeyValuePair<string, string>(reader[0].ToString(), reader[1].ToString()));
                        }
                        reader.Close();
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
        public bool LoadD(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day);
            startDate = new DateTime(startDate.Year, startDate.Month, startDate.Day);
            this.startDate = startDate;
            this.endDate = endDate;
            GetNumberEmploye();
            GetEmployeByDate();
            return true;
        }
    }
}
