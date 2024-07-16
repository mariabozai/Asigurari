namespace Asigurari
{
    partial class RCAInsurance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rca_grid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rca_clear = new System.Windows.Forms.Button();
            this.rca_delete = new System.Windows.Forms.Button();
            this.rca_update = new System.Windows.Forms.Button();
            this.rca_add = new System.Windows.Forms.Button();
            this.insured_vehicle = new System.Windows.Forms.TextBox();
            this.startt_date = new System.Windows.Forms.TextBox();
            this.end_date = new System.Windows.Forms.TextBox();
            this.premium = new System.Windows.Forms.TextBox();
            this.insured_person = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rca_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 30);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(1038, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 26);
            this.label11.TabIndex = 12;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "RCA Insurance";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(8, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 188);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.rca_grid);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1058, 188);
            this.panel3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "RCA Insurance Data";
            // 
            // rca_grid
            // 
            this.rca_grid.AllowUserToAddRows = false;
            this.rca_grid.AllowUserToDeleteRows = false;
            this.rca_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rca_grid.Location = new System.Drawing.Point(11, 32);
            this.rca_grid.Name = "rca_grid";
            this.rca_grid.ReadOnly = true;
            this.rca_grid.RowHeadersWidth = 62;
            this.rca_grid.RowTemplate.Height = 28;
            this.rca_grid.Size = new System.Drawing.Size(1029, 141);
            this.rca_grid.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(530, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Insured person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "RCA Insurance Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(265, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Insured person";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 141);
            this.dataGridView1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Insured vehicle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Insured person";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Controls.Add(this.rca_clear);
            this.panel4.Controls.Add(this.rca_delete);
            this.panel4.Controls.Add(this.rca_update);
            this.panel4.Controls.Add(this.rca_add);
            this.panel4.Controls.Add(this.insured_vehicle);
            this.panel4.Controls.Add(this.startt_date);
            this.panel4.Controls.Add(this.end_date);
            this.panel4.Controls.Add(this.premium);
            this.panel4.Controls.Add(this.insured_person);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(12, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1053, 280);
            this.panel4.TabIndex = 3;
            // 
            // rca_clear
            // 
            this.rca_clear.BackColor = System.Drawing.Color.Silver;
            this.rca_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rca_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rca_clear.Location = new System.Drawing.Point(726, 143);
            this.rca_clear.Name = "rca_clear";
            this.rca_clear.Size = new System.Drawing.Size(122, 45);
            this.rca_clear.TabIndex = 13;
            this.rca_clear.Text = "Clear";
            this.rca_clear.UseVisualStyleBackColor = false;
            // 
            // rca_delete
            // 
            this.rca_delete.BackColor = System.Drawing.Color.Silver;
            this.rca_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rca_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rca_delete.Location = new System.Drawing.Point(726, 203);
            this.rca_delete.Name = "rca_delete";
            this.rca_delete.Size = new System.Drawing.Size(122, 45);
            this.rca_delete.TabIndex = 12;
            this.rca_delete.Text = "Delete";
            this.rca_delete.UseVisualStyleBackColor = false;
            this.rca_delete.Click += new System.EventHandler(this.rca_delete_Click);
            // 
            // rca_update
            // 
            this.rca_update.BackColor = System.Drawing.Color.Silver;
            this.rca_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rca_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rca_update.Location = new System.Drawing.Point(726, 83);
            this.rca_update.Name = "rca_update";
            this.rca_update.Size = new System.Drawing.Size(122, 45);
            this.rca_update.TabIndex = 11;
            this.rca_update.Text = "Update";
            this.rca_update.UseVisualStyleBackColor = false;
            // 
            // rca_add
            // 
            this.rca_add.BackColor = System.Drawing.Color.Silver;
            this.rca_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rca_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rca_add.Location = new System.Drawing.Point(726, 22);
            this.rca_add.Name = "rca_add";
            this.rca_add.Size = new System.Drawing.Size(122, 45);
            this.rca_add.TabIndex = 10;
            this.rca_add.Text = "Add";
            this.rca_add.UseVisualStyleBackColor = false;
            this.rca_add.Click += new System.EventHandler(this.rca_add_Click);
            // 
            // insured_vehicle
            // 
            this.insured_vehicle.Location = new System.Drawing.Point(180, 84);
            this.insured_vehicle.Name = "insured_vehicle";
            this.insured_vehicle.Size = new System.Drawing.Size(316, 26);
            this.insured_vehicle.TabIndex = 9;
            // 
            // startt_date
            // 
            this.startt_date.Location = new System.Drawing.Point(180, 134);
            this.startt_date.Name = "startt_date";
            this.startt_date.Size = new System.Drawing.Size(316, 26);
            this.startt_date.TabIndex = 8;
            // 
            // end_date
            // 
            this.end_date.Location = new System.Drawing.Point(180, 183);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(316, 26);
            this.end_date.TabIndex = 7;
            // 
            // premium
            // 
            this.premium.Location = new System.Drawing.Point(180, 233);
            this.premium.Name = "premium";
            this.premium.Size = new System.Drawing.Size(316, 26);
            this.premium.TabIndex = 6;
            // 
            // insured_person
            // 
            this.insured_person.Location = new System.Drawing.Point(180, 33);
            this.insured_person.Name = "insured_person";
            this.insured_person.Size = new System.Drawing.Size(316, 26);
            this.insured_person.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(18, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Start date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(18, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "End date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Price";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button5.Location = new System.Drawing.Point(12, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 27);
            this.button5.TabIndex = 14;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // RCAInsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RCAInsurance";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rca_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView rca_grid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox insured_vehicle;
        private System.Windows.Forms.TextBox startt_date;
        private System.Windows.Forms.TextBox end_date;
        private System.Windows.Forms.TextBox premium;
        private System.Windows.Forms.TextBox insured_person;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button rca_clear;
        private System.Windows.Forms.Button rca_delete;
        private System.Windows.Forms.Button rca_update;
        private System.Windows.Forms.Button rca_add;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
    }
}