namespace Front
{
    partial class CoreCutter
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            txtBulkDEn = new TextBox();
            txtMassWetsoil = new TextBox();
            txtVolCut = new TextBox();
            txtPan = new TextBox();
            txtWetsoilandpan = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            txtDryDensity = new TextBox();
            txtMoisture = new TextBox();
            txtDrysoil = new TextBox();
            txtCAn = new TextBox();
            txtDrysoilandcan = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtWetsoilandCan = new TextBox();
            label7 = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 45);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 13);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Teal;
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 534);
            panel6.Name = "panel6";
            panel6.Size = new Size(896, 20);
            panel6.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtBulkDEn);
            panel3.Controls.Add(txtMassWetsoil);
            panel3.Controls.Add(txtVolCut);
            panel3.Controls.Add(txtPan);
            panel3.Controls.Add(txtWetsoilandpan);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(896, 215);
            panel3.TabIndex = 6;
            // 
            // txtBulkDEn
            // 
            txtBulkDEn.ForeColor = Color.Red;
            txtBulkDEn.Location = new Point(725, 105);
            txtBulkDEn.Name = "txtBulkDEn";
            txtBulkDEn.ReadOnly = true;
            txtBulkDEn.Size = new Size(159, 23);
            txtBulkDEn.TabIndex = 10;
            // 
            // txtMassWetsoil
            // 
            txtMassWetsoil.Location = new Point(725, 67);
            txtMassWetsoil.Name = "txtMassWetsoil";
            txtMassWetsoil.ReadOnly = true;
            txtMassWetsoil.Size = new Size(159, 23);
            txtMassWetsoil.TabIndex = 9;
            txtMassWetsoil.Enter += txtMassWetsoil_Enter;
            // 
            // txtVolCut
            // 
            txtVolCut.Location = new Point(307, 148);
            txtVolCut.Name = "txtVolCut";
            txtVolCut.Size = new Size(159, 23);
            txtVolCut.TabIndex = 8;
            // 
            // txtPan
            // 
            txtPan.Location = new Point(307, 105);
            txtPan.Name = "txtPan";
            txtPan.Size = new Size(159, 23);
            txtPan.TabIndex = 7;
            // 
            // txtWetsoilandpan
            // 
            txtWetsoilandpan.Location = new Point(307, 65);
            txtWetsoilandpan.Name = "txtWetsoilandpan";
            txtWetsoilandpan.Size = new Size(159, 23);
            txtWetsoilandpan.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(43, 150);
            label6.Name = "label6";
            label6.Size = new Size(259, 21);
            label6.TabIndex = 5;
            label6.Text = "Volume of Core Cutter (m cubes)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(548, 67);
            label5.Name = "label5";
            label5.Size = new Size(171, 21);
            label5.TabIndex = 4;
            label5.Text = "Mass of Wet Soil (kg)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(163, 105);
            label4.Name = "label4";
            label4.Size = new Size(136, 21);
            label4.TabIndex = 3;
            label4.Text = "Mass of Pan (kg)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(88, 67);
            label3.Name = "label3";
            label3.Size = new Size(214, 21);
            label3.TabIndex = 2;
            label3.Text = "Mass of wet soil + Pan (kg)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(518, 107);
            label2.Name = "label2";
            label2.Size = new Size(201, 25);
            label2.TabIndex = 1;
            label2.Text = "Bulk Density (kgm-3)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(145, 3);
            label1.Name = "label1";
            label1.Size = new Size(472, 39);
            label1.TabIndex = 0;
            label1.Text = "Insitu Density by core cutter method";
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(txtDryDensity);
            panel4.Controls.Add(txtMoisture);
            panel4.Controls.Add(txtDrysoil);
            panel4.Controls.Add(txtCAn);
            panel4.Controls.Add(txtDrysoilandcan);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(txtWetsoilandCan);
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 273);
            panel4.Name = "panel4";
            panel4.Size = new Size(896, 261);
            panel4.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderColor = Color.DarkSlateGray;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.MintCream;
            button1.Location = new Point(668, 161);
            button1.Name = "button1";
            button1.Size = new Size(133, 58);
            button1.TabIndex = 20;
            button1.Text = "Add to soil Property";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtDryDensity
            // 
            txtDryDensity.ForeColor = Color.Red;
            txtDryDensity.Location = new Point(725, 87);
            txtDryDensity.Name = "txtDryDensity";
            txtDryDensity.ReadOnly = true;
            txtDryDensity.Size = new Size(159, 23);
            txtDryDensity.TabIndex = 19;
            // 
            // txtMoisture
            // 
            txtMoisture.Location = new Point(725, 41);
            txtMoisture.Name = "txtMoisture";
            txtMoisture.ReadOnly = true;
            txtMoisture.Size = new Size(159, 23);
            txtMoisture.TabIndex = 18;
            // 
            // txtDrysoil
            // 
            txtDrysoil.Location = new Point(307, 208);
            txtDrysoil.Name = "txtDrysoil";
            txtDrysoil.ReadOnly = true;
            txtDrysoil.Size = new Size(159, 23);
            txtDrysoil.TabIndex = 17;
            // 
            // txtCAn
            // 
            txtCAn.Location = new Point(307, 147);
            txtCAn.Name = "txtCAn";
            txtCAn.Size = new Size(159, 23);
            txtCAn.TabIndex = 16;
            txtCAn.Leave += txtCAn_Leave;
            // 
            // txtDrysoilandcan
            // 
            txtDrysoilandcan.Location = new Point(307, 89);
            txtDrysoilandcan.Name = "txtDrysoilandcan";
            txtDrysoilandcan.Size = new Size(159, 23);
            txtDrysoilandcan.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(528, 87);
            label12.Name = "label12";
            label12.Size = new Size(191, 25);
            label12.TabIndex = 14;
            label12.Text = "Dry density (kgm-3)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(576, 41);
            label11.Name = "label11";
            label11.Size = new Size(143, 21);
            label11.TabIndex = 13;
            label11.Text = "Moisture Content";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(69, 210);
            label10.Name = "label10";
            label10.Size = new Size(182, 21);
            label10.TabIndex = 12;
            label10.Text = "Wheight of dry soil (g)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(70, 147);
            label9.Name = "label9";
            label9.Size = new Size(155, 21);
            label9.TabIndex = 11;
            label9.Text = "Wheight of Can (g)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(69, 89);
            label8.Name = "label8";
            label8.Size = new Size(230, 21);
            label8.TabIndex = 10;
            label8.Text = "Wheight of dry soil + Can (g)";
            // 
            // txtWetsoilandCan
            // 
            txtWetsoilandCan.Location = new Point(307, 39);
            txtWetsoilandCan.Name = "txtWetsoilandCan";
            txtWetsoilandCan.Size = new Size(159, 23);
            txtWetsoilandCan.TabIndex = 9;
            txtWetsoilandCan.Enter += txtWetsoilandCan_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(69, 41);
            label7.Name = "label7";
            label7.Size = new Size(233, 21);
            label7.TabIndex = 3;
            label7.Text = "Wheight of wet soil + Can (g)";
            // 
            // CoreCutter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 554);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CoreCutter";
            Text = "CoreCutter";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtBulkDEn;
        private TextBox txtMassWetsoil;
        private TextBox txtVolCut;
        private TextBox txtPan;
        private TextBox txtWetsoilandpan;
        private TextBox txtWetsoilandCan;
        private Label label7;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtDryDensity;
        private TextBox txtMoisture;
        private TextBox txtDrysoil;
        private TextBox txtCAn;
        private TextBox txtDrysoilandcan;
        private Button button1;
    }
}