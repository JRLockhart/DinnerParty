using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople;
        public decimal CostOfBeveragePerPerson;
        public decimal CostOfDecorations;
        
        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragePerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragePerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecoration(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 15.00M;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations +
                ((CostOfBeveragePerPerson + CostOfFoodPerPerson) + NumberOfPeople);
            if (healthyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }
            
        }
    }
}
