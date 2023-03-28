namespace ATM
{
    partial class ATMForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            InputDetails = new TextBox();
            Continue = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            DataRaceProb = new Button();
            DataRaceSoln = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(188, 156);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(445, 43);
            label1.TabIndex = 0;
            label1.Text = "Please enter account number";
            label1.Click += label1_Click;
            // 
            // InputDetails
            // 
            InputDetails.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            InputDetails.Location = new Point(304, 235);
            InputDetails.Margin = new Padding(2);
            InputDetails.MaxLength = 6;
            InputDetails.Name = "InputDetails";
            InputDetails.Size = new Size(125, 43);
            InputDetails.TabIndex = 1;
            InputDetails.TextChanged += InputDetails_TextChanged;
            // 
            // Continue
            // 
            Continue.Location = new Point(337, 320);
            Continue.Margin = new Padding(2);
            Continue.Name = "Continue";
            Continue.Size = new Size(92, 29);
            Continue.TabIndex = 2;
            Continue.Text = "Continue";
            Continue.UseVisualStyleBackColor = false;
            Continue.Click += Continue_Click;
            // 
            // DataRaceProb
            // 
            DataRaceProb.Location = new Point(208, 374);
            DataRaceProb.Name = "DataRaceProb";
            DataRaceProb.Size = new Size(152, 56);
            DataRaceProb.TabIndex = 8;
            DataRaceProb.Text = "Implement Data-Race Problem";
            DataRaceProb.UseVisualStyleBackColor = true;
            DataRaceProb.Click += DataRaceProb_Click;
            // 
            // DataRaceSoln
            // 
            DataRaceSoln.Location = new Point(394, 374);
            DataRaceSoln.Name = "DataRaceSoln";
            DataRaceSoln.Size = new Size(152, 56);
            DataRaceSoln.TabIndex = 7;
            DataRaceSoln.Text = "Implement Data-Race Solution";
            DataRaceSoln.UseVisualStyleBackColor = true;
            DataRaceSoln.Click += DataRaceSoln_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 43);
            textBox1.TabIndex = 9;
            textBox1.Text = "ATM";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.GradientActiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.InfoText;
            textBox2.Location = new Point(212, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(385, 69);
            textBox2.TabIndex = 10;
            textBox2.Text = "Bank Of Dundee";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // 
            // 
            // DataRaceProb
            // 
            DataRaceProb.Location = new Point(245, 364);
            DataRaceProb.Name = "DataRaceProb";
            DataRaceProb.Size = new Size(104, 52);
            DataRaceProb.TabIndex = 11;
            DataRaceProb.Text = "Implement Data Race";
            DataRaceProb.UseVisualStyleBackColor = true;
            DataRaceProb.Click += DataRaceProb_Click;
            // 
            // DataRaceSoln
            // 
            DataRaceSoln.Location = new Point(444, 364);
            DataRaceSoln.Name = "DataRaceSoln";
            DataRaceSoln.Size = new Size(119, 54);
            DataRaceSoln.TabIndex = 12;
            DataRaceSoln.Text = "Implement Non Data Race";
            DataRaceSoln.UseVisualStyleBackColor = true;
            DataRaceSoln.Click += DataRaceSoln_Click;
            // 
            // ATMForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(782, 443);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Continue);
            Controls.Add(InputDetails);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "ATMForm";
            Text = "ATM Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox InputDetails;
        private Button Continue;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button DataRaceProb;
        private Button DataRaceSoln;
     
    }
}