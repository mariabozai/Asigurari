﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RCAInsurance rForm = new RCAInsurance();
            rForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Casco_Insurance cForm = new Casco_Insurance();
            cForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PADInsurance pForm = new PADInsurance();
            pForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OptionalHousingInsurance oForm = new OptionalHousingInsurance();
            oForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TravelInsurance tForm = new TravelInsurance();
            tForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LifeInsurance lForm = new LifeInsurance();
            lForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HealthInsurance hForm = new HealthInsurance();
            hForm.Show();
            this.Hide();
        }
    }
}
