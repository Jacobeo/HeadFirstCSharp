using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mileageCalc
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;

        double milesTraveled;
        double reimburseRate = .39;
        double amounOwed;

        public Form1()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;

            if (startingMileage >= endingMileage)
            {
                MessageBox.Show("Starting value must be less then ending value", "Cannot calculate");
            }
            else
            {
                milesTraveled = endingMileage -= startingMileage;
                amounOwed = milesTraveled *= reimburseRate;

                label4.Text = "$" + amounOwed;

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + "miles");
        }
    }
}
