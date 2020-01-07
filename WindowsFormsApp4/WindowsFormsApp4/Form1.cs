using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void firstSemesterBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondSemesterBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void thirdSemesterBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double averageFirstSemester = Convert.ToDouble(firstSemesterBx.Text);
            double averageSecondSemester = Convert.ToDouble(secondSemesterBx.Text);
            double averageThirdSemester = Convert.ToDouble(thirdSemesterBx.Text);
            double totalAverage = (averageFirstSemester + averageSecondSemester + averageThirdSemester) / 3;
            resultBx.Text = "Total average is: " + totalAverage;
        }

        private void resultBx_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
