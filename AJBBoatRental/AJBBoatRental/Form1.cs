/*Andrew Boschee
 * CIS 251
 * 7/9/18
 * Assign 5
 * Boat Rental
 *Calculate cost for renting a boat*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJBBoatRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //closes program if exit button selected
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisplayHeader()
        {
            //stored procedure for header
            rtbOut.AppendText("         Sandy Shoals Boat Rental" + "\n");
            rtbOut.AppendText("             Customer Receipt \n" + "\n");
            rtbOut.AppendText("Item".PadRight(15) + "Days".PadRight(10) + "Price".PadRight(10) + "Amount");
        }
        //use datatime.now in load to show the current date
        private void Form1_Load(object sender, EventArgs e)
        {

            DisplayHeader();
            DateTime currentDate = DateTime.Now;
            lblDate.Text = currentDate.ToShortDateString();

        }
        private void CalcCosts()
        {
            //declare all variables with sales tax rate being only constant
            const decimal salesTaxRate = .05m;

            decimal subtotal = 0;
            decimal balance = 0;
            decimal fishingGearCost = 0;
            decimal lifePreserverCost = 0;
            decimal sonarCost = 0;
            decimal netCost = 0;
            decimal canoePrice = 29;
            decimal rowBoatPrice = 24;
            decimal trawlerPrice = 45;
            decimal pontoonPrice = 85;
            decimal fishingGearPrice = 15;
            decimal lifePreserverPrice = 2;
            decimal sonarPrice = 12;
            decimal netPrice = 3;
            //convert numeric up down to int
            int days = Convert.ToInt32(nudDays.Value);
            //clear out results each time change is made and show header
            rtbOut.Clear();
            DisplayHeader();
            //if and else if statements to calculate subtotal and print out put of button selected
            //padding used to spread out results
            if (radCanoe.Checked)
            {
                subtotal = days * canoePrice;              
                rtbOut.AppendText("\nCanoe".PadRight(18) + days.ToString("f0").PadRight(8) + canoePrice.ToString("c")+ subtotal.ToString("c").PadLeft(10));
            }
            else if (radRowBoat.Checked)
            {
                subtotal = days * rowBoatPrice;               
                rtbOut.AppendText("\nRowboat".PadRight(18) + days.ToString("f0").PadRight(8)+ rowBoatPrice.ToString("c") + subtotal.ToString("c").PadLeft(10));
            }
            else if (radTrawler.Checked)
            {
                subtotal = days * trawlerPrice;
                rtbOut.AppendText("\nTrawler".PadRight(18) + days.ToString("f0").PadRight(8)+ trawlerPrice.ToString("c")+ subtotal.ToString("c").PadLeft(10));
            }
            else 
            {
                subtotal = days * pontoonPrice;
                rtbOut.AppendText("\nPontoon".PadRight(18) + days.ToString("f0").PadRight(8) + pontoonPrice.ToString("c") + subtotal.ToString("c").PadLeft(10));
            }
            //if statements to make calculations of costs and addition to subtotal if selected. 
            if (chkFishingGear.Checked)
            {
                fishingGearCost = fishingGearPrice * days;
                subtotal = subtotal + fishingGearCost;
                rtbOut.AppendText("\nFishingGear".PadRight(18) + days.ToString("f0").PadRight(8)+ fishingGearPrice.ToString("c") + fishingGearCost.ToString("c").PadLeft(10));
            }
            if (chkLifePreserver.Checked)
            {
                lifePreserverCost = lifePreserverPrice * days;
                subtotal = subtotal + lifePreserverCost;
                rtbOut.AppendText("\nLifePreserver".PadRight(18) + days.ToString("f0").PadRight(8)+ lifePreserverPrice.ToString("c") + lifePreserverCost.ToString("c").PadLeft(11));
            }
            if (chkSonar.Checked)
            {
                sonarCost = sonarPrice * days;
                subtotal = subtotal + sonarCost;
                rtbOut.AppendText("\nSonar".PadRight(18) + days.ToString("f0").PadRight(8)+ sonarPrice.ToString("c")+ sonarCost.ToString("c").PadLeft(10));
            }
            if (chkNet.Checked)
            {
                netCost = netPrice * days;
                subtotal = subtotal + netCost;
                rtbOut.AppendText("\nNet".PadRight(18) + days.ToString("f0").PadRight(8) + netPrice.ToString("c") + netCost.ToString("c").PadLeft(11));
            }
            //calculations of sales tax and overall balance
            decimal salesTax = subtotal * salesTaxRate;
            balance = salesTax + subtotal;
            //print out subtotal, tax, and final balance
            rtbOut.AppendText("\nSubtotal " + subtotal.ToString("c").PadLeft(32));
            rtbOut.AppendText("\nSales Tax @"+salesTaxRate.ToString("p2") + salesTax.ToString("c").PadLeft(25));
            rtbOut.AppendText("\nBalance" + balance.ToString("c").PadLeft(34));

        }
        private void rtbOut_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void nudDays_ValueChanged(object sender, EventArgs e)
        {
            CalcCosts();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CalcCosts();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CalcCosts();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CalcCosts();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CalcCosts();
        }

        private void radCanoe_CheckedChanged(object sender, EventArgs e)
        {
            CalcCosts();
        }

        private void radRowBoat_CheckedChanged(object sender, EventArgs e)
        {
            CalcCosts();
        }

        private void radTrawler_CheckedChanged(object sender, EventArgs e)
        {
            CalcCosts();
        }

        private void radPontoon_CheckedChanged(object sender, EventArgs e)
        {
            CalcCosts();
        }

        private void mnuClear_Click(object sender, EventArgs e)
        {
            //if clear button clicked, checkboxes will be set to false aside from the canoe which is default.
            //rtbout.clear will erase all other results and numeric updown reset to 1
            rtbOut.Clear();
            radCanoe.Checked = true;
            radPontoon.Checked = false;
            radRowBoat.Checked = false;
            radTrawler.Checked = false;
            chkFishingGear.Checked = false;
            chkLifePreserver.Checked = false;
            chkNet.Checked = false;
            chkSonar.Checked = false;
            nudDays.Value = 1;
            rtbOut.Clear();
            DisplayHeader();
        }
    }
}
