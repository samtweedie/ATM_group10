using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Options : Form
    {
        Account activeAccount;
        ATM atm;
        int next = 0;
        public Options(Account activeAccount, ATM atm)
        {
            InitializeComponent();
            this.activeAccount = activeAccount;
            this.atm = atm;
        }

        private void WithdrawCash_Click(object sender, EventArgs e)
        {
            if (next == 1)
            {
                if (activeAccount.decrementBalance(10))
                {
                    //if this is possible display new balance and await key press
                    Prompt.Text = "new balance " + activeAccount.getBalance();
                    //Console.WriteLine(" (prese enter to continue)");
                    //Console.ReadLine();
                }
                else
                {
                    //if this is not possible inform user and await key press
                    Prompt.Text = "insufficent funds";
                    //Console.WriteLine(" (prese enter to continue)");
                    //Console.ReadLine();
                }
            }
            else
            {
                WithdrawCash.Name = "Ten";
                WithdrawCash.Text = "10";
                CheckBalance.Name = "Fifty";
                CheckBalance.Text = "50";
                ExitButton.Name = "FiveHundred";
                ExitButton.Text = "500";
                Prompt.Text = "Please pick the amount that you wish to withdraw";
                next = 1;
            }

        }

        private void CheckBalance_Click(object sender, EventArgs e)
            {
                if (next == 1)
                {
                    if (activeAccount.decrementBalance(50))
                    {
                        //if this is possible display new balance and await key press
                        Prompt.Text = "new balance " + activeAccount.getBalance();
                        //Console.WriteLine(" (prese enter to continue)");
                        //Console.ReadLine();
                    }
                    else
                    {
                        //if this is not possible inform user and await key press
                        Prompt.Text = "insufficent funds";
                        //Console.WriteLine(" (prese enter to continue)");
                        //Console.ReadLine();
                    }
                }
                else
                {
                    //if (thisAccountActive != null)
                    WithdrawCash.Visible = false;
                    CheckBalance.Visible = false;
                    ExitButton.Visible = false;
                    Prompt.Text = "Your current balance is: " + activeAccount.getBalance();
                    /*Console.WriteLine("Press enter to go back to previous menu");
                    e.KeyChar = Console.ReadLine();

                    this.textBox1.KeyPress += new
                    System.Windows.Forms.KeyPressEventHandler(CheckEnter);*/
                }
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (next == 1)
            {
                if (activeAccount.decrementBalance(500))
                {
                    //if this is possible display new balance and await key press
                    Prompt.Text = "new balance " + activeAccount.getBalance();
                    //Console.WriteLine(" (prese enter to continue)");
                    //Console.ReadLine();
                }
                else
                {
                    //if this is not possible inform user and await key press
                    Prompt.Text = "insufficent funds";
                    //Console.WriteLine(" (prese enter to continue)");
                    //Console.ReadLine();
                }
            }
            else
            {
                Prompt.Text = "Thank you for using this ATM , Bye";
                this.Close();
            }
        }
    }
}
