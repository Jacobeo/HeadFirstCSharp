using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dogRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Guy[] guys = new Guy[3];
            guys[0] = new Guy() { Name = "Joe" };
            guys[1] = new Guy() { Name = "Bob" };
            guys[2] = new Guy() { Name = "Al" };


            greyHound[] greyHounds = new greyHound[4];
            greyHounds[0] = new greyHound();
            greyHounds[1] = new greyHound();
            greyHounds[2] = new greyHound();
            greyHounds[3] = new greyHound();


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bet bet = new Bet { Amount = (int)numericUpDown1.Value }; 
            }
    }
}
