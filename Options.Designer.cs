namespace ATM
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WithdrawCash = new Button();
            CheckBalance = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // WithdrawCash
            // 
            WithdrawCash.Location = new Point(129, 214);
            WithdrawCash.Name = "WithdrawCash";
            WithdrawCash.Size = new Size(121, 41);
            WithdrawCash.TabIndex = 0;
            WithdrawCash.Text = "Withdraw Cash";
            WithdrawCash.UseVisualStyleBackColor = true;
            WithdrawCash.Click += button1_Click;
            // 
            // CheckBalance
            // 
            CheckBalance.Location = new Point(453, 211);
            CheckBalance.Name = "CheckBalance";
            CheckBalance.Size = new Size(117, 44);
            CheckBalance.TabIndex = 1;
            CheckBalance.Text = "Check Balance";
            CheckBalance.UseVisualStyleBackColor = true;
            CheckBalance.Click += CheckBalance_Click;
            // 
            // button3
            // 
            button3.Location = new Point(769, 211);
            button3.Name = "button3";
            button3.Size = new Size(102, 44);
            button3.TabIndex = 2;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 96);
            label1.Name = "label1";
            label1.Size = new Size(289, 20);
            label1.TabIndex = 3;
            label1.Text = "Please select one of the following options.";
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 450);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(CheckBalance);
            Controls.Add(WithdrawCash);
            Name = "Options";
            Text = "Options";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button WithdrawCash;
        private Button CheckBalance;
        private Button button3;
        private Label label1;
    }
}