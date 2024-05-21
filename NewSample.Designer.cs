using System.Windows.Forms;

namespace Front
{
    partial class NewSample
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
            txtDescription = new TextBox();
            txtLocation = new TextBox();
            txtSampleID = new TextBox();
            txtReceivedDate = new DateTimePicker();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            treeView1 = new TreeView();
            panel5 = new Panel();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1021, 45);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(1021, 13);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Teal;
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 509);
            panel6.Name = "panel6";
            panel6.Size = new Size(1021, 20);
            panel6.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtDescription);
            panel3.Controls.Add(txtLocation);
            panel3.Controls.Add(txtSampleID);
            panel3.Controls.Add(txtReceivedDate);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(466, 451);
            panel3.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(169, 193);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(233, 23);
            txtDescription.TabIndex = 8;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(169, 122);
            txtLocation.Multiline = true;
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(233, 29);
            txtLocation.TabIndex = 7;
            // 
            // txtSampleID
            // 
            txtSampleID.Location = new Point(169, 58);
            txtSampleID.Name = "txtSampleID";
            txtSampleID.Size = new Size(233, 23);
            txtSampleID.TabIndex = 6;
            // 
            // txtReceivedDate
            // 
            txtReceivedDate.Location = new Point(169, 270);
            txtReceivedDate.Name = "txtReceivedDate";
            txtReceivedDate.Size = new Size(233, 23);
            txtReceivedDate.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderColor = Color.DarkSlateGray;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.MintCream;
            button1.Location = new Point(123, 360);
            button1.Name = "button1";
            button1.Size = new Size(129, 39);
            button1.TabIndex = 4;
            button1.Text = "Add Sample";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SansSerif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 273);
            label4.Name = "label4";
            label4.Size = new Size(123, 19);
            label4.TabIndex = 3;
            label4.Text = "Received Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SansSerif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 197);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SansSerif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(85, 132);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 1;
            label2.Text = "Location :";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(71, 62);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 0;
            label1.Text = "Sample ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Teal;
            label5.Font = new Font("SansSerif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(64, 27);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(387, 25);
            label5.TabIndex = 7;
            label5.Text = "To perform soil test with added sample ";
            // 
            // panel4
            // 
            panel4.Controls.Add(treeView1);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(469, 58);
            panel4.Name = "panel4";
            panel4.Size = new Size(552, 451);
            panel4.TabIndex = 8;
            // 
            // treeView1
            // 
            treeView1.BorderStyle = BorderStyle.None;
            treeView1.Enabled = false;
            treeView1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            treeView1.Location = new Point(0, 95);
            treeView1.Margin = new Padding(0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(613, 356);
            treeView1.TabIndex = 1;
            treeView1.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(552, 92);
            panel5.TabIndex = 0;
            // 
            // NewSample
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1021, 529);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "NewSample";
            Text = "NewSample";
            Load += NewSample_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel3;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker txtReceivedDate;
        private TextBox txtSampleID;
        private TextBox txtDescription;
        private TextBox txtLocation;
        private Label label5;
        private Panel panel4;
        private TreeView treeView1;
        private Panel panel5;
    }
}