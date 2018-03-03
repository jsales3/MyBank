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

namespace administrator
{
    struct customers
    {
        public string customerID;
        public string firstName;
        public string lastName;
        public string accountID;
    }

    struct accounts
    {
        public string accountID;
        public string accountNum;
        public string accountType;
        public string amount;
    }

    struct loans
    {
        public string customerID;
        public string loanID;
        public string loanType;
        public string amount;
        public string years;
        public string interest;
    }
    public partial class DBBackup_Restore : Form
    {
        List<customers> customerList =
           new List<customers>();

        private List<accounts> accountList =
            new List<accounts>();

        private List<loans> loanList =
            new List<loans>();

        public DBBackup_Restore()
        {
            InitializeComponent();
        }

        private void ReadFile()
        {
            try
            {
                StreamReader customerFile, accountFile, loanFile;
                string line;

                customers entry = new customers();
                accounts entry1 = new accounts();
                loans entry2 = new loans();

                char[] delim = { ',' };

                customerFile = File.OpenText("customers.txt");
                accountFile = File.OpenText("accounts.txt");
                loanFile = File.OpenText("loans.txt");

                while (!customerFile.EndOfStream)
                {
                    line = customerFile.ReadLine();

                    string[] tokens = line.Split(delim);

                    entry.customerID = tokens[0];
                    entry.firstName = tokens[1];
                    entry.lastName = tokens[2];
                    entry.accountID = tokens[3];

                    customerList.Add(entry);
                }

                while (!accountFile.EndOfStream)
                {
                    line = accountFile.ReadLine();

                    string[] tokens = line.Split(delim);

                    entry1.accountID = tokens[0];
                    entry1.accountNum = tokens[1];
                    entry1.accountType = tokens[2];
                    entry1.amount = tokens[3];

                    accountList.Add(entry1);
                }

                while (!loanFile.EndOfStream)
                {
                    line = loanFile.ReadLine();

                    string[] tokens = line.Split(delim);

                    entry2.customerID = tokens[0];
                    entry2.loanID = tokens[1];
                    entry2.loanType = tokens[2];
                    entry2.amount = tokens[3];
                    entry2.years = tokens[4];
                    entry2.interest = tokens[5];

                    loanList.Add(entry2);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void writeFile(string fileName, string fileName2, string fileName3)
        {
            try
            {
                StreamWriter outputFile, outputFile2, outputFile3;

                outputFile = File.CreateText(fileName);
                outputFile2 = File.CreateText(fileName2);
                outputFile3 = File.CreateText(fileName3);

                foreach (customers customer in customerList)
                {
                    outputFile.WriteLine(customer.customerID + " " + customer.firstName + " " +
                        customer.lastName + " " + customer.accountID);

                  
                }

                outputFile.Close();

                foreach(accounts account in accountList)
                {
                    outputFile2.WriteLine(account.accountID + " " + account.accountNum + " " +
                        account.accountType + " " + account.amount);

                }

                outputFile2.Close();

                foreach(loans loan in loanList)
                {
                    outputFile3.WriteLine(loan.customerID + " " + loan.loanID + " " + loan.loanType
                        + "" + loan.amount + " " + loan.years + " " + loan.interest);
                }
                outputFile3.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseBackup myBackup = new DatabaseBackup();
            myBackup.ShowDialog();

            string custFile = myBackup.textBox1.Text;
            string acctFile = myBackup.textBox2.Text;
            string loanFile = myBackup.textBox3.Text;

            writeFile(custFile, acctFile, loanFile);
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseRestore myRestore = new DatabaseRestore();
            myRestore.ShowDialog();

            ReadFile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            atmMachine.atmMachine myATM = new atmMachine.atmMachine();

            myATM.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoanQualifier.LoanQualifier myLoan = new LoanQualifier.LoanQualifier();

            myLoan.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mortgageCalc.Form1 myMortgage = new mortgageCalc.Form1();

            myMortgage.ShowDialog();
        }
    }
}
