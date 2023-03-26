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
            ExitButton = new Button();
            Prompt = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            WithdrawCash.Click += WithdrawCash_Click;
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
            // ExitButton
            // 
            ExitButton.Location = new Point(769, 211);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(102, 44);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Prompt
            // 
            Prompt.AutoSize = true;
            Prompt.Location = new Point(375, 138);
            Prompt.Name = "Prompt";
            Prompt.Size = new Size(289, 20);
            Prompt.TabIndex = 3;
            Prompt.Text = "Please select one of the following options.";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveBorder;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Elephant", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(-1, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 48);
            textBox1.TabIndex = 10;
            textBox1.Text = "ATM";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveBorder;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Elephant", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.InfoText;
            textBox2.Location = new Point(300, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(425, 61);
            textBox2.TabIndex = 11;
            textBox2.Text = "Bank Of Dundee";
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1009, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Prompt);
            Controls.Add(ExitButton);
            Controls.Add(CheckBalance);
            Controls.Add(WithdrawCash);
            Name = "Options";
            Text = "Options";
            Load += Options_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button WithdrawCash;
        private Button CheckBalance;
        private Button ExitButton;
        private Label Prompt;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}