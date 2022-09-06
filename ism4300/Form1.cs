using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ism4300
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int marks = 0;

            marks = Convert.ToInt32(MarksEarnedTextBox.Text);

            //ifelse 
            //98 - 100
            string grade = "-";
            if (marks >= 98 && marks <= 100)
            {
                grade = "A+";
            }

            else if (marks >= 92 && marks <= 97)
            {
                grade = "A";

            }
            else if (marks >= 90 && marks <= 91)
            {
                grade = "A-";
            }

            else if (marks >= 88 && marks <= 89)
            {
                grade = "B+";
            }

            else if (marks >= 82 && marks <= 87)
            {
                grade = "B";
            }

            else if (marks >= 80 && marks <= 81)
            {
                grade = "B-";
            }

            else if (marks >= 78 && marks <= 79)
            {
                grade = "C+";
            }

            else if (marks >= 72 && marks <= 77)
            {
                grade = "C";
            }

            else if (marks >= 70 && marks <= 71)
            {
                grade = "C-";
            }

            else if (marks >= 68 && marks <= 69)
            {
                grade = "D+";
            }

            else if (marks >= 62 && marks <= 67)
            {
                grade = "D";
            }

            else if (marks >= 60 && marks <= 61)
            {
                grade = "D-";
            }

            else if (marks >= 0 && marks <= 59)
            {
                grade = "E";
            }

            else if (marks <= 0 || marks >= 100)
            {
               grade = "Enter valid Grade.";
            }

            label5.Text = grade.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            MarksEarnedTextBox.Text = string.Empty;
            label5.Text = "-";
        }
    }
}
