using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer
{
    class Farmer
    {        
        private int feedMultiplier;
        public int FeetMultiplier { get { return feedMultiplier; } }
        private int numberOfCows;
        //read-only-propery
        public int BagsOfFeed { get; private set; }


        //Constructor
        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }

        //property 
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
