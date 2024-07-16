using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace Asigurari
{
    public partial class RCAInsurance : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maria\OneDrive\Documente\loginData.mdf;Integrated Security=True;Connect Timeout=30");

        int Key = 0;
        public RCAInsurance()
        {
            InitializeComponent();

            rcaDisplayData();
        }

        private void rcaDisplayData()
        {
            connect.Open();
            string query = "SELECT rca_id as Id, insured_person as InsuredPerson, insured_vehicle as InsuredVehicle, Startt_date as StartDate," +
                " end_date as EndDate, premium as Price FROM Rca;";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            rca_grid.DataSource = ds.Tables[0];
            connect.Close();
        }

        /*public void rcaDisplayData()
        {
            AddRcaData addRD = new AddRcaData();

            rca_grid.DataSource = addRD.rcaData();
        }
        */

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm mForm = new MainForm();
            mForm.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rca_add_Click(object sender, EventArgs e)
        {
            if(insured_person.Text == ""
                || insured_vehicle.Text == ""
                || startt_date.Text == ""
                || end_date.Text == ""
                || premium.Text == "")
            {
                MessageBox.Show("Please fill all blank fields");
            }
            else
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("insert into Rca(insured_person, insured_vehicle, startt_date, end_date, premium)values(@insured_person, @insured_vehicle, @startt_date, @end_date, @premium)", connect);
                    cmd.Parameters.AddWithValue("@insured_person", insured_person.Text);
                    cmd.Parameters.AddWithValue("@insured_vehicle", insured_vehicle.Text);
                    cmd.Parameters.AddWithValue("@startt_date", startt_date.Text);
                    cmd.Parameters.AddWithValue("@end_date", end_date.Text);
                    cmd.Parameters.AddWithValue("@premium", premium.Text);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Added policy!");
                    rcaDisplayData();
                    clearFields();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        public void clearFields()
        {
            insured_person.Text = "";
            insured_vehicle.Text = "";
            startt_date.Text = "";
            end_date.Text = "";
            premium.Text = "";

        }

        private void rca_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void rca_update_Click(object sender, EventArgs e)
        {
            if (insured_person.Text == ""
               || insured_vehicle.Text == ""
               || startt_date.Text == ""
               || end_date.Text == ""
               || premium.Text == "")
            {
                MessageBox.Show("Please fill all blank fields");
            }
            else
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("update Rca set insured_person=@insured_person, insured_vehicle=@insured_vehicle, startt_date=@startt_date, end_date=@end_date, premium=@premium where rca_id=@Key)", connect);
                    cmd.Parameters.AddWithValue("@insured_person", insured_person.Text);
                    cmd.Parameters.AddWithValue("@insured_vehicle", insured_vehicle.Text);
                    cmd.Parameters.AddWithValue("@startt_date", startt_date.Text);
                    cmd.Parameters.AddWithValue("@end_date", end_date.Text);
                    cmd.Parameters.AddWithValue("@premium", premium.Text);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Updated policy!");
                    rcaDisplayData();
                    clearFields();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void rca_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var selectedRow = rca_grid.Rows[e.RowIndex];

                    int rca_id = 0;
                    //int insured_person = 1;
                    //int insured_policy = 2;
                    //int Startt_date = 3;
                    //int end_date = 4;
                   // int premium = 5;
                   
                    if (selectedRow.Cells.Count > 6)
                    {   
                        //rca_id.Text= GetCellValue(selectedRow,0);
                        insured_person.Text = GetCellValue(selectedRow, 1);
                        insured_vehicle.Text = GetCellValue(selectedRow, 2);
                        startt_date.Text = GetCellValue(selectedRow, 3);
                        end_date.Text = GetCellValue(selectedRow, 4);
                        premium.Text = GetCellValue(selectedRow, 5);
                        //insured_person.Text = GetCellValue(selectedRow, insuredPersonIndex);
                        //insured_vehicle.Text = GetCellValue(selectedRow, firstnameIndex);
                        //startt_date.Text = GetCellValue(selectedRow, dobIndex);
                        //end_date.Text = GetCellValue(selectedRow, genderIndex);
                        //premium.Text = GetCellValue(selectedRow, premiumIndex);
                        
                        if (int.TryParse(GetCellValue(selectedRow, rca_id), out int keyValue))
                        {
                            Key = keyValue;
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetCellValue(DataGridViewRow row, int columnIndex)
        {
            var cellValue = row.Cells[columnIndex].Value;

            if (cellValue == null)
            {
                return string.Empty;
            }

            if (cellValue is string stringValue)
            {
                return stringValue;
            }

            return cellValue.ToString();
        }

        private void rca_delete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select policy.");
            }
            else
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("delete from pacient where pacientID=@Key", connect);

                    cmd.Parameters.AddWithValue("@Key", Key);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Pacient șters.");
                    rcaDisplayData();
                    clearFields();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
