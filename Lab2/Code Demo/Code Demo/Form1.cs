using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Code_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Your information has been saved. " + nameBox.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presidentBox.Text = "Donald Trump";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = presidentBox.Text;
            if (name.Equals("Donald Trump"))
                MessageBox.Show("Hurray! Nice Work" );
            else
                MessageBox.Show("Please Try Again!");


        }

        private void dogBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BHOW BHOW");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Cat");
        }
    }
}


