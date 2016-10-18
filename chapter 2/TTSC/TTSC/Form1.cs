using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTSC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this is a comment
            string name = "Quinten";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;

            MessageBox.Show("Name is" + name
                + "\nx is " + x
                + "\nd is " + d); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show("X must be 10");
            }
            else
            {
                MessageBox.Show("X must be 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int someValue = 4;
            string name = "Bobo Jr.";

            if ((someValue == 3) && (name == "Joe"))
            {
                MessageBox.Show("Xis 3 and name is Joe");
            }

            MessageBox.Show("xXx");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;

            while (count < 10)
            {
                count = count + 1;
            }

            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }

            MessageBox.Show(count.ToString());
        }
    }
}
