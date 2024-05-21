using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class NewSample : Form
    {
        private string sampleID;

        //initiating tree view object
        TreeViewCreation tv = new TreeViewCreation();
        public NewSample()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        public void NewSample_Load(object sender, EventArgs e)
        {
            //initialize unenabled tree view
           
            tv.InitializeTreeView(treeView1);
            
        }

        public void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {  
            tv.AddEvents(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtSampleID.Text != string.Empty)
                {
                    DateTime selecteddate = txtReceivedDate.Value;
                    sampleID = txtSampleID.Text;
                    string mysqlDate = selecteddate.ToString("yyyy-MM-dd");
                    DatabaseConnecter.AddSoilDetails(txtSampleID.Text, txtLocation.Text, txtDescription.Text, mysqlDate);
                    treeView1.Enabled = true;
                    tv.sampleid = sampleID;
                }
                else
                {
                    MessageBox.Show("Fill the above feilds with suitable values", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }
    }
}
