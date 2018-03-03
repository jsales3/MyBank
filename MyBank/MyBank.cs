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

namespace MyBank
{
   
    public partial class MyBank : Form
    {
        

        public MyBank()
        {
            InitializeComponent();
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
            mortgageCalc.Form1 myMortgage = new mortgageCalc.Form1();

            myMortgage.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            administrator.Administrator myAdmin = new administrator.Administrator();

            myAdmin.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyBank_Load(object sender, EventArgs e)
        {

        }
    }
}


