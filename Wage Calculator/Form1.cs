using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wage_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcGrossPayButton_Click(object sender, EventArgs e)
        {
            // Variables
            int noOne;
            double noTwo, Sum;

            // Get data entered by the user.
            noOne = int.Parse(noOneTextBox.Text);
            noTwo = double.Parse(noTwoTextBox.Text);

            // Calculate the Sum.
            Sum = noOne + noTwo;

            // Display the gross pay in a message box.
            MessageBox.Show("The Sum is " + Sum.ToString(""));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
