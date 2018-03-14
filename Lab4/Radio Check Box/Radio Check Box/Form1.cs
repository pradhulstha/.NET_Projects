using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Check_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            String saveNation;
            if (americanRadioButton.Checked)
                saveNation = americanRadioButton.Text;

            else if (asianRadioButton.Checked)
                saveNation = asianRadioButton.Text;

            else if (hispanicRadioButton.Checked)
                saveNation = hispanicRadioButton.Text;
            
            else if (britishRadioButton.Checked)
                saveNation = britishRadioButton.Text;

            else
                saveNation = somaliaRadioButton.Text;

            MessageBox.Show("Hello! " + saveNation);

            String str1 = "";

            if (MinnesotaCheckBox.Checked)
            {
                str1 += MinnesotaCheckBox.Text + ", ";
              
            }

            if (SouthCarolinaCheckbox.Checked)
            {
                str1 += SouthCarolinaCheckbox.Text +", ";
              
            }
            if (texasCheckbox.Checked)
            {
                str1 += texasCheckbox.Text+ ", ";
                
            }

            if (californiaCheckbox.Checked)
            {
                str1 += californiaCheckbox.Text +", ";
                
            }

            if (OhioCheckbox.Checked)
            {
                str1 += OhioCheckbox.Text + ", ";
                
            }

            if (OklahomaCheckbox.Checked)
            {
                str1 += OklahomaCheckbox.Text + ", ";
                
            }

            if (NorthDakotaCheckBox.Checked)
            {
                str1 += NorthDakotaCheckBox.Text + ", ";
                
            }

            if(WisconsonCheckbox.Checked){
                str1 += WisconsonCheckbox.Text + ", ";
               
            }
            MessageBox.Show("You selected " + str1);

        }

        
    }
}
