using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okNoProblem
{
    class DinnerParty
    {
        //Constructor
        public DinnerParty( int numberOfPeople, bool isHealthy, bool isFancy)
        {
            NumberOfPeople = numberOfPeople;
            this.isFancy = isFancy;
            SetHealthyOption(isHealthy);
            CaLculateCostOfDecorations(isFancy);           
        }

        public decimal CostOfBeveragesPerPerson;      
        public decimal CostOfDecoration = 0;
        public const int CostOfFoodPerPerson = 25;
        private bool isFancy;
        private bool isHealthy;

        //numberOfPeople property
        private int numberOfPeople;
        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CaLculateCostOfDecorations(isFancy);
            }
        }

        public void SetHealthyOption(bool IsHealthy)
        {        
            if (IsHealthy)
            {
                CostOfBeveragesPerPerson = 5.0M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.0M;
            }
        }

        public void CaLculateCostOfDecorations(bool fancyDecor)
        {
            isFancy = fancyDecor;
            if (isFancy)
            {
                CostOfDecoration = (NumberOfPeople * 15.0M) + 50.0M;
            }
            else
            {
                CostOfDecoration = (NumberOfPeople * 7.50M) + 30.0M;
            }
        }

        public decimal CalculateCost(bool IsHealth)
        {
            decimal TotalCost = CostOfDecoration + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);           

            if (IsHealth)
            {
                return TotalCost * 0.95M;
            }
            else
            {
                return TotalCost;
            }
        }
    }
}
