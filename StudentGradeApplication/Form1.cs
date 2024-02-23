using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
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

        private void button1_Click(object sender, EventArgs e)
        {

            double score1 = Convert.ToDouble(textBox1.Text);
            double score2 = Convert.ToDouble(textBox2.Text);
            double score3 = Convert.ToDouble(textBox3.Text);
            double score4 = Convert.ToDouble(textBox4.Text);
            double score5 = Convert.ToDouble(textBox5.Text);
            double sum = score1 + score2 + score3 + score4 + score5;
            double average = sum / 5;

            label8.Text = average >= 75 ? "The Student Passed" + "\nThe general average of " + textBox6.Text + " is " + average + ".": "The Student Failed" + "\nThe general average of " + textBox6.Text + " is " + average + ".";
            

        }
    }
}