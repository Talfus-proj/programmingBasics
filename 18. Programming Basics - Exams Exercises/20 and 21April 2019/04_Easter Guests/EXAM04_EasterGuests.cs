using System;

namespace EXAM04_EasterGuests
{
    class EXAM04_EasterGuests
    {
        static void Main()
        {
            const double KOZUNAK = 4;
            const double EGG = 0.45;

            double numberOfGuests = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double numberRequiredKozunak = (numberOfGuests / 3);
            double numberRequiredEgg = numberOfGuests * 2;

            double priceOfKozunak = Math.Ceiling(numberRequiredKozunak) * KOZUNAK;
            double priceOfEgg = numberRequiredEgg * EGG;

            double totalBudget = priceOfKozunak + priceOfEgg;

            if (budget >= totalBudget)
            {
                Console.WriteLine($"Lyubo bought {Math.Ceiling(numberRequiredKozunak)} Easter bread and {numberRequiredEgg} eggs.");
                Console.WriteLine($"He has {(budget - totalBudget):f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalBudget - budget:f2} lv. more.");
            }
        }
    }
}
