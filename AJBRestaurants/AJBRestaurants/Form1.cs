
/*****************************************************************
 * Andrew Boschee
 * CIS 251: BAP
 * Dr. Mckeown
 * Load arrays from a file example
 * Restaurants.dat file
 * File Structure: name, seating type, rating
 * Loads parallel arrays from a data file and displays them as desired
 * compare and search for restaurants by specified criteria
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
using System.IO;

namespace AJBRestaurants
{
    public partial class Form1 : Form
    {
        //declare variables
        String[] name = new string[1];
        int[] seating  = new int[1];
        String[] type = new string[1];
        int[] rating = new int[1];
        int num = 0;
        string key="";
        



        public Form1()
        {
            InitializeComponent();
            

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Open file and IO Initialization
            string path = @"Restaurants.dat";
            StreamReader textIn = new StreamReader(
            new FileStream(path, FileMode.Open, FileAccess.Read));


            
            while (textIn.Peek() != -1)
            {
                //resize arrays for upcoming records
                Array.Resize<string>(ref name, name.Length + 1);
                Array.Resize<int>(ref seating, seating.Length + 1);
                Array.Resize<string>(ref type, type.Length + 1);
                Array.Resize<int>(ref rating, type.Length + 1);
                //read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                name[num] = record[0];
                seating[num] = Convert.ToInt32(record[1]);
                type[num] = record[2];
                rating[num] = Convert.ToInt32(record[3]);


                num = num + 1;
            }

            //close file
            textIn.Close();
            // show all information when opening
            num = 0;
            header();
            for (int i = 0; i < name.GetUpperBound(0); i++)
            {
                num++;

                if (key != type[i])
                {
                    lstType.Items.Add(type[i]);
                    key = type[i];
                }
                rtbOut.AppendText(name[i].PadRight(25) + seating[i].ToString("n0").PadLeft(6) + type[i].PadLeft(10) + rating[i].ToString("n0").PadLeft(10) + "\n");
            }
            lblRecords.Text = num.ToString("n0");
        }
        //header procedure
        private void header()
        {
            
            rtbOut.Clear();
            rtbOut.AppendText("              Lake County Restaurant Guide" + "\n");
            rtbOut.AppendText("                     Search Program" + "\n\n");
            rtbOut.AppendText("Name                    Seating     Type     Rating" + "\n");
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            //create variable for searchname from textbox
            string searchName = txtSearch.Text;
            num = 0;
            header();
            //search for matching names

            for (int i = 0; i < name.GetUpperBound(0); i++)
            {
                if (searchName.ToUpper() == name[i].ToUpper())
                {
                    num++;
                    rtbOut.AppendText(name[i].PadRight(25) + seating[i].ToString("n0").PadLeft(6) + type[i].PadLeft(10) + rating[i].ToString("n0").PadLeft(10) + "\n");
                }
            }
            //output number of records to label
            lblRecords.Text = num.ToString("n0");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void lstType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show output of selected list item
            string selectedItem = Convert.ToString(lstType.SelectedItem);
            num = 0;
            header();

            for (int i = 0; i < name.GetUpperBound(0); i++)
            {
                if (selectedItem == type[i])
                {
                    num++;
                    rtbOut.AppendText(name[i].PadRight(25) + seating[i].ToString("n0").PadLeft(6) + type[i].PadLeft(10) + rating[i].ToString("n0").PadLeft(10) + "\n");
                }
            }
            lblRecords.Text = num.ToString("n0");
        }

        private void lblRecords_Click(object sender, EventArgs e)
        {

        }

        private void nudRating_ValueChanged(object sender, EventArgs e)
        {
            //create variable for minrating when numericupdown is used
            
            int minRating = Convert.ToInt32(nudRating.Value);
            num = 0;
            header();
            
                for (int i = 0; i < name.GetUpperBound(0); i++)
                {

                    //if statement to make sure only selected item is shown along with minimum rating
                    if (minRating <= rating[i])
                    {
                        num++;
                        rtbOut.AppendText(name[i].PadRight(25) + seating[i].ToString("n0").PadLeft(6) + type[i].PadLeft(10) + rating[i].ToString("n0").PadLeft(10) + "\n");
                    }

                }

                lblRecords.Text = num.ToString("n0");
     
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
