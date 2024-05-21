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
    public partial class SandCorn : Form
    {

        private string sampleID;
        public float sanddensity;
        public float soilBulkdensity;
        public float massofbottlefilledwithsand;
        float drydensity;
        public SandCorn(string sampleID)
        {
            InitializeComponent();
            this.sampleID = sampleID;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            try
            {
                if (float.TryParse(txtMassBAS.Text, out massofbottlefilledwithsand) && float.TryParse(txtMassOFB.Text, out float MassOfBot) && float.TryParse(txtVolOFBot.Text, out float Volume))
                {
                    sanddensity = (massofbottlefilledwithsand - MassOfBot) / Volume;
                    txtSandDen.Text = sanddensity.ToString("F2");
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

        private void textBox12_Enter(object sender, EventArgs e)
        {

        }

        private void txtPanMass_Leave(object sender, EventArgs e)
        {
            float MasAfInvert;
            float massAfterFillingHole;
            float massofwetsoilandpan;
            float massofpan;
            try
            {
                if (float.TryParse(txtMassAfInv.Text, out MasAfInvert) && float.TryParse(txtMasAfFill.Text, out massAfterFillingHole) && float.TryParse(textBox7.Text, out massofwetsoilandpan) && float.TryParse(txtPanMass.Text, out massofpan))
                {
                    float volumeofhole = ((MasAfInvert - massAfterFillingHole) - (massofbottlefilledwithsand - MasAfInvert)) / sanddensity;
                    float massofwetsoil = massofwetsoilandpan - massofpan;
                    soilBulkdensity = massofwetsoil / volumeofhole;
                    txtMassofSoil.Text = massofwetsoil.ToString("F2");
                    txtVolumeofHole.Text = (volumeofhole * 1000).ToString("F3") + " ×10-3 cubic meters";
                    txtSoilBulkDensity.Text = soilBulkdensity.ToString();
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

        private void txtcan_Leave(object sender, EventArgs e)
        {
            float masswetsoilandcan;
            float massdrysoilandcan;
            float masscan;
            
            try
            {
                if (float.TryParse(txtwetsoilandcan.Text, out masswetsoilandcan) && float.TryParse(txtdrysoilandcan.Text, out massdrysoilandcan) && float.TryParse(txtcan.Text, out masscan))
                {
                    float massofdry = massdrysoilandcan - masscan;
                    float moiture = masswetsoilandcan - massdrysoilandcan;
                    float moiturecontent = moiture / massofdry;
                    txtMoise.Text = (moiturecontent * 100).ToString("F2");

                     drydensity = soilBulkdensity / (1 + moiturecontent);

                    txtdrysoil.Text = massofdry.ToString("F2");
                    txtDrydensity.Text = (drydensity).ToString("F2") + "";
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
            DatabaseConnecter.AddInDenSandCone(sampleID, drydensity);
        }
    }
}
