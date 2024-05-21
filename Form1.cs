namespace Front
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void btnNewSample_Click(object sender, EventArgs e)
        {
            NewSample newSample = new NewSample();
            newSample.Show();
        }

        private void btnOldSample_Click(object sender, EventArgs e)
        {
            OldSample oldSample = new OldSample();
            oldSample.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string userID = txtuser.Text;
            string pwd = txtpwd.Text;

            bool accepted = DatabaseConnecter.CheckUserCredentials(userID, pwd);
            if (accepted)
            {
                MessageBox.Show("Logged In", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNewSample.Enabled = true;
                btnOldSample.Enabled = true;
                btnNewSample.BackColor = Color.Teal;
                btnOldSample.BackColor = Color.Teal;
            }
            else
            {
                txtpwd.Text = "";
                txtuser.Text = "";
                txtuser.Focus();
                MessageBox.Show("Incorrect User ID or Password","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string[]> ThreeRecentSamples = DatabaseConnecter.GetThreeRecentSamples();
            int i = 0;
            string[] values = new string[] { textBox1.Text, textBox2.Text, textBox3.Text };

            foreach (string[] sample in ThreeRecentSamples)
            {
                values[i] = "sample id: " + sample[0] + Environment.NewLine + "from: " + sample[1] + Environment.NewLine + "Received on: " + sample[3].Substring(0,7) + Environment.NewLine + "Description: " + sample[2];
                i++;
            }
            textBox1.Text = values[0];
            textBox2.Text = values[1];
            textBox3.Text = values[2];

        }
    }
}