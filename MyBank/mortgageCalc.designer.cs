namespace mortgageCalc
{
    partial class Form1
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
            this.loanBox1 = new System.Windows.Forms.TextBox();
            this.interestBox2 = new System.Windows.Forms.TextBox();
            this.yearsBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalLoans = new System.Windows.Forms.Label();
            this.loanDisplay = new System.Windows.Forms.Label();
            this.totalPayments = new System.Windows.Forms.Label();
            this.paymentDisplay = new System.Windows.Forms.Label();
            this.avgMonPayDisplay = new System.Windows.Forms.Label();
            this.avgMonPay = new System.Windows.Forms.Label();
            this.amountOfLoan = new System.Windows.Forms.Label();
            this.interest = new System.Windows.Forms.Label();
            this.years = new System.Windows.Forms.Label();
            this.monthlyPayment = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loanBox1
            // 
            this.loanBox1.Location = new System.Drawing.Point(395, 30);
            this.loanBox1.Name = "loanBox1";
            this.loanBox1.Size = new System.Drawing.Size(236, 22);
            this.loanBox1.TabIndex = 0;
            // 
            // interestBox2
            // 
            this.interestBox2.Location = new System.Drawing.Point(395, 74);
            this.interestBox2.Name = "interestBox2";
            this.interestBox2.Size = new System.Drawing.Size(236, 22);
            this.interestBox2.TabIndex = 1;
            // 
            // yearsBox3
            // 
            this.yearsBox3.Location = new System.Drawing.Point(395, 117);
            this.yearsBox3.Name = "yearsBox3";
            this.yearsBox3.Size = new System.Drawing.Size(236, 22);
            this.yearsBox3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalLoans);
            this.groupBox1.Controls.Add(this.loanDisplay);
            this.groupBox1.Controls.Add(this.totalPayments);
            this.groupBox1.Controls.Add(this.paymentDisplay);
            this.groupBox1.Controls.Add(this.avgMonPayDisplay);
            this.groupBox1.Controls.Add(this.avgMonPay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 243);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // totalLoans
            // 
            this.totalLoans.AutoSize = true;
            this.totalLoans.Location = new System.Drawing.Point(197, 20);
            this.totalLoans.Name = "totalLoans";
            this.totalLoans.Size = new System.Drawing.Size(140, 18);
            this.totalLoans.TabIndex = 9;
            this.totalLoans.Text = "Total of All Loans";
            // 
            // loanDisplay
            // 
            this.loanDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loanDisplay.Location = new System.Drawing.Point(363, 20);
            this.loanDisplay.Name = "loanDisplay";
            this.loanDisplay.Size = new System.Drawing.Size(212, 47);
            this.loanDisplay.TabIndex = 10;
            this.loanDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPayments
            // 
            this.totalPayments.AutoSize = true;
            this.totalPayments.Location = new System.Drawing.Point(153, 92);
            this.totalPayments.Name = "totalPayments";
            this.totalPayments.Size = new System.Drawing.Size(189, 18);
            this.totalPayments.TabIndex = 11;
            this.totalPayments.Text = "Total Monthly Payments";
            // 
            // paymentDisplay
            // 
            this.paymentDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paymentDisplay.Location = new System.Drawing.Point(363, 80);
            this.paymentDisplay.Name = "paymentDisplay";
            this.paymentDisplay.Size = new System.Drawing.Size(212, 50);
            this.paymentDisplay.TabIndex = 12;
            this.paymentDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgMonPayDisplay
            // 
            this.avgMonPayDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avgMonPayDisplay.Location = new System.Drawing.Point(363, 145);
            this.avgMonPayDisplay.Name = "avgMonPayDisplay";
            this.avgMonPayDisplay.Size = new System.Drawing.Size(212, 48);
            this.avgMonPayDisplay.TabIndex = 14;
            this.avgMonPayDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgMonPay
            // 
            this.avgMonPay.AutoSize = true;
            this.avgMonPay.Location = new System.Drawing.Point(130, 162);
            this.avgMonPay.Name = "avgMonPay";
            this.avgMonPay.Size = new System.Drawing.Size(202, 18);
            this.avgMonPay.TabIndex = 13;
            this.avgMonPay.Text = "Average Monthly Payment";
            // 
            // amountOfLoan
            // 
            this.amountOfLoan.AutoSize = true;
            this.amountOfLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOfLoan.Location = new System.Drawing.Point(234, 34);
            this.amountOfLoan.Name = "amountOfLoan";
            this.amountOfLoan.Size = new System.Drawing.Size(127, 18);
            this.amountOfLoan.TabIndex = 4;
            this.amountOfLoan.Text = "Amount of Loan\r\n";
            // 
            // interest
            // 
            this.interest.AutoSize = true;
            this.interest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interest.Location = new System.Drawing.Point(182, 74);
            this.interest.Name = "interest";
            this.interest.Size = new System.Drawing.Size(179, 18);
            this.interest.TabIndex = 5;
            this.interest.Text = "Annual Rate of Interest";
            // 
            // years
            // 
            this.years.AutoSize = true;
            this.years.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.years.Location = new System.Drawing.Point(226, 117);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(135, 18);
            this.years.TabIndex = 6;
            this.years.Text = "Number of Years";
            // 
            // monthlyPayment
            // 
            this.monthlyPayment.AutoSize = true;
            this.monthlyPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyPayment.Location = new System.Drawing.Point(224, 149);
            this.monthlyPayment.Name = "monthlyPayment";
            this.monthlyPayment.Size = new System.Drawing.Size(137, 18);
            this.monthlyPayment.TabIndex = 7;
            this.monthlyPayment.Text = "Monthly Payment";
            // 
            // payment
            // 
            this.payment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.payment.Location = new System.Drawing.Point(392, 149);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(239, 82);
            this.payment.TabIndex = 8;
            this.payment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(401, 597);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 18);
            this.label12.TabIndex = 15;
            this.label12.Text = "Programmed by: Jovon Sales";
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(69, 505);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(110, 63);
            this.calcButton.TabIndex = 16;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(286, 506);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 63);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(522, 506);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 62);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(69, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "ATM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(170, 574);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 55);
            this.button2.TabIndex = 20;
            this.button2.Text = "Loan Qualifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(274, 575);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 54);
            this.button3.TabIndex = 21;
            this.button3.Text = "Administrator";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 661);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.monthlyPayment);
            this.Controls.Add(this.years);
            this.Controls.Add(this.interest);
            this.Controls.Add(this.amountOfLoan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.yearsBox3);
            this.Controls.Add(this.interestBox2);
            this.Controls.Add(this.loanBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MortgageCal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loanBox1;
        private System.Windows.Forms.TextBox interestBox2;
        private System.Windows.Forms.TextBox yearsBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalLoans;
        private System.Windows.Forms.Label loanDisplay;
        private System.Windows.Forms.Label totalPayments;
        private System.Windows.Forms.Label paymentDisplay;
        private System.Windows.Forms.Label avgMonPayDisplay;
        private System.Windows.Forms.Label avgMonPay;
        private System.Windows.Forms.Label amountOfLoan;
        private System.Windows.Forms.Label interest;
        private System.Windows.Forms.Label years;
        private System.Windows.Forms.Label monthlyPayment;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

