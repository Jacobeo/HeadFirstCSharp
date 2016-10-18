using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashExchange
{
    class Guy
    {
        public string Name;
        public int Cash;

        /// <summary>
        /// Give away cash, substractinc from the Cash label of the instance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("I don't have enough money to give you " + amount, Name + " says");
                return 0;    
            }
        }

        /// <summary>
        /// Recieve, adds to the Cash label of the instance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " isn't an amount I'll take", Name + " says.");
                return 0;
            }
        }
    }
}
