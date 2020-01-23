namespace ParkingCardHelper
{
    partial class frmParkingHelper
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCreditAdded = new System.Windows.Forms.TextBox();
            this.txtNoCard = new System.Windows.Forms.TextBox();
            this.txtWithCard = new System.Windows.Forms.TextBox();
            this.txtNumOfDays = new System.Windows.Forms.TextBox();
            this.txtRemainingCredit = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSavings = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit added to campus card";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parking cost without campus card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parking cost with campus card";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of days of parking";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Credit remaining";
            // 
            // txtCreditAdded
            // 
            this.txtCreditAdded.Location = new System.Drawing.Point(196, 12);
            this.txtCreditAdded.Name = "txtCreditAdded";
            this.txtCreditAdded.Size = new System.Drawing.Size(100, 20);
            this.txtCreditAdded.TabIndex = 5;
            // 
            // txtNoCard
            // 
            this.txtNoCard.Location = new System.Drawing.Point(196, 47);
            this.txtNoCard.Name = "txtNoCard";
            this.txtNoCard.ReadOnly = true;
            this.txtNoCard.Size = new System.Drawing.Size(100, 20);
            this.txtNoCard.TabIndex = 6;
            this.txtNoCard.TabStop = false;
            this.txtNoCard.Text = "$5.00";
            // 
            // txtWithCard
            // 
            this.txtWithCard.Location = new System.Drawing.Point(196, 83);
            this.txtWithCard.Name = "txtWithCard";
            this.txtWithCard.ReadOnly = true;
            this.txtWithCard.Size = new System.Drawing.Size(100, 20);
            this.txtWithCard.TabIndex = 7;
            this.txtWithCard.TabStop = false;
            this.txtWithCard.Text = "$2.50";
            // 
            // txtNumOfDays
            // 
            this.txtNumOfDays.Location = new System.Drawing.Point(196, 156);
            this.txtNumOfDays.Name = "txtNumOfDays";
            this.txtNumOfDays.ReadOnly = true;
            this.txtNumOfDays.Size = new System.Drawing.Size(100, 20);
            this.txtNumOfDays.TabIndex = 8;
            this.txtNumOfDays.TabStop = false;
            // 
            // txtRemainingCredit
            // 
            this.txtRemainingCredit.Location = new System.Drawing.Point(196, 191);
            this.txtRemainingCredit.Name = "txtRemainingCredit";
            this.txtRemainingCredit.ReadOnly = true;
            this.txtRemainingCredit.Size = new System.Drawing.Size(100, 20);
            this.txtRemainingCredit.TabIndex = 9;
            this.txtRemainingCredit.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(209, 118);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(209, 262);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Savings with campus card";
            // 
            // txtSavings
            // 
            this.txtSavings.Location = new System.Drawing.Point(196, 227);
            this.txtSavings.Name = "txtSavings";
            this.txtSavings.ReadOnly = true;
            this.txtSavings.Size = new System.Drawing.Size(100, 20);
            this.txtSavings.TabIndex = 13;
            this.txtSavings.TabStop = false;
            // 
            // frmParkingHelper
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(314, 297);
            this.Controls.Add(this.txtSavings);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRemainingCredit);
            this.Controls.Add(this.txtNumOfDays);
            this.Controls.Add(this.txtWithCard);
            this.Controls.Add(this.txtNoCard);
            this.Controls.Add(this.txtCreditAdded);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmParkingHelper";
            this.Text = "Parking Card Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCreditAdded;
        private System.Windows.Forms.TextBox txtNoCard;
        private System.Windows.Forms.TextBox txtWithCard;
        private System.Windows.Forms.TextBox txtNumOfDays;
        private System.Windows.Forms.TextBox txtRemainingCredit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSavings;
    }
}

