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
    public partial class CoreCutter : Form
    {
        float Bulkdensity;
        private string sampleID;
        float Drydensity;
        public CoreCutter(string sampleID)
        {
            InitializeComponent();
            this.sampleID = sampleID;
        }

        private void txtWetsoilandCan_Enter(object sender, EventArgs e)
        {

        }

        private void txtCAn_Leave(object sender, EventArgs e)
        {
            try
            {
                if (float.TryParse(txtWetsoilandCan.Text, out float WetsoilandCan) && float.TryParse(txtDrysoilandcan.Text, out float Drysoilandcan) && float.TryParse(txtCAn.Text, out float can))
                {
                    float moisute = WetsoilandCan - Drysoilandcan;
                    float drysoil = Drysoilandcan - can;
                    float moisturecontent = moisute / drysoil;
                    txtDrysoil.Text = drysoil.ToString("F2");
                    txtMoisture.Text = (moisturecontent * 100).ToString("F2");
                    Drydensity = Bulkdensity / (1 + moisturecontent);
                    txtDryDensity.Text = (Drydensity).ToString("F2");
                }
                else
                {
                    MessageBox.Show("Fill the above feilds with suitable values", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill the above feilds with suitable values", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMassWetsoil_Enter(object sender, EventArgs e)
        {
            float Wetsoilpluspan;
            float pan;
            float volume;
            float wetsoil;
            try
            {
                if (float.TryParse(txtWetsoilandpan.Text, out Wetsoilpluspan) && float.TryParse(txtPan.Text, out pan) && float.TryParse(txtVolCut.Text, out volume))
                {
                    wetsoil = Wetsoilpluspan - pan;
                    Bulkdensity = wetsoil / volume;
                    txtMassWetsoil.Text = wetsoil.ToString("F3");
                    txtBulkDEn.Text = Bulkdensity.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Fill the above feilds with suitable values", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnecter.AddInDenCorecutter(sampleID, Drydensity);
        }
    }
}
