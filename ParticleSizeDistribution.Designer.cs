namespace Front
{
    partial class ParticleSizeDistribution
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            plotView = new OxyPlot.WindowsForms.PlotView();
            label1 = new Label();
            label2 = new Label();
            txtCU = new TextBox();
            txtCC = new TextBox();
            button2 = new Button();
            SeiveSize = new DataGridViewTextBoxColumn();
            Retaining_Wheight = new DataGridViewTextBoxColumn();
            Passing = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 45);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 13);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Teal;
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 553);
            panel6.Name = "panel6";
            panel6.Size = new Size(846, 20);
            panel6.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SeiveSize, Retaining_Wheight, Passing });
            dataGridView1.Location = new Point(12, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(344, 372);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderColor = Color.DarkSlateGray;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.MintCream;
            button1.Location = new Point(227, 442);
            button1.Name = "button1";
            button1.Size = new Size(129, 39);
            button1.TabIndex = 4;
            button1.Text = "Analyze";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // plotView
            // 
            plotView.Location = new Point(362, 64);
            plotView.Name = "plotView";
            plotView.PanCursor = Cursors.Hand;
            plotView.Size = new Size(465, 291);
            plotView.TabIndex = 7;
            plotView.Text = "plotView1";
            plotView.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(458, 380);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 8;
            label1.Text = " Cu Value:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SansSerif", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(456, 414);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 9;
            label2.Text = " CC Value:";
            // 
            // txtCU
            // 
            txtCU.Location = new Point(544, 374);
            txtCU.Name = "txtCU";
            txtCU.ReadOnly = true;
            txtCU.Size = new Size(230, 23);
            txtCU.TabIndex = 10;
            // 
            // txtCC
            // 
            txtCC.Location = new Point(544, 408);
            txtCC.Name = "txtCC";
            txtCC.ReadOnly = true;
            txtCC.Size = new Size(230, 23);
            txtCC.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Enabled = false;
            button2.FlatAppearance.BorderColor = Color.DarkSlateGray;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.MintCream;
            button2.Location = new Point(597, 442);
            button2.Name = "button2";
            button2.Size = new Size(177, 39);
            button2.TabIndex = 12;
            button2.Text = "Add to soil properties";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // SeiveSize
            // 
            SeiveSize.HeaderText = "Seive size(mm)";
            SeiveSize.Name = "SeiveSize";
            // 
            // Retaining_Wheight
            // 
            Retaining_Wheight.HeaderText = "Retainig Wheight(g)";
            Retaining_Wheight.Name = "Retaining_Wheight";
            // 
            // Passing
            // 
            Passing.HeaderText = "% Finer";
            Passing.Name = "Passing";
            Passing.ReadOnly = true;
            // 
            // ParticleSizeDistribution
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(846, 573);
            Controls.Add(button2);
            Controls.Add(txtCC);
            Controls.Add(txtCU);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(plotView);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ParticleSizeDistribution";
            Text = "ParticleSizeDistribution";
            Load += ParticleSizeDistribution_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private DataGridView dataGridView1;
        private Button button1;
        private OxyPlot.WindowsForms.PlotView plotView;
        private Label label1;
        private Label label2;
        private TextBox txtCU;
        private TextBox txtCC;
        private Button button2;
        private DataGridViewTextBoxColumn SeiveSize;
        private DataGridViewTextBoxColumn Retaining_Wheight;
        private DataGridViewTextBoxColumn Passing;
    }
}