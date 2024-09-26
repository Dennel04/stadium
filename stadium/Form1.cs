using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stadium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            {
                if (int.TryParse(textBox1.Text, out int userInput1))
                {
                    int result1 = userInput1 * 15;
                    total += result1;

                    label9.Text = result1.ToString("F2") + "€";
                }
                else
                {
                    label9.Text = "Incorrect Value!";
                }
                if (int.TryParse(textBox2.Text, out int userInput2))
                {
                    int result2 = userInput2 * 12;
                    total += result2;

                    label10.Text = result2.ToString("F2") + "€";
                }
                else
                {
                    label10.Text = "Incorrect Value!";
                }
                if (int.TryParse(textBox3.Text, out int userInput3))
                {
                    int result3 = userInput3 * 9;
                    total += result3;

                    label11.Text = result3.ToString("F2") + "€";
                }
                else
                {
                    label11.Text = "Incorrect Value!";
                }
                label12.Text = total.ToString("F2") + "€";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
