namespace ATM
{
    public partial class ATMForm : Form
    {
        public ATM atm;
        public Account activeAccount;
        private bool accountCorrect = false;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ATMForm(ATM atm)
        {
            this.atm = atm;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Continue_Click(object sender, EventArgs e)
        {
            if (!accountCorrect) //account screen
            {
                if (InputDetails.Text.Length < 6)
                {
                    InputDetails.Clear();
                    MessageBox.Show("You have entered less than 6 digits. Your account number must be 6 digits. Please try again", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    activeAccount = atm.findAccount(Convert.ToInt32(InputDetails.Text));
                    if (activeAccount == null)
                    {
                        InputDetails.Clear();
                        MessageBox.Show("The account number you entered could not be found. Please try again", "Error", MessageBoxButtons.OK);
                    }
                    else //changes form to ask for pin
                    {
                        InputDetails.Clear();
                        accountCorrect = true;
                        label1.Text = "Please enter pin";
                        InputDetails.MaxLength = 4;
                    }
                }
            }
            else //pin screen
            {
                if (InputDetails.Text.Length < 4)
                {
                    InputDetails.Clear();
                    MessageBox.Show("You have entered less than 4 digits. Your pin must be 4 digits. Please try again", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    if (activeAccount.checkPin(Convert.ToInt32(InputDetails.Text)))
                    {
                        this.Visible = false;
                        Options options = new Options(activeAccount, atm);
                        options.Show();
                    }
                    else
                    {
                        InputDetails.Clear();
                        MessageBox.Show("Incorrect pin. Please try again", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }

        /*private void DataRaceProb_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            activeAccount = atm.findAccount(111111);
            Options options1 = new Options(activeAccount, atm);
            options1.Show();
        }

        private void DataRaceSoln_Click(object sender, EventArgs e)
        {

        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataRaceProb_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            activeAccount = atm.findAccount(111111);
            Options options1 = new Options(activeAccount, atm);
            options1.Show();
        }

        private void DataRaceSoln_Click(object sender, EventArgs e)
        {

        }
    }
}