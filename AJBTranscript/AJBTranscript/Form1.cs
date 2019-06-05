/*Andrew Boschee
 * CIS 251
 * 7/14/18
 * Assign 9
 * Transcript
 * File Structure: course prefix, number, name, semester, year, credits, grade
 * Reads Transcript.dat file and displays trascript
 *calculates GPA, number of credits/courses and shows date*/
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

namespace AJBTranscript
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //set header and declare variables
            rtbOut.AppendText("                       Gaseous State University \n");
            rtbOut.AppendText("                          Official Transcript \n" + "\n");
            rtbOut.AppendText("Prefix No.    Class                                Sem.    Year  Grade  Cr.  Points  \n");
            string coursePrefix, courseNo, courseName, courseTerm, grade;
            int courseYear, numCredits;
            double cummGradePoints = 0;
            double cummNumCredits = 0;
            int numCourses = 0;
            int gradePoints = 0;
            int multiplier=0;
            double gradePointAverage = 0;
            DateTime currentDate = DateTime.Now;
            

            //define where data is coming from and read from file
            string path = @"Transcript.dat";
            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));
            //loop through each line of file
            while (textIn.Peek() != -1)
            {
                //read data from file
                string row = textIn.ReadLine();
                string[] record = row.Split(',');

                //assign array index to variables
                coursePrefix = record[0];
                courseNo = record[1];
                courseName = record[2];
                courseTerm = record[3];
                courseYear = int.Parse(record[4]);
                numCredits = int.Parse(record[5]);
                grade = record[6];
                
                //use switch statement to determine multiplier based on grade per class
                switch(grade)
                {
                    case "A":
                        multiplier = 4;
                        break;
                    case "B":
                        multiplier = 3;
                        break;
                    case "C":
                        multiplier = 2;
                        break;
                    case "D":
                        multiplier = 1;
                        break;
                    case "F":
                        multiplier = 0;
                        break;
                }
                //calculate values for variables and use counter for number of courses
                cummNumCredits = cummNumCredits + numCredits;
                numCourses = numCourses + 1;
                gradePoints = numCredits * multiplier;
                cummGradePoints = cummGradePoints + gradePoints;
                gradePointAverage = cummGradePoints / cummNumCredits;
                
                rtbOut.AppendText(coursePrefix.PadRight(6) + courseNo.PadRight(7) + courseName.PadRight(38) + courseTerm.PadRight(8) + courseYear.ToString("f0").PadRight(7) + grade.PadRight(6) + numCredits.ToString("f0").PadRight(6) + gradePoints + "\n");
            }
            //display calculations and current date with day
            rtbOut.AppendText("\n");
            rtbOut.AppendText("Number of Courses: " + numCourses.ToString("f0")+"\n");
            rtbOut.AppendText("Total Credits: " + cummNumCredits.ToString("f0")+ "\n");
            rtbOut.AppendText("GPA: " + gradePointAverage.ToString("f2")+ "\n");
            rtbOut.AppendText("Posted: " + DateTime.Now.DayOfWeek + ", " + currentDate.ToShortDateString() +"\n");
            textIn.Close();
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
