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
                next = 2;
                CheckBalance.Hide();
                WithdrawCash.Hide();
                ExitButton.Text = "Exit";
                if (activeAccount.decrementBalance(10))
                {
                    //if this is possible display new balance and await key press
                    Prompt.Text = "New balance: £" + activeAccount.getBalance() + ". Please press exit to start again";
                }
                else
                {
                    //if this is not possible inform user and await key press
                    Prompt.Text = "Insufficent funds. Please press exit to start again";
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
                CheckBalance.Visible = false;
                WithdrawCash.Visible = false;
                if (next == 1)
                {
                    next = 2;
                    ExitButton.Text = "Exit";
                    if (activeAccount.decrementBalance(50))
                    {
                    //if this is possible display new balance and await key press
                    Prompt.Text = "New balance: £" + activeAccount.getBalance() + ". Please press exit to start again";
                    }
                    else
                    {
                        //if this is not possible inform user and await key press
                        Prompt.Text = "Insufficent funds. Please press exit to start again";
                    }
                }
                else
                {
                    //if (thisAccountActive != null)
                    Prompt.Text = "Your current balance is: £" + activeAccount.getBalance() + ". Please press exit to start again";
            }
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (next == 1)
            {
                next = 2;
                CheckBalance.Hide();
                WithdrawCash.Hide();
                ExitButton.Text = "Exit";
                if (activeAccount.decrementBalance(500))
                {
                    //if this is possible display new balance and await key press
                    Prompt.Text = "New balance: £" + activeAccount.getBalance() + ". Please press exit to start again";
                }
                else
                {
                    //if this is not possible inform user and await key press
                    Prompt.Text = "Insufficent funds. Please press exit to start again";
                }
            }
            else
            {
                this.Visible = false;
                ATMForm form = new ATMForm();
                form.Show();
                InitializeComponent();
            }
        }
    }
}
