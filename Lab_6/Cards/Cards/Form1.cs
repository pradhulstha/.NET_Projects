using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (cardListBox.SelectedIndex != -1)
            {
                Showcard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Select a card from the list to proceed.");
            }
        }

            private void Showcard(string card)
            {
                switch (card)
                {
                    case "Ace of Spades":
                        AceSpades();
                        break;
                    case "10 of Hearts":
                        TenHearts();
                        break;
                    case "King of Clubs":
                        KingClubs();
                        break;
                    case "King of Spades":
                        KingSpades();
                        break;
                   
                }
            }

            private void AceSpades()
            {
                aceSpadesPictureBox.Visible = true;
                tenHeartsPictureBox.Visible = false;
                queenHeartspictureBox.Visible = false;
                
            }

            private void TenHearts()
            {
                aceSpadesPictureBox.Visible = false;
                tenHeartsPictureBox.Visible = true;
                kingClubsPictureBox.Visible = false;
                queenHeartspictureBox.Visible = false;
               
            }

            private void KingClubs()
            {
                aceSpadesPictureBox.Visible = false;
                tenHeartsPictureBox.Visible = false;
                kingClubsPictureBox.Visible = true;
                queenHeartspictureBox.Visible = false;
                

            }

            private void KingSpades()
            {
                aceSpadesPictureBox.Visible = false;
                tenHeartsPictureBox.Visible = false;
                kingClubsPictureBox.Visible = false;
                queenHeartspictureBox.Visible = true;
                

            }         

            private void exitButton_Click(object sender, EventArgs e)
            {
                this.Close();
            }

       }
    }



