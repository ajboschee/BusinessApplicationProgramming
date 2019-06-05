/*Andrew Boschee
 * CIS 251
 * 7/12/18
 * Assign 7
 * FieldYields
 * Reads fieldyields.dat file
 *calculates yields and total acres*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AJBFieldYields
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //close application when clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbOut_TextChanged(object sender, EventArgs e)
        {

        }

        //displays current date in form header
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            this.Text = currentDate.ToShortDateString();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            rtbOut.Clear();
            rtbOut.AppendText("                   Sodbuster Farms\n");
            rtbOut.AppendText("                  2018 Crop Summary \n"+ "\n");
            rtbOut.AppendText("Field        Crop      Acres       Bushels    Yield\n");
            //declare variables
            decimal acres, bushels;
            decimal yield = 0;
            string zone, crop;
            decimal totalAcres = 0;
            //define where data is coming from and read from file
            string path = @"FieldYield.dat";
            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));
            //loop through each line of file
            while (textIn.Peek() != -1)
            {
                //read data from file
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                //assign data from array in proper variables
                zone = record[0];
                acres = decimal.Parse(record[1]);
                crop = record[2];
                bushels = decimal.Parse(record[3]);
                yield = bushels / acres;
                totalAcres = totalAcres + acres;
                
                rtbOut.AppendText(zone.PadRight(13) + crop.PadRight(6) + acres.ToString("n0").PadLeft(9) + bushels.ToString("n0").PadLeft(13) + yield.ToString("n1").PadLeft(10) + "\n");
                //output with proper padding

            }
            //close streamreader
            textIn.Close();
            rtbOut.AppendText("Total Acres: " + totalAcres.ToString("n1").PadLeft(15));
            //sum of acres
        }
    }
}
