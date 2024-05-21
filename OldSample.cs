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
    public partial class OldSample : Form

    {
        private string sampleID;
        private string[] sampleDetails;

        //initiating tree view object
        TreeViewCreation tv2 = new TreeViewCreation();
        public OldSample()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OldSample_Load(object sender, EventArgs e)
        {
            tv2.InitializeTreeView(tvOld);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sampleID = txtSampleID.Text;
            sampleDetails = DatabaseConnecter.GetSampleDetails(sampleID);

            

            if(sampleDetails != null)
            {
                txtLoc.Text = sampleDetails[1];
                txtRDate.Text = sampleDetails[3];
                txtDesc.Text = sampleDetails[2];
                tv2.sampleid = sampleID;
                tvOld.Enabled = true;
            }
            
            string[] soilProps = DatabaseConnecter.GetSoilProperties(sampleID);
            
            if ( soilProps != null )
            {
                txtSG.Text = soilProps[1];
                txtLqd.Text = soilProps[2];
                txtCu.Text = soilProps[4];
                txtCc.Text = soilProps[5];
                txtCden.Text = soilProps[7];
                txtSDen.Text = soilProps[6];
            }

        }

        private void tvOld_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tv2.AddEvents(sender, e);
        }
    }
}
