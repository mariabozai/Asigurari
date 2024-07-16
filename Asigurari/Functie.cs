using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asigurari
{
    public partial class Functie : Form
    {
        public Functie()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void selectedRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = position.SelectedItem.ToString();

            // Deschide formularul corespunzător
            switch (selectedRole)
            {
                case "Admin":
                    MainForm mForm = new MainForm();
                    mForm.Show();
                    break;
                case "User":
                    MainForm uForm = new MainForm();
                    uForm.Show();
                    break;
                default:
                    MessageBox.Show("Unknown role selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
