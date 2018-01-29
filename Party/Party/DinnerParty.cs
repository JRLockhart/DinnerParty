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
        int numberOfPeople;
        
        public decimal CostOfBeveragePerPerson;
        public decimal CostOfDecorations;
        
        public void SetPartyOptions(int people, bool fancy)
        {
            numberOfPeople = people;
            CalculateCostOfDecoration(fancy);
        }

        public int GetNumberOfPeople()
        {
            return numberOfPeople;
        }
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
                CostOfDecorations = (numberOfPeople * 15.00M) + 50.00M;
            }
            else
            {
                CostOfDecorations = (numberOfPeople * 7.50M) + 15.00M;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations +
                ((CostOfBeveragePerPerson + CostOfFoodPerPerson) * numberOfPeople);
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
