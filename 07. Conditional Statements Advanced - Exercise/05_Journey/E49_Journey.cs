using System;

namespace E49_Journey
{
    class E49_Journey
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double minusBudget = 0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    minusBudget = budget * 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {(budget - minusBudget):f2}");
                }
                else if (season == "winter")
                {
                    minusBudget = budget * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {(budget - minusBudget):f2}");
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    minusBudget = budget * 0.60;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {(budget - minusBudget):f2}");
                }
                else if (season == "winter")
                {
                    minusBudget = budget * 0.20;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {(budget - minusBudget):f2}");
                }
            }

            else if (budget > 1000)
            {
                    minusBudget = budget * 0.90;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {minusBudget:f2}");
            }
        }
    }
}
