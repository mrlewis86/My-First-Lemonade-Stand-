using System;
using System.Collections.Generic;
using System.Text;

namespace lemonade_stand
{
    class LemonadeStandCorp
    {
        public string Name { get; set; }
        public List<LemonadeStand> Locations { get; set; } = new List<LemonadeStand>();

        public decimal GetTotalRevenue()
        {
            decimal grandTotal = 0;
            foreach(LemonadeStand location in Locations)
            {
                grandTotal += location.TotalRevenue();
            }

            return grandTotal;

        }
        public decimal GetTotalExpenses()
        {
            decimal grandTotal = 0;
            foreach(LemonadeStand location in Locations)
            {
                grandTotal += location.TotalExpenses();
            }

            return grandTotal;
        }
        public decimal GetTotalProfit()
        {
            decimal grandTotal = 0;
            foreach(LemonadeStand location in Locations)
            {
                grandTotal += location.TotalProfit();
            }


            return grandTotal;
        }


    }
}
