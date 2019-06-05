/*****************************************************************
 * Andrew Boschee
 * CIS 251: BAP
 * Dr. Mckeown
 * Load arrays from a file example
 * majors.dat file
 * File Structure: majors, enrollment
 * Loads parallel arrays from a data file and displays them
 * Finds number of majors
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


namespace AJBLoadArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rtbOut_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFileLoad_Click(object sender, EventArgs e)
        {
            String[] major = new string[1];
            int[] enrollments = new int[1];
            int count = 0;
            int num = 0;

            //Open file and IO Initialization
            string path = @"Majors.dat";
            StreamReader textIn = new StreamReader(
            new FileStream(path, FileMode.Open, FileAccess.Read));
            //preprocessing
            rtbOut.Clear();
            rtbOut.AppendText("              DSU Majors" + "\n");
            rtbOut.AppendText("           New Enrollments" + "\n\n");
            //processing loop
            while (textIn.Peek() != -1)
            {
                //resize arrays for upcoming records
                Array.Resize<string>(ref major, major.Length + 1);
                Array.Resize<int>(ref enrollments, enrollments.Length + 1);
                //read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                major[num] = record[0];
                enrollments[num] = Convert.ToInt32(record[1]);
                num = num + 1;
            }
            //close file
            textIn.Close();
            //loop through records to append records
            for (int i=0; i < major.GetUpperBound(0); i++)
            {
                count = count + 1;
                rtbOut.AppendText(major[i].PadRight(25) + enrollments[i].ToString("n0").PadLeft(5) + "\n");
            }

            rtbOut.AppendText("Number of items: " + count.ToString("n0"));

        }
    }
}
