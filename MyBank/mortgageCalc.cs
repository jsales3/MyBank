using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace mortgageCalc
{
    public partial class Form1 : Form
    {
        private double counter = 0.0;
        private double totalMonPay = 0.0;
        private double avgMnPay = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                double loan;
                double interest;
                double years;
                double monthlyPayment;
               
               
               
                if (double.TryParse(loanBox1.Text, out loan))
                {
                    counter += loan;
                }

                else
                {
                    //Incorrect Loan
                    MessageBox.Show("The Loan input is incorrect");
                }

                if (double.TryParse(interestBox2.Text, out interest))
                {
                    interest = interest / 100;
                    interest = interest / 12;
                    
                }

                else
                {
                    //Incorrect Interest
                    MessageBox.Show("The Interest Rate Value is Incorrect");
                }

                if (double.TryParse(yearsBox3.Text, out years))
                {
                     years = years*12;
                }

                else
                {
                    //Incorrect Years
                    MessageBox.Show("Number of Years are incorrect");
                }

               
                monthlyPayment = loan * (interest * (Math.Pow(1 + interest, years))) / (Math.Pow(1 + interest, years)) - 1;
                payment.Text = "" + monthlyPayment;


                totalMonPay += monthlyPayment;
                paymentDisplay.Text = "" + totalMonPay;

               
                loanDisplay.Text = "" + counter;

                avgMnPay = totalMonPay/counter;
                avgMonPayDisplay.Text = "" + avgMnPay;
            }

            catch(Exception ex)
            {

                //Display Error Message
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears all texts
            loanBox1.Text = "";
            interestBox2.Text = "";
            yearsBox3.Text = "";
            payment.Text = "";
           

            //Resets Focus
            loanBox1.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exits Program
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atmMachine.atmMachine myATM = new atmMachine.atmMachine();

            myATM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoanQualifier.LoanQualifier myLoan = new LoanQualifier.LoanQualifier();

            myLoan.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            administrator.Administrator myAdmin = new administrator.Administrator();

            myAdmin.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    
}
