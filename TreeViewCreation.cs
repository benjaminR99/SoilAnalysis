using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front
{
    public  class TreeViewCreation
    {
        public  string sampleid;
        public void InitializeTreeView(TreeView treeView)
        {
            // Create root node
            TreeNode rootNode = new TreeNode("Soil Tests");

            List<TreeNode> list = new List<TreeNode>() {
                new TreeNode("Particle size Seive Analysis"),
                new TreeNode("Density Tests"),
                new TreeNode("Specific Gravity test"),
                new TreeNode("Atterberg Limit tests")
            };

            // add nodes
            foreach (TreeNode node in list)
            {
                rootNode.Nodes.Add(node);
            }
            List<TreeNode> Densitytests = new List<TreeNode>() {
                new TreeNode("Core cutter Method"),
                new TreeNode("Sand Cone Method")
            };
            List<TreeNode> AttLimit = new List<TreeNode>() {
                new TreeNode("Liquid Limit Test"),
                new TreeNode("Plastic Limit Test")
            };
            // Add root node to the TreeView
            treeView.Nodes.Add(rootNode);

            try
            {
                foreach (int i in new int[] { 1, 3 })
                {
                    TreeNode node2 = treeView.Nodes[0].Nodes[i];
                    if (i == 1)
                    {
                        foreach (TreeNode node in Densitytests)
                        {
                            node2.Nodes.Add(node);
                        }
                    }
                    else
                    {
                        foreach (TreeNode node in AttLimit)
                        {
                            node2.Nodes.Add(node);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            treeView.ExpandAll();
        }

        public  void AddEvents(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Nodes.Count == 0) {
                OpenLeafForm(e.Node.Text); //If it's a leaf node
            }
            else {
                //parent node
                MessageBox.Show("Select below to do tests", "Click below", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
        }
        public  void OpenLeafForm(string leafNodeText)
        {
            // Customize this based on your form class names and their instantiation
            switch (leafNodeText)
            {
                case "Particle size Seive Analysis":
                    ParticleSizeDistribution particleSizeDistribution = new ParticleSizeDistribution(sampleid);
                    particleSizeDistribution.Show();
                    break; 
                case "Core cutter Method":
                   CoreCutter coreCutter = new CoreCutter(sampleid);
                    coreCutter.Show();
                    break;

                case "Sand Cone Method":
                    SandCorn sandCorn = new SandCorn(sampleid); 
                    sandCorn.Show();
                    break;

                case "Liquid Limit Test":
                    //LiquidLimitForm liquidLimitForm = new LiquidLimitForm();
                    //liquidLimitForm.Show();
                    break;

                case "Plastic Limit Test":
                    //PlasticLimitForm plasticLimitForm = new PlasticLimitForm();
                    //plasticLimitForm.Show();
                    break;

                // Add more cases for other leaf nodes and their corresponding forms

                default:
                    MessageBox.Show("No form defined for this leaf node.");
                    break;
            }
        }

    }
}
