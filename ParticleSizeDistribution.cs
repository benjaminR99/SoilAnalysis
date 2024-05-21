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
    public partial class ParticleSizeDistribution : Form
    {
        private String sampleID;
        public float CC = 0;
        public float CU = 0;
        List<float> listSeive;
        List<float> listRetainig;
        public ParticleSizeDistribution(String sampleID)
        {
            InitializeComponent();
            this.sampleID = sampleID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listSeive = new List<float>();
            listRetainig = new List<float>();
            int columnIndexForSeive = 0;
            int columnIndexForRetainig = 1;

            try
            {
                //getting the list of seive value and retainig vailues
                foreach (DataGridViewRow raw in dataGridView1.Rows)
                {
                    if (!raw.IsNewRow)
                    {
                        if (float.TryParse(raw.Cells[columnIndexForSeive].Value.ToString(), out float Seivevalue) && float.TryParse(raw.Cells[columnIndexForRetainig].Value.ToString(), out float Retainingvalue))
                        {
                            listSeive.Add(Seivevalue);
                            listRetainig.Add(Retainingvalue);
                        }
                        else
                        {
                            throw new Exception("Enter numeric values only");
                        }
                    }
                }

                //calculating the passing percenatge
                List<float> retaingPercentage = Calculations.CalcPassingPercentage(listRetainig);

                //adding result to dataGridView
                for (int i = 0; i < retaingPercentage.Count; i++) { dataGridView1.Rows[i].Cells[2].Value = retaingPercentage[i].ToString("F2"); }

                //plot the graph
                Graphing.InitializePlot(plotView, listSeive, retaingPercentage);
                float D30 = Calculations.DValue(30, listSeive, retaingPercentage);
                float D60 = Calculations.DValue(60, listSeive, retaingPercentage);
                float D10 = Calculations.DValue(10, listSeive, retaingPercentage);
                CC = Calculations.CCvalue(D60, D30, D10);
                CU = Calculations.CUvalue(D60, D10);
                button2.Enabled = true;
                //display result
                txtCC.Text = CC.GetType() == typeof(float) ? CC.ToString("F2") : "Not available";
                txtCU.Text = CU.GetType() == typeof(float) ? CU.ToString("F2") : "Not available";
            }
            catch (Exception ex)
            {
                plotView.Model = null;
                txtCC.Text = "Not available";
                txtCU.Text = "Not available";
                CU = 0; CC = 0;
                listRetainig.Clear();
                listSeive.Clear();
                button2.Enabled = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ParticleSizeDistribution_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Add to database
                if ((CU > 0) && (CC > 0))
                {
                    DatabaseConnecter.AddCUCC(sampleID, CU, CC);
                }
                else
                {
                    throw new Exception("Error : Not suitble values for CU or CC");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
