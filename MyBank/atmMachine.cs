using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace atmMachine
{

    public partial class atmMachine : Form
    {
        private double currentSavings = 0;   //declares counter variable for savings account
        private double currentCheckings = 0; //declares counter variable for checkings



        public atmMachine()
        {
            InitializeComponent();


        }

        //Deposit Button event handler
        //Gets user input and deposit amount into savings or checkings.
        private void depositButton1_Click(object sender, EventArgs e)
        {

            try
            {

                double amount; //declare user deposit variable

                amount = double.Parse(amountBox1.Text); //assign user input to variable

                if (amount > 0)
                {

                    if (radioButton1.Checked)
                    {
                        currentSavings += amount;
                        DisplayBalances(currentSavings, currentCheckings);
                    }
                    if (radioButton2.Checked)
                    {
                        currentCheckings += amount;
                        DisplayBalances(currentSavings, currentCheckings);
                    }


                    if (radioButton1.Checked == false && radioButton2.Checked == false)
                        MessageBox.Show("Select an Account");
                }
                else
                {
                    MessageBox.Show("Enter a positive Number");
                    amountBox1.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //Withdraw event handler method
        //Gets user withdraw amount & withdraw from Savings or Checkings account
        private void withdrawButton2_Click(object sender, EventArgs e)
        {
            try
            {

                double amount;

                amount = double.Parse(amountBox1.Text);

                if (amount > 0)
                {
                    if (radioButton1.Checked)
                    {
                        if (amount <= currentSavings)
                        {
                            currentSavings = currentSavings - amount;
                            DisplayBalances(currentSavings, currentCheckings);
                        }
                        else
                        {
                            MessageBox.Show("You have insufficient funds in your Savings Account");
                            amountBox1.Clear();
                        }
                    }
                    if (radioButton2.Checked)
                    {
                        if (amount <= currentCheckings)
                        {
                            currentCheckings = currentCheckings - amount;
                            DisplayBalances(currentSavings, currentCheckings);
                        }
                        else
                        {
                            MessageBox.Show("You have insufficient funds in your Checkings Account");
                            amountBox1.Clear();
                        }
                    }

                    if (radioButton1.Checked == false && radioButton2.Checked == false)
                        MessageBox.Show("Select an Account");
                }
                else
                {
                    MessageBox.Show("Enter a positive Number");
                    amountBox1.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Display Balances method
        //That displays current savings & checkings amount.
        private void DisplayBalances(double save, double check)
        {

            savingsLabel2.Text = save.ToString("C");
            checkingLabel2.Text = check.ToString("C");
        }

        //Clear Button event handler method
        //That clears amount textBox, and reset focus to amount textBox
        private void clearButton3_Click(object sender, EventArgs e)
        {
            amountBox1.Text = "";

            amountBox1.Focus();
        }

        //Exit Button event handler method
        //That exits the program
        private void exitButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoanQualifier.LoanQualifier myLoan = new LoanQualifier.LoanQualifier();

            myLoan.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mortgageCalc.Form1 myMortgage = new mortgageCalc.Form1();

            myMortgage.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            administrator.Administrator myAdmin = new administrator.Administrator();

            myAdmin.ShowDialog();
        }
    }
}
