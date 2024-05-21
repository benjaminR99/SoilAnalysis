namespace Front
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            btnlogin = new Button();
            txtpwd = new TextBox();
            txtuser = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnOldSample = new Button();
            btnNewSample = new Button();
            panel4 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel9 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 45);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(35, 2);
            label4.Name = "label4";
            label4.Size = new Size(123, 40);
            label4.TabIndex = 1;
            label4.Text = "Geo tech";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1037, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(1087, 13);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Teal;
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 485);
            panel6.Name = "panel6";
            panel6.Size = new Size(1087, 20);
            panel6.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(btnlogin);
            panel3.Controls.Add(txtpwd);
            panel3.Controls.Add(txtuser);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 427);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Teal;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogin.ForeColor = SystemColors.ButtonHighlight;
            btnlogin.Location = new Point(90, 246);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(127, 47);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtpwd
            // 
            txtpwd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtpwd.Location = new Point(141, 180);
            txtpwd.Name = "txtpwd";
            txtpwd.PasswordChar = '*';
            txtpwd.Size = new Size(178, 29);
            txtpwd.TabIndex = 5;
            // 
            // txtuser
            // 
            txtuser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtuser.Location = new Point(141, 137);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(178, 29);
            txtuser.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 183);
            label6.Name = "label6";
            label6.Size = new Size(106, 21);
            label6.TabIndex = 3;
            label6.Text = "PASSWORD :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 140);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 1;
            label3.Text = "USER NAME :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(102, 62);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // btnOldSample
            // 
            btnOldSample.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOldSample.BackColor = Color.Silver;
            btnOldSample.Cursor = Cursors.Hand;
            btnOldSample.Enabled = false;
            btnOldSample.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOldSample.ForeColor = Color.White;
            btnOldSample.Location = new Point(16, 0);
            btnOldSample.Name = "btnOldSample";
            btnOldSample.Size = new Size(179, 54);
            btnOldSample.TabIndex = 4;
            btnOldSample.Text = "Start with Old Sample";
            btnOldSample.UseVisualStyleBackColor = false;
            btnOldSample.Click += btnOldSample_Click;
            // 
            // btnNewSample
            // 
            btnNewSample.BackColor = Color.Silver;
            btnNewSample.Cursor = Cursors.Hand;
            btnNewSample.Dock = DockStyle.Top;
            btnNewSample.Enabled = false;
            btnNewSample.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewSample.ForeColor = Color.White;
            btnNewSample.Location = new Point(0, 0);
            btnNewSample.Name = "btnNewSample";
            btnNewSample.Size = new Size(186, 54);
            btnNewSample.TabIndex = 3;
            btnNewSample.Text = "Creat New Sample";
            btnNewSample.UseVisualStyleBackColor = false;
            btnNewSample.Click += btnNewSample_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Right;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(795, 58);
            panel4.Name = "panel4";
            panel4.Size = new Size(292, 427);
            panel4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("HP Simplified Hans", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(26, 282);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(252, 91);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("HP Simplified Hans", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(26, 171);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(252, 91);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("HP Simplified Hans", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(26, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(252, 85);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 25);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 1;
            label2.Text = "Recent Samples";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(343, 58);
            panel5.Name = "panel5";
            panel5.Size = new Size(446, 345);
            panel5.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Left;
            panel8.AutoSize = true;
            panel8.Controls.Add(btnNewSample);
            panel8.Location = new Point(31, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(186, 54);
            panel8.TabIndex = 10;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Right;
            panel7.Controls.Add(btnOldSample);
            panel7.Location = new Point(231, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(198, 54);
            panel7.TabIndex = 11;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel9.Controls.Add(panel7);
            panel9.Controls.Add(panel8);
            panel9.Location = new Point(343, 406);
            panel9.Name = "panel9";
            panel9.Size = new Size(446, 79);
            panel9.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1087, 505);
            Controls.Add(panel9);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel3;
        private Panel panel4;
        private Button btnNewSample;
        private Button btnOldSample;
        private Panel panel5;
        private Label label2;
        private Panel panel8;
        private Panel panel7;
        private Panel panel9;
        private Button btnlogin;
        private TextBox txtpwd;
        private TextBox txtuser;
        private Label label6;
        private Label label3;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}