namespace ATM
{
    public partial class ATMForm : Form
    {
        private Account[] ac = new Account[3];
        private ATM atm;
        private bool accountCorrect = false;
        private Account activeAccount = null;
        private int next = 0;
        public ATMForm()
        {


            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);

            atm = new ATM(ac);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Continue_Click(object sender, EventArgs e)
        {
            if (next == 1)
            {
                this.Visible = false;
                Options options = new Options();  
                options.Show();
            }
            if (!accountCorrect) //account screen
            {
                if (InputDetails.Text.Length < 6)
                {
                    MessageBox.Show("You have entered less than 6 digits. Your account number must be 6 digits. Please try again", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    activeAccount = atm.findAccount(Convert.ToInt32(InputDetails.Text));
                    if (activeAccount == null)
                    {
                        MessageBox.Show("The account number you entered could not be found. Please try again", "Error", MessageBoxButtons.OK);
                    }
                    else //changes form to ask for pin
                    {
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
                    MessageBox.Show("You have entered less than 4 digits. Your pin must be 4 digits. Please try again", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    if (activeAccount.checkPin(Convert.ToInt32(InputDetails.Text)))
                    {
                        next = 1;
                    }
                }
            }
        }
    }
}