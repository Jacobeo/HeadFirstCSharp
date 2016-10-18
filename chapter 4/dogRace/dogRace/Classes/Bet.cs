using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogRace
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;


        public String GetDescription()
        {
            string desc;
            if (Amount > 0)
            {
                desc = Bettor + "bets " + Amount + " on dog #" + Dog;
            }
            else
            {
                desc = Bettor + " hasn't placed a bet";
            }


                return desc;
        }

        public int PayOut(Winner)
        {
            if (Dog == Winner)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }

        }
    }
}
