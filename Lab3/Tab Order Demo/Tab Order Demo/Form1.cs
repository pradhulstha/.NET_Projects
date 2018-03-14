using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tab_Order_Demo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            
            cityTextBox.Visible = false;
            addressTextBox.Visible = false;
            nameTextBox.Visible = false;
            zipTextBox.Visible = false;
            stateTextBox.Visible = false;
            
            string name = cityTextBox.Text;
            nameLabel.Text = name;
            addressLabel.Text = addressTextBox.Text;
            cityLabel.Text = nameTextBox.Text;
            zipLabel.Text = zipTextBox.Text;
            stateLabel.Text = stateTextBox.Text;

            nameLabel.Visible = true;
            stateLabel.Visible = true;
            addressLabel.Visible = true;
            zipLabel.Visible = true;
            cityLabel.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cityTextBox.Visible = true;
            addressTextBox.Visible = true;
            nameTextBox.Visible = true;
            zipTextBox.Visible = true;
            stateTextBox.Visible = true;

            cityTextBox.Text =  "";
            addressTextBox.Text = "";
            nameTextBox.Text = "";
            zipTextBox.Text= "";
            stateTextBox.Text= "";


            nameLabel.Visible = false;
            stateLabel.Visible = false;
            addressLabel.Visible = false;
            zipLabel.Visible = false;
            cityLabel.Visible = false;

        }
    }
}
