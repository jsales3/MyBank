﻿using System;
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
    


        public partial class Administrator : Form
        {

        public Administrator()
            {
                InitializeComponent();
            }

            private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void usernamelabel2_Click(object sender, EventArgs e)
            {

            }

          
            private void button1_Click(object sender, EventArgs e)
            {
            try
            {
                string userName = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();

                if (userName == "Jovon" && password == "Sales")
                {
                    DBBackup_Restore myDBBackup_Restore = new DBBackup_Restore();
                    myDBBackup_Restore.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Login Information");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }

