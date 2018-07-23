using System;
using System.Collections.Generic;
using System.Text;

namespace lemonade_stand
{
    class LemonadeStandCorp
    {
        public string Name { get; set; }
        public List<LemonadeStand> Locations { get; set; }

        public decimal GetTotalRevenue()
        {
            decimal grandTotal = 0;
            foreach(LemonadeStand location in Locations)
            {
                grandTotal += location.TotalRevenue();
            }

            return grandTotal;
        }
    }
}
