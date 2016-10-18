using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okNoProblem
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;
        public decimal CostOfDecoration = 0;
        private bool isFancy;
        public int CakeSize;
        private int numberOfPeople;

        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(isFancy);
                CalculateCakeSize();
                this.CakeWriting = cakeWriting;
            }
        }

        private string cakeWriting = "";
        public string CakeWriting
        {
            get { return this.cakeWriting; }
            set
            {
                int maxLenght;
                if (CakeSize == 8)
                {
                    maxLenght = 16;
                }
                else
                {
                    maxLenght = 40;
                }

                if (value.Length > maxLenght)
                {
                    MessageBox.Show("Too many letters for a " + CakeSize + "inch cake");
                    if (maxLenght > this.cakeWriting.Length)
                        maxLenght = this.cakeWriting.Length;
                    this.cakeWriting = cakeWriting.Substring(0, maxLenght);
                }
                else
                {
                    this.cakeWriting = value;
                }
            }
        }

        //Constructor
        public BirthdayParty(int numberOfPeople, bool isFancy, string cakeWriting)
        {
            this.numberOfPeople= numberOfPeople;            
            this.isFancy = isFancy;
            CalculateCakeSize();
            this.cakeWriting = cakeWriting;
            CalculateCostOfDecorations(isFancy);        
                
        }

        private void CalculateCakeSize()
        {
            if (numberOfPeople <= 4)
            {
                CakeSize = 8;
            }
            else
            {
                CakeSize = 16;                
            }
        }

        public decimal CalculateCost()
        {
            decimal TotalCost = CostOfDecoration + (CostOfFoodPerPerson * NumberOfPeople);
            decimal CakeCost;
            if (CakeSize == 8)
            {
                CakeCost = 40M + cakeWriting.Length * 0.25M;
            }
            else
            {
                CakeCost = 75M + cakeWriting.Length * 0.25M;
            }

            return TotalCost + CakeCost;
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            isFancy = fancy;
            if (fancy)
            {
                CostOfDecoration = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecoration = (NumberOfPeople * 7.5M) + 30M;
            }
        }


    }
}
