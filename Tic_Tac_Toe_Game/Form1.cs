using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        bool turn = true; //true= x turn and false= y turn
        int count_turn = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure u want to Quit\nIf yes press OK button...", "Alert");
            Application.Exit();
           
        }

        private void aboutGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer Name is Wajahat Mansoori \nContactNo: 03152993405", "DEVELOPER INFO");
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn == true)
            {
                b.Text = "x";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            count_turn++;
            Winner();
           
        }

        private void Winner()
        {
            bool Winner_Name = false; 
            //Horizontally
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A1.Enabled == false))
            {
                Winner_Name = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B1.Enabled == false))
            {
                Winner_Name = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C1.Enabled == false)) 
            {
                Winner_Name = true;
            }

            //vertically
          else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (A1.Enabled == false))
            {
                Winner_Name = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (A2.Enabled == false))
            {
                Winner_Name = true;
            }

            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (A3.Enabled == false)) 
            {
                Winner_Name = true;
            }

            //diagnal
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (A1.Enabled == false))
            {
                Winner_Name = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (C1.Enabled == false))
            {
                Winner_Name = true;
            }


            if (Winner_Name == true)
            {
                Disable_Button();
                string Result="";
                if(turn==true)
                {
                    Result="0";
                }
                else
                {
                    Result="X";
                }
                MessageBox.Show("Winner is"+" "+Result,"Winner Name");
            }

            else if(count_turn==9)
            {
                MessageBox.Show("Game Drawn", "Alert");
            }
            
        }

        private void Disable_Button()
        {
            try
            {

                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch
            { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            count_turn = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch
            {

            }

        }
    }
}
