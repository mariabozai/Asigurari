using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Asigurari
{
    internal class AddRcaData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maria\OneDrive\Documente\loginData.mdf;Integrated Security=True;Connect Timeout=30");

        public int RcaID { set; get; }
        public string InsuredPerson { set; get; }
        public string InsuredVehicle { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public decimal Premium { set; get; }

        public List<AddRcaData> rcaData()
        {
            List<AddRcaData> listData = new List<AddRcaData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM Rca";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            
                            AddRcaData addRD= new AddRcaData();
                            addRD.RcaID = (int)reader["rca_id"];
                            addRD.InsuredPerson = reader["insured_person"].ToString();
                            addRD.InsuredVehicle = reader["insured_vehicle"].ToString();
                            addRD.StartDate = (DateTime)reader["startt_date"];
                            addRD.EndDate = (DateTime)reader["end_date"];
                            addRD.Premium = (decimal)reader["premium"];
                            

                            listData.Add(addRD);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting Database: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;
        }
    }
}

