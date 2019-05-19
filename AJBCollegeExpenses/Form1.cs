/*Andrew Boschee
 * CIS 251
 * 7/18/18
 * Assign 10
 * CollegeExpenses
 * File Structure: Date, Expense Type, Item, Payee, Description, Amount
 * Writes data to CollegeExpenses.dat file
 *record college expenses input by user*/
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

namespace AJBCollegeExpenses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtbOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        { 
            //declare all variables and convert them to strings
            //date variables stored as int and converted to string to create datestring 
            string payee = Convert.ToString(txtPayee.Text);
            string item = Convert.ToString(txtItem.Text);
            string description = Convert.ToString(txtDescription.Text);
            string type= lstType.GetItemText(lstType.SelectedItem); 

            decimal amount = Convert.ToDecimal(txtAmount.Text);
            int month = Convert.ToInt32(nudMonth.Value);
            int year = Convert.ToInt32(nudYear.Value);
            int date = Convert.ToInt32(nudDate.Value);
            string dateString = Convert.ToString(month) + "/" + Convert.ToString(date) + "/" + Convert.ToString(year);
            string outputLine = dateString + "," + Convert.ToString(amount) + "," + item + "," + type + "," + payee +  "," + description;
            
            //define where data is to be sent
            string path = @"CollegeExpenses.dat";

            StreamWriter textOut = new StreamWriter(
            new FileStream(path, FileMode.Append, FileAccess.Write));

            //write output to dat file
            textOut.WriteLine(outputLine);
            //output appended to rich text box
            rtbOut.AppendText(dateString + "      " + amount.ToString("c")+ "     " + item + "     " + type + "    " + payee + "    " + description);
            textOut.Close();
        }
        

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
