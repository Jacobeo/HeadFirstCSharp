﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashExchange
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();
            joe = new Guy() { Cash = 50, Name = "Joe" };
          //  joe.Name = "Joe";
           // joe.Cash = 50;

            bob = new Guy();
            bob.Name = "Bob";
            bob.Cash = 100;

            UpdateForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $ " + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $ " + bob.Cash;
            bankCashLabel.Text = "The bank has $ " + bank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {            
                joe.GiveCash(10);
                bob.ReceiveCash(10);
                UpdateForm();
            
        }
        
        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            bob.GiveCash(5);
            joe.ReceiveCash(5);
            UpdateForm();
        }

        private void bobsCashLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
