using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda;

        public Form1()
        {
            InitializeComponent();

            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Loyd", EarSize = 40 };

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant swap = lloyd;
            lloyd = lucinda;
            lucinda = swap;

            MessageBox.Show("Swaped!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* lloyd = lucinda;
             lloyd.EarSize = 4321;
             lloyd.WhoAmI();*/
            lloyd.TellMe("Hi", lucinda); 
            lloyd.SpeakTo(lucinda, "Hello");
        }
    }
}
