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

namespace LoanQualifier
{
    public partial class LoanQualifier : Form
    {
        public LoanQualifier()
        {
            InitializeComponent();

            List<string> stateList = new List<string>();

            readStates(stateList);
            displayStates(stateList);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private bool validLast(string str)
        {
            const int length = 20;

            bool valid = true;

            if(str.Length < length)
            {
                foreach(char ch in str)
                {
                    if (!char.IsLetter(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        private bool validFirst(string str)
        {
            const int length = 30;

            bool valid = true;

            if (str.Length < length)
            {
                foreach (char ch in str)
                {
                    if (!char.IsLetter(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        private bool validMiddle(string str)
        {
            const int length = 1;

            bool valid = true;

            if (str.Length == length)
            {
                foreach (char ch in str)
                {
                    if (!char.IsLetter(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        private bool validage(string str)
        {
            const int length = 100;

            bool valid = true;

            if (str.Length <= length)
            {
                foreach (char ch in str)
                {
                    if (!char.IsDigit(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        private bool validSSN(String str)
        {
            const int length = 9;

            bool valid = true;

            if(str.Length == length)
            {
                foreach(char ch in str)
                {
                    if (!char.IsDigit(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        private void SSN_Format(ref string str)
        {
            str = str.Insert(3, "-");

            str = str.Insert(6, "-");

        }

        private bool validNumber(string str)
        {
            const int length = 20;

            bool valid = true;

            if(str.Length < length)
            {
                foreach(char ch in str)
                {
                    if (!char.IsDigit(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        private bool validStreet(string str)
        {
            const int length = 20;

            bool valid = true;

            if (str.Length < length)
            {
                foreach (char ch in str)
                {
                    if (!char.IsLetter(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        private bool validCity(string str)
        {
            const int length = 20;

            bool valid = true;

            if (str.Length < length)
            {
                foreach (char ch in str)
                {
                    if (!char.IsLetter(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        private void readStates(List<string> stateList)
        {
            try
            {
                StreamReader inputFile = File.OpenText("States.txt");

                while (!inputFile.EndOfStream)
                {
                    stateList.Add(inputFile.ReadLine());
                }

                inputFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayStates(List<string> stateList)
        {
            foreach(string state in stateList)
            {
                listBox1.Items.Add(state);
            }
        }

        private bool validEmployer(string str)
        {
            const int length = 40;

            bool valid = true;

            if (str.Length < length)
            {
                foreach (char ch in str)
                {
                    if (!char.IsLetter(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string lastName = lastNametextBox1.Text.Trim();
                string firstName = firstNametextBox.Text.Trim();
                string middleInitial = MItextBox.Text.Trim();
                string SSN = SSNtextBox.Text.Trim();
                string age = agecomboBox1.Text.Trim();
                string Number = NumbertextBox.Text.Trim();
                string street = streettextBox.Text.Trim();
                string city = CitytextBox.Text.Trim();
                string employer = employertextBox.Text.Trim();
               


                if (!validLast(lastName))
                {
                    MessageBox.Show("Invalid input for Last Name");
                    lastNametextBox1.Clear();
                }

                if (!validFirst(firstName))
                {
                    MessageBox.Show("Invalid input for First Name");
                    firstNametextBox.Clear();
                }


                if (!validMiddle(middleInitial))
                {
                    MessageBox.Show("Invalid input for MI");
                    MItextBox.Clear();
                }

                if (!validage(age))
                {
                    MessageBox.Show("Please enter a valid age");
                }
            

                if (validSSN(SSN))
                {
                    SSN_Format(ref SSN);
                    SSNtextBox.Text = SSN;
                }
                else
                {
                    MessageBox.Show("Invalid SSN Entry");
                    SSNtextBox.Clear();
                }

                if (!MarriedradioButton.Checked && !DivorcedradioButton.Checked && !UnmarriedradioButton.Checked)
                {
                    MessageBox.Show("Please Select an Marital Status");
                }
                
                if(!MaleRadioButton.Checked && !FemaleradioButton.Checked)
                {
                    MessageBox.Show("Please select a Gender");
                }

                if (!validNumber(Number))
                {
                    MessageBox.Show("Address Number Entry Incorrect");
                    NumbertextBox.Clear();
                }

                if (!validStreet(street))
                {
                    MessageBox.Show("Street Entry Incorrect");
                    streettextBox.Clear();
                }

                if (!validCity(city))
                {
                    MessageBox.Show("City Entry Incorrect");
                    CitytextBox.Clear();
                }

                

                if (!validEmployer(employer))
                {
                    MessageBox.Show("Employer Entry Incorrect");
                    employertextBox.Clear();
                }

                if(!checkBox1.Checked && !checkBox2.Checked && 
                    !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked && !checkBox6.Checked)
                {
                    MessageBox.Show("Please Select a Job Position"); 
                }

                if(!CarradioButton.Checked && !HouseradioButton.Checked 
                    && !SchoolradioButton.Checked && !OtherradioButton.Checked)
                {
                    MessageBox.Show("Please Select your Loan Type");
                }
            }
            catch
            {
                MessageBox.Show("One or More Entries were Invalid");
            }

            try
            {
                //Names constants
                const decimal MINIMUM_SALARY = 40000M;
                const int MINIMUM_YEARS_ON_JOB = 2;
              
                //Local Variables
                decimal salary;
                int yearsOnJob;

                //Get the salary and years on the job.
                salary = decimal.Parse(AnnualSalary.Text);
                yearsOnJob = int.Parse(textBox2.Text);

                //Determine if user qualifies.
                if (salary >= MINIMUM_SALARY || yearsOnJob >=5)
                {

                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB && salary >= MINIMUM_SALARY || yearsOnJob >= 5)
                    {
                        //User Qualifies
                        label4.Text = "You qualify for the loan";
                    }
                    else
                    {
                        //User doesn't qualify
                        label4.Text = "Minimum years at current " + "job not met.";
                    }

                }
                else
                {
                    //Use doesn't qualify.
                    label4.Text = "Minimum salary requirement " + "not met.";
                }
            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clears Textbox & label.
            AnnualSalary.Text = "";
            textBox2.Text = "";
            label4.Text = "";
            lastNametextBox1.Text = "";
            firstNametextBox.Text = "";
            MItextBox.Text = "";
            agecomboBox1.Text = "";
            SSNtextBox.Text = "";
            NumbertextBox.Text = "";
            streettextBox.Text = "";
            CitytextBox.Text = "";
            employertextBox.Text = "";

            //Reset Focus
            AnnualSalary.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Exit program
            this.Close();
        }

        private void AnnualSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EmploygroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            atmMachine.atmMachine myATM = new atmMachine.atmMachine();

            myATM.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mortgageCalc.Form1 myMortgage = new mortgageCalc.Form1();

            myMortgage.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            administrator.Administrator myAdmin = new administrator.Administrator();

            myAdmin.ShowDialog();
        }
    }
    }

