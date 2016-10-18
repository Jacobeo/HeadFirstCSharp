using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okNoProblem
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, IsHealth.Checked, IsFancy.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numericUpDown2.Value, isFancyBirthday.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();

        }


        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(IsHealth.Checked);
            CostLabel.Text = Cost.ToString("c");
        }

        private void IsFancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CaLculateCostOfDecorations(IsFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void IsHealth_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(IsHealth.Checked);
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDown2.Value;
            DisplayBirthdayPartyCost();
        }

        private void isFancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(isFancyBirthday.Checked);
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();

        }

        private void DisplayBirthdayPartyCost()
        {
            cakeWriting.Text = birthdayParty.CakeWriting;
            decimal cost = birthdayParty.CalculateCost();
            textBox2.Text = cost.ToString("c");
        }
    }

}
