using System;

namespace EXAM08_EasterShop
{
    class EXAM08_EasterShop
    {
        static void Main()
        {
            double eggsAmount = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double soldEggs = 0;

            while (input != "Close")
            {
                if (input == "Fill")
                {
                    double toFill = double.Parse(Console.ReadLine());
                    eggsAmount += toFill;
                }

                if (input == "Buy")
                {
                    double toBuy = double.Parse(Console.ReadLine());
                    if (toBuy <= eggsAmount)
                    {
                        eggsAmount -= toBuy;
                        soldEggs += toBuy;
                    }
                    else
                    {
                        Console.WriteLine($"Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggsAmount}.");
                    }
                }

                input = Console.ReadLine();
            }
            if ("Close" == input)
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
            }
        }
    }
}
