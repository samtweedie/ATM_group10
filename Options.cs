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
        public Options()
        {
            InitializeComponent();
        }

        private void WithdrawCash_Click(object sender, EventArgs e)
        {
            WithdrawCash.Name = "Ten";
            WithdrawCash.Text = "10";
            CheckBalance.Name = "Fifty";
            CheckBalance.Text = "50";
            ExitButton.Name = "FiveHundred";
            ExitButton.Text = "500";
            Prompt.Text = "Please pick the amount that you wish to withdraw";

        }

        private void CheckBalance_Click(object sender, EventArgs e)
        {

        }

        private void Options_Load(object sender, EventArgs e)
        {

        }
    }
}
