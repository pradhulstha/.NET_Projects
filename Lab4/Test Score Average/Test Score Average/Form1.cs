using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            averageLabel.Text = "";
            double average = 0 ;
            double test1 = double.Parse(test1TextBox.Text);
            double test2 = double.Parse(test2TextBox.Text);
            double test3 = double.Parse(test3TextBox.Text);

            if (test1 >= 10 || test1 < 0)
            {
                MessageBox.Show("Please enter a valid Grade for Test 1");
                
            }
            else if (test2 >= 10 || test2 < 0)
            {
                MessageBox.Show("Please enter a valid Grade for Test 2");
                
            }
            else if(test3 >= 10 || test3 < 0)
            {
                MessageBox.Show("Please enter a valid Grade for Test 3");
                
            }

            average = (((test1 + test2 + test3)/ 30 ) * 100);

            if (average <= 50)
            {
                MessageBox.Show("I highly recommend to meet your instructor to improve your grades");
                averageLabel.Text = average.ToString();
            }
            else
                averageLabel.Text = average.ToString();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
