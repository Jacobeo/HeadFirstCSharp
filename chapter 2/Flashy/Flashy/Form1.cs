using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashy
    
{
    
    public partial class Form1 : Form
    {
        public bool fg = true;
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            if (button1.Text == "GO!") {
                // bool flag1 = true;
                fg = true;
                button1.Text = "STOP";
                //bool flag = true;
                while (Visible == true && fg == true)
                {
                  

                    for (int c = 0; c < 254 && Visible && fg == true; c++)
                    {
                        this.BackColor = Color.FromArgb(c, 255 - c, c);

                        Application.DoEvents();

                        System.Threading.Thread.Sleep(3);
                    }
                    for (int c = 254; c > 0 && Visible && fg == true; c--)
                    {
                        this.BackColor = Color.FromArgb(c, 255 - c, c);
                        Application.DoEvents();
                        
                        System.Threading.Thread.Sleep(3);
                    }
                }
            }
            else
            {
                button1.Text = "GO!";
                fg = false;
             //   MessageBox.Show(flag1.ToString());
                this.BackColor = SystemColors.Control;
                System.Threading.Thread.Sleep(300);
            }

        }
    }
}
