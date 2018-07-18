using System;

namespace lemonade_stand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey buddy, nice lemonade stand. Whats the name of it?");
            Console.WriteLine();

            string userResponse = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("How many cups do you plan to sell?");
            string NumberOfCups = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Ok, Ok. Well, how much does each cup cost?");
            int CostOfCups = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Pay me "+ CostOfCups + " for lemonade");
            Console.WriteLine();

            Console.WriteLine("Well, how much did you pay for each cup?");
            int PricePerCup = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ill spend " + PricePerCup + "for sugar, water, and crap");
            Console.WriteLine();






            Console.ReadLine();
        }

        
    }
}
