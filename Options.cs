﻿using System;
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

        }

        private void CheckBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
