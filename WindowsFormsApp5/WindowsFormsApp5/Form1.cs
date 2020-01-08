using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(textBox1.Text);
            double height = Convert.ToDouble(textBox2.Text);
            double kmi = weight / (Math.Pow(height, 2));

            if (weight > 0)
            {
                if (kmi < 18.5 && kmi > 0)
                {
                    textBox3.Text = "KMI: " + kmi + ". " + "Your body mass is too low";
                }
                else if (kmi >= 18.5 && kmi <= 25)
                {
                    textBox3.Text = "KMI: " + kmi + ". " + "Your body mass is perfect";
                }
                else if (kmi >= 25 && kmi <= 30)
                {
                    textBox3.Text = "KMI: " + kmi + ". " + "You have some over-weigth";
                }
                else if (kmi > 30)
                {
                    textBox3.Text = "KMI: " + kmi + ". " + "You are seriously overweighted. See a doctor.";
                }
            }
            else
            {
                textBox3.Text = "Negative weigth is not allowed. Please use positive numbers only.";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
