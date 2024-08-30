using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double bmi;
            bmi = Convert.ToDouble(txt2.Text) / (Convert.ToDouble(txt1.Text) * Convert.ToDouble(txt1.Text));

            txt3.Text = bmi.ToString();

            if (bmi < 18.5)
            {
                txt4.Text = "Under Weight";
                txt5.BackColor = Color.Red;
            }
            else if (bmi < 25)
            {
                txt4.Text = "Normal";
                txt5.BackColor = Color.Blue;
            }
            else if (bmi < 30)
            {
                txt4.Text = "Over Weight";
                txt5.BackColor = Color.Green;
            }
            else if (bmi < 35)
            {
                txt4.Text = "Obesity Class I";
                txt5.BackColor = Color.Orange;
            }
            else if (bmi < 40)
            {
                txt4.Text = "Obesity Class II";
                txt5.BackColor = Color.Pink;
            }
            else
            {
                txt4.Text = "Obesity Class III";
                txt5.BackColor = Color.Brown;
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.BackColor = BackColor;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
