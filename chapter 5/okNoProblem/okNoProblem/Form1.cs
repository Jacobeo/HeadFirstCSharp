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
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty(5, false, true); //{ NumberOfPeople = 5 };
            dinnerParty.CaLculateCostOfDecorations(IsFancy.Checked);
            dinnerParty.SetHealthyOption(IsHealth.Checked);
            DisplayDinnerPartyCost();

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
    }
}
