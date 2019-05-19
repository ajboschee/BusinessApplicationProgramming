/*****************************************************************
 * Andrew Boschee
 * CIS 251: BAP
 * Dr. Mckeown
 * Sort Records
 * AlienInvasion.dat file
 * File Structure: ID, Score
 * Loads arrays from data file and display them
 * Sort id ascending and scores descending from menu buttons
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

namespace AJBAlienInvaders
{
    public partial class Form1 : Form
    {
        //declare variables
        String[] ID = new string[1];
        double[] score = new double[1];
        
        int num = 0;

        public Form1()
        {
            InitializeComponent();
        }  
        private void Form1_Load(object sender, EventArgs e)
        {
                header();
                //IO initialization
                string path = @"AlienInvaders.dat";
                StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));
                //disable menu buttons until file read
                mnuSortID.Enabled = false;
                mnuSortScore.Enabled = false;

                //Processing loop
                while (textIn.Peek() != -1)
                {
                    //Resize arrays to make room for new record
                    Array.Resize<string>(ref ID, ID.Length + 1);
                    Array.Resize<double>(ref score, score.Length + 1);
                    //Read record and add to array
                    string row = textIn.ReadLine();
                    string[] record = row.Split(',');
                    ID[num] = record[0];
                    score[num] = Convert.ToDouble(record[1]);
                    num++;
                }

                //Close file
                textIn.Close();
                //Resize arrays to remove extra space
                Array.Resize<string>(ref ID, ID.Length - 1);
                Array.Resize<double>(ref score, score.Length - 1);
            

        }
        private void mnuFileLoad_Click(object sender, EventArgs e)
        {
            rtbOut.Clear();
            header();

            //loop through data file and show all data
            for (int i=0; i <= ID.GetUpperBound(0); i++)
            {
                rtbOut.AppendText(ID[i].PadRight(25) + score[i].ToString("n0").PadLeft(10) + "\n");
            }
            //enable/disable menu buttons
            mnuFileLoad.Enabled = false;
            mnuSortID.Enabled = true;
            mnuSortScore.Enabled = true;
        }
        //header procedure
        private void header()
        {
            rtbOut.AppendText("          Alien Invaders" + "\n");
            rtbOut.AppendText("      All-Time Scoring Leaders " + "\n\n");
            rtbOut.AppendText("ID                           Score" + "\n");
        }

        

        private void rtbOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuSortID_Click(object sender, EventArgs e)
        {
            //sort ids in ascending order
            for(int i=0; i < ID.GetUpperBound(0); i++)
            {
                for(int j=0; j < (ID.GetUpperBound(0)-i); j++)
                {
                    int k = j + 1;

                    if (string.Compare(ID[j], ID[k]) >= 0)
                    {
                        string tempID = ID[j];
                        ID[j] = ID[k];
                        ID[k] = tempID;
                        double tempScore = score[j];
                        score[j] = score[k];
                        score[k] = tempScore;
                    }
                }
            }
            rtbOut.Clear();
            header();
            //loop through sorted ids
            for(int i =0; i <= ID.GetUpperBound(0); i++)
            {
                rtbOut.AppendText(ID[i].PadRight(25) + score[i].ToString("n0").PadLeft(10) + "\n");
            }
        }

        private void mnuSortScore_Click(object sender, EventArgs e)
        {
            //sort scores by descending order
            for (int i = 0; i < ID.GetUpperBound(0); i++)
            {
                for (int j = 0; j < (ID.GetUpperBound(0)-i); j++)
                {
                    int k = j + 1;

                    if (score[j]< score[k])
                    {
                        double tempScore = score[j];
                        score[j] = score[k];
                        score[k] = tempScore;
                        string tempID = ID[j];
                        ID[j] = ID[k];
                        ID[k] = tempID;

                    }
                }
            }
            rtbOut.Clear();
            header();
            //loop through sorted scores
            for (int i = 0; i <= ID.GetUpperBound(0); i++)
            {
                rtbOut.AppendText(ID[i].PadRight(25) + score[i].ToString("n0").PadLeft(10) + "\n");
            }
        }
    }
}
