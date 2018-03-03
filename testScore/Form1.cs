using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void scoreBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Average_Click(object sender, EventArgs e)
        {
            try
            {
                double testScore;
                double testScore2;
                double testScore3;
                double testScore4;
                double testScore5;
                double average;
                double count = 0;

                if (double.TryParse(scoreBox1.Text, out testScore))
                {

                    if (testScore >= 0 && testScore <= 100)
                    {
                        count += testScore;
                    }

                    else
                    {
                        grade1.Text = "test score 1 is invalid";
                    }
                }

                if (double.TryParse(scoreBox2.Text, out testScore2))
                {

                    if (testScore2 >= 0 && testScore2 <= 100)
                    {
                        count += testScore2;
                    }

                    else
                    {
                        grade1.Text = "test score 2 is invalid";
                    }
                }
                if (double.TryParse(scoreBox3.Text, out testScore3))
                {

                    if (testScore3 >= 0 && testScore3 <= 100)
                    {
                        count += testScore3;
                    }

                    else
                    {
                        grade1.Text = "test score 3 is invalid";
                    }
                }
                if (double.TryParse(scoreBox4.Text, out testScore4))
                {

                    if (testScore4 >= 0 && testScore4 <= 100)
                    {
                        count += testScore4;
                    }

                    else
                    {
                        grade1.Text = "test score 4 is invalid";
                    }
                }
                if (double.TryParse(scoreBox5.Text, out testScore5))
                {

                    if (testScore5 >= 0 && testScore5 <= 100)
                    {
                        count += testScore5;
                    }

                    else
                    {
                        grade1.Text = "test score 5 is invalid";
                    }

                }
                else
                {

                    grade1.Text = "test scores are invalid";

                }

                average = count / 5;

                grade1.Text = "Your average grade is: " + average;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void exitbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            scoreBox1.Text = "";
            scoreBox2.Text = "";
            scoreBox3.Text = "";
            scoreBox4.Text = "";
            scoreBox5.Text = "";

            grade1.Text = "";
        }
    }
}

       
    
