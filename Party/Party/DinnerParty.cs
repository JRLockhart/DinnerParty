using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party
{
    class DinnerParty : Party
    {
       
        public bool HealtyOptions { get; set; }
        
        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealtyOptions = healthyOption;
        }
              

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeverages;
            if (HealtyOptions)
            {
                costOfBeverages = 5.00M;
            }
            else
            {
                costOfBeverages = 20.00M;
            }
            return costOfBeverages;
        }
        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealtyOptions)
                {
                    totalCost *= .95M;
                }
                return totalCost;
                
            }
        }
    }
}
