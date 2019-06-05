/*****************************************************************
 * Andrew Boschee
 * CIS 251: BAP
 * Dr. Mckeown
 * Load arrays from a file example
 * SDCounties.dat file
 * File Structure: county, population, area, children
 * Loads parallel arrays from a data file and displays them
 * Analyse statistics of population by county
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

namespace AJBPopulationStatistics
{
    public partial class Form1 : Form
    {

        //declare variables
        String[] county = new string[1];
        double[] population = new double[1];
        double[] area = new double[1];
        double[] density = new double[1];
        double[] childrenPercent = new double[1];
        int[] children = new int[1];
        int num = 0;
        double totalPopulation = 0;
        double totalArea = 0;
        double totalDensity = 0;
        double totalchildrenPercent = 0;
        double totalChildren = 0;
        string densityString = "";

        
        public Form1()
        {

            InitializeComponent();
            //Open file
            //IO initializations
            string path = @"SDCounties.dat";
            StreamReader textIn = new StreamReader(
            new FileStream(path, FileMode.Open, FileAccess.Read));
            mnuReportChildren.Enabled = false;
            mnuReportDensity.Enabled = false;

            //Processing loop
            while (textIn.Peek() != -1)
            {
                //Resize arrays to make room for new record
                Array.Resize<string>(ref county, county.Length + 1);
                Array.Resize<double>(ref area, area.Length + 1);
                Array.Resize<int>(ref children, children.Length + 1);
                Array.Resize<double>(ref population, population.Length + 1);
                Array.Resize<double>(ref density, density.Length + 1);
                Array.Resize<double>(ref childrenPercent, childrenPercent.Length + 1);
                //Read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                county[num] = record[0];
                population[num] = Convert.ToDouble(record[1]);
                area[num] = Convert.ToDouble(record[2]);
                children[num] = Convert.ToInt32(record[3]);
                density[num] = population[num] / area[num];
                childrenPercent[num] = children[num] / population[num];
                num++;
            }

            //Close file
            textIn.Close();
            for (int i = 0; i < county.GetUpperBound(0); i++)
            {
                totalPopulation = totalPopulation + population[i];
                totalArea = totalArea + area[i];
                totalDensity = totalPopulation / totalArea;
                densityString = county[i].PadRight(15) + population[i].ToString("n0").PadLeft(10) + area[i].ToString("n0").PadLeft(10) + density[i].ToString("f1").PadLeft(10) + "\n";

            }
            rtbOut.AppendText("Totals: " + totalPopulation.ToString("n0").PadLeft(17) + totalArea.ToString("n0").PadLeft(10) + totalDensity.ToString("f1").PadLeft(10) + "\n");

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void mnuFileLoad_Click(object sender, EventArgs e)
        {
            //reset variables to zero
            totalPopulation = 0;
            totalArea = 0;
            
            //Preprocessing
            rtbOut.Clear();
            rtbOut.AppendText("             South Dakota Population" + "\n");
            rtbOut.AppendText("                 Education Report" + "\n\n");
            rtbOut.AppendText("                                     Children" + "\n");
            rtbOut.AppendText("County         Population      Area  Under 18" + "\n");

            //loop for initial opening
            for (int i=0; i < county.GetUpperBound(0); i++)
            {

                totalPopulation = totalPopulation + population[i];
                totalArea = totalArea + area[i];
                totalChildren = totalChildren + children[i];
                rtbOut.AppendText(county[i].PadRight(15) + population[i].ToString("n0").PadLeft(10) + area[i].ToString("n0").PadLeft(10) + children[i].ToString("n0").PadLeft(10) + "\n");
            }
            rtbOut.AppendText("Totals: " + totalPopulation.ToString("n0").PadLeft(17) + totalArea.ToString("n0").PadLeft(10) + totalChildren.ToString("n0").PadLeft(10) + "\n");
            mnuFileLoad.Enabled = false;
            mnuReportChildren.Enabled = true;
            mnuReportDensity.Enabled = true;
        }

        private void mnuReportDensity_Click(object sender, EventArgs e)
        {
            //reset total variables
            totalPopulation = 0;
            totalArea = 0;
            totalDensity = 0;
            
            rtbOut.Clear();
            rtbOut.AppendText("             South Dakota Population" + "\n");
            rtbOut.AppendText("                 Education Report" + "\n\n");
            
            rtbOut.AppendText("County         Population      Area   Density"+"\n");

            //loop for columns to analyze density
            rtbOut.AppendText(densityString);
        }

        private void mnuReportChildren_Click(object sender, EventArgs e)
        {
            //reset total variables
            totalPopulation = 0;
            totalArea = 0;
            totalchildrenPercent = 0;
            totalChildren = 0;

            rtbOut.Clear();
            rtbOut.AppendText("             South Dakota Population" + "\n");
            rtbOut.AppendText("                 Education Report" + "\n\n");

            rtbOut.AppendText("County         Population      Kids   Percent" + "\n");
            //loop through colums to analyze children report
            for (int i = 0; i < county.GetUpperBound(0); i++)
            {
                totalPopulation = totalPopulation + population[i];
                totalArea = totalArea + area[i];
                totalChildren = totalChildren + children[i];
                totalchildrenPercent = totalChildren/totalPopulation;
                rtbOut.AppendText(county[i].PadRight(15) + population[i].ToString("n0").PadLeft(10) + children[i].ToString("n0").PadLeft(10) + childrenPercent[i].ToString("p1").PadLeft(10) + "\n");
            }
            rtbOut.AppendText("Totals: " + totalPopulation.ToString("n0").PadLeft(17) + totalChildren.ToString("n0").PadLeft(10) + totalchildrenPercent.ToString("p1").PadLeft(10) + "\n");
        }
    }
}
