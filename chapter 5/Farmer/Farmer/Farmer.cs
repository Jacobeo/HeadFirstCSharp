using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer
{
    class Farmer
    {
        //public const int multiplier = 30;
        private int feedMultiplier;
        public int FeetMultiplier { get { return feedMultiplier; } }
        private int numberOfCows;
        public int BagsOfFeed { get; private set; }

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }

        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }

            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * feedMultiplier;
            }
        }
         
    }
}
