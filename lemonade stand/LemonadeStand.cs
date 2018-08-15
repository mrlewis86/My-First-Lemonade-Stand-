using System;
using System.Collections.Generic;
using System.Text;

namespace lemonade_stand
{
    class LemonadeStand
    {
        public string Name { get; set; }
        public int NumberofCups { get; set; }
        public decimal PricePerCup { get; set; }
        public decimal CostPerCup { get; set; }

        public decimal TotalRevenue()
        {
            return NumberofCups * PricePerCup;
        }

        public decimal TotalExpenses()
        {
            return NumberofCups * CostPerCup;
        }

        public decimal TotalProfit()
        {
            return TotalRevenue() - TotalExpenses();
        }
    }
}
