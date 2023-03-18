namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Continue_Click(object sender, EventArgs e)
        {
            if (InputDetails.Text.Length < 6)
            {
                MessageBox.Show("You have entered less than 6 digits. Your account number must be 6 digits. Please try again", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (/ add object of ATM here/ findAccount(InputDetails.Text) == null)
                {
                    MessageBox.Show("The account number you entered could not be found. Please try again", "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}