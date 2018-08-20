using System;

namespace lemonade_stand
{
    class Program
    {
        static void Main(string[] args)
        {
            LemonadeStandCorp corp = new LemonadeStandCorp();

            Console.WriteLine("Hey, how many lemonade stands do you want?");
            int AmountofStands = Int32.Parse(Console.ReadLine());


            for (int i = 0; i < AmountofStands; i++)
            {
                LemonadeStand lemonadeStand = new LemonadeStand();
                corp.Locations.Add(lemonadeStand);
                


                Console.WriteLine("Hey buddy, nice lemonade stand. Whats the name of it?");
                Console.WriteLine();
                lemonadeStand.Name = Console.ReadLine();


                Console.WriteLine();

                

                Console.WriteLine("How many cups do you plan to sell?");
                Console.WriteLine();
                lemonadeStand.NumberofCups = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Ok, Ok. Well, how much does each cup cost?");
                Console.WriteLine();
                lemonadeStand.PricePerCup = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Each cup will cost you " + lemonadeStand.PricePerCup);
                Console.WriteLine();

                Console.WriteLine("Well, how much did you pay for each cup?");
                Console.WriteLine();
                lemonadeStand.CostPerCup = decimal.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Each cup cost me " + lemonadeStand.CostPerCup + " for sugar, water and lemons");
                Console.WriteLine();

                decimal totalRevenue = lemonadeStand.TotalRevenue();
                decimal totalExpenses = lemonadeStand.NumberofCups * lemonadeStand.CostPerCup;
                decimal totalProfit = totalRevenue - totalExpenses;

                Console.WriteLine("So my total revenue will be " + totalRevenue);
                Console.WriteLine("My total expenses will be " + totalExpenses);
                Console.WriteLine("And my total profit will be " + totalProfit);

                Console.ReadLine();
            }
            //interpolation
            Console.WriteLine($"Your grand total will be {corp.GetTotalRevenue()}");
            Console.WriteLine("Your total expenses will be " + corp.GetTotalExpenses());
            Console.WriteLine("Your total profit will be " + corp.GetTotalProfit());








            Console.ReadLine();
        }

        
    }
}
