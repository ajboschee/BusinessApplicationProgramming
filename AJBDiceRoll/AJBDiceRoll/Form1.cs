/*****************************************************************
 * Andrew Boschee
 * CIS 251: BAP
 * Dr. Mckeown
 * Roll Dice
 * Roll two die using switch statements and keycode
 * roll dice every time spacebar pressed, and doubles when alt-r
 * ***************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJBDiceRoll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //generate random number
            Random rnd = new Random();

            int die1 = rnd.Next(1, 6);
            int die2 = rnd.Next(1, 6);
            int num1 = die1;
            int num2 = die2;
            //close if escape button pressed
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Space)
            {
                //num1 switch giving output for first die
                switch (num1){
                    case 1:
                        pic1.Visible = true;
                        pic2.Visible = false;
                        pic3.Visible = false;
                        pic4.Visible = false;
                        pic5.Visible = false;
                        pic6.Visible = false;
                        break;
                    case 2:
                     
                        pic2.Visible = true;
                        pic1.Visible = false;
                        pic3.Visible = false;
                        pic4.Visible = false;
                        pic5.Visible = false;
                        pic6.Visible = false;
                        break;
                    case 3:
                        
                        pic3.Visible = true;
                        pic2.Visible = false;
                        pic1.Visible = false;
                        pic4.Visible = false;
                        pic5.Visible = false;
                        pic6.Visible = false;
                        break;
                    case 4:
                        
                        pic4.Visible = true;
                        pic2.Visible = false;
                        pic3.Visible = false;
                        pic1.Visible = false;
                        pic5.Visible = false;
                        pic6.Visible = false;
                        break;
                    case 5:
                        
                        pic5.Visible = true;
                        pic2.Visible = false;
                        pic3.Visible = false;
                        pic4.Visible = false;
                        pic1.Visible = false;
                        pic6.Visible = false;
                        break;
                    case 6:
                        pic6.Visible = true;
                        pic2.Visible = false;
                        pic3.Visible = false;
                        pic4.Visible = false;
                        pic5.Visible = false;
                        pic1.Visible = false;
                        break;
                            
                }
                //num2 gives cases for the second die             
                switch (num2)
                {
                    case 1:
                        pic7.Visible = true;
                        pic11.Visible = false;
                        pic8.Visible = false;
                        pic9.Visible = false;
                        pic10.Visible = false;
                        pic12.Visible = false;
                        break;
                    case 2:

                        pic8.Visible = true;
                        pic7.Visible = false;
                        pic11.Visible = false;
                        pic9.Visible = false;
                        pic10.Visible = false;
                        pic12.Visible = false;
                        break;
                    case 3:

                        pic9.Visible = true;
                        pic7.Visible = false;
                        pic8.Visible = false;
                        pic11.Visible = false;
                        pic10.Visible = false;
                        pic12.Visible = false;
                        break;
                    case 4:

                        pic10.Visible = true;
                        pic7.Visible = false;
                        pic8.Visible = false;
                        pic9.Visible = false;
                        pic11.Visible = false;
                        pic12.Visible = false;
                        break;
                    case 5:

                        pic11.Visible = true;
                        pic7.Visible = false;
                        pic8.Visible = false;
                        pic9.Visible = false;
                        pic10.Visible = false;
                        pic12.Visible = false;
                        break;
                    case 6:
                        pic12.Visible = true;
                        pic7.Visible = false;
                        pic8.Visible = false;
                        pic9.Visible = false;
                        pic10.Visible = false;
                        pic11.Visible = false;
                        break;

                }
                
            }
            //use num1 in both switch statements to give doubles
            if(e.Alt && e.KeyValue == 82)
            {
                switch (num1)
                {
                    case 1:
                        pic1.Visible = true;
                        pic2.Visible = false;
                        pic3.Visible = false;
                        pic4.Visible = false;
                        pic5.Visible = false;
                        pic6.Visible = false;
                        break;
                    case 2:

                        pic2.Visible = true;
                        pic1.Visible = false;
                        pic3.Visible = false;
                        pic4.Visible = false;
                        pic5.Visible = false;
                        pic6.Visible = false;
                        break;
                    case 3:

                        pic3.Visible = true;
                        pic2.Visible = false;
                        pic1.Visible = false;
                        pic4.Visible = false;
                        pic5.Visible = false;
                        pic6.Visible = false;
                        break;
                    case 4:

                        pic4.Visible = true;
                        pic2.Visible = false;
                        pic3.Visible = false;
                        pic1.Visible = false;
                        pic5.Visible = false;
                        pic6.Visible = false;
                        break;
                    case 5:

                        pic5.Visible = true;
                        pic2.Visible = false;
                        pic3.Visible = false;
                        pic4.Visible = false;
                        pic1.Visible = false;
                        pic6.Visible = false;
                        break;
                    case 6:
                        pic6.Visible = true;
                        pic2.Visible = false;
                        pic3.Visible = false;
                        pic4.Visible = false;
                        pic5.Visible = false;
                        pic1.Visible = false;
                        break;

                }
                //used num1 like previous switch to get doubles and have corresponding pics for second dice display
                switch (num1)
                {
                    case 1:
                        pic7.Visible = true;
                        pic11.Visible = false;
                        pic8.Visible = false;
                        pic9.Visible = false;
                        pic10.Visible = false;
                        pic12.Visible = false;
                        break;
                    case 2:

                        pic8.Visible = true;
                        pic7.Visible = false;
                        pic11.Visible = false;
                        pic9.Visible = false;
                        pic10.Visible = false;
                        pic12.Visible = false;
                        break;
                    case 3:

                        pic9.Visible = true;
                        pic7.Visible = false;
                        pic8.Visible = false;
                        pic11.Visible = false;
                        pic10.Visible = false;
                        pic12.Visible = false;
                        break;
                    case 4:

                        pic10.Visible = true;
                        pic7.Visible = false;
                        pic8.Visible = false;
                        pic9.Visible = false;
                        pic11.Visible = false;
                        pic12.Visible = false;
                        break;
                    case 5:

                        pic11.Visible = true;
                        pic7.Visible = false;
                        pic8.Visible = false;
                        pic9.Visible = false;
                        pic10.Visible = false;
                        pic12.Visible = false;
                        break;
                    case 6:
                        pic12.Visible = true;
                        pic7.Visible = false;
                        pic8.Visible = false;
                        pic9.Visible = false;
                        pic10.Visible = false;
                        pic11.Visible = false;
                        break;

                }


            }
        }
    }
}
