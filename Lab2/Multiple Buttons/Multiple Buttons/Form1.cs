using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Multiple_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the first button.");
        }

        private void secondButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the second button.");
        }

        private void thirdButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the third button.");
        }

        private void fourthButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeah! clicked the fourth button.");
        }

        private void fifthButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hurray! You clicked the fifth button.");
        }

        private void sixthButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hurray! You clicked the Sixth button.");
        }

        private void seventhButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hurray! You clicked the Seventh button.");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hurray! You clicked the Eight button.");
        }
    }
}
