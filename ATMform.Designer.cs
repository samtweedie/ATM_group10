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
            DataRaceProb = new Button();
            DataRaceSoln = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(359, 37);
            label1.TabIndex = 0;
            label1.Text = "Please enter account number";
            // 
            // InputDetails
            // 
            InputDetails.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            InputDetails.Location = new Point(185, 129);
            InputDetails.Margin = new Padding(2);
            InputDetails.MaxLength = 6;
            InputDetails.Name = "InputDetails";
            InputDetails.Size = new Size(125, 43);
            InputDetails.TabIndex = 1;
            // 
            // Continue
            // 
            Continue.Location = new Point(393, 245);
            Continue.Margin = new Padding(2);
            Continue.Name = "Continue";
            Continue.Size = new Size(92, 29);
            Continue.TabIndex = 2;
            Continue.Text = "Continue";
            Continue.UseVisualStyleBackColor = true;
            Continue.Click += Continue_Click;
            // 
            // DataRaceProb
            // 
            DataRaceProb.Location = new Point(22, 218);
            DataRaceProb.Name = "DataRaceProb";
            DataRaceProb.Size = new Size(152, 56);
            DataRaceProb.TabIndex = 8;
            DataRaceProb.Text = "Implement Data-Race Problem";
            DataRaceProb.UseVisualStyleBackColor = true;
            DataRaceProb.Click += DataRaceProb_Click;
            // 
            // DataRaceSoln
            // 
            DataRaceSoln.Location = new Point(208, 218);
            DataRaceSoln.Name = "DataRaceSoln";
            DataRaceSoln.Size = new Size(152, 56);
            DataRaceSoln.TabIndex = 7;
            DataRaceSoln.Text = "Implement Data-Race Solution";
            DataRaceSoln.UseVisualStyleBackColor = true;
            DataRaceSoln.Click += DataRaceSoln_Click;
            // 
            // ATMForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 281);
            Controls.Add(DataRaceProb);
            Controls.Add(DataRaceSoln);
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
        private Button DataRaceProb;
        private Button DataRaceSoln;
    }
}