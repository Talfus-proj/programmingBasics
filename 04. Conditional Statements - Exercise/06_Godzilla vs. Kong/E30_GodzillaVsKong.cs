using System;

namespace E30_GodzillaVsKong
{
    class E30_GodzillaVsKong
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfPersons = int.Parse(Console.ReadLine());
            double priceClothesForPersons = double.Parse(Console.ReadLine());

            double decorationPrice = budget * 0.10;
            double totalPriceForClothes = numberOfPersons * priceClothesForPersons;

            if (numberOfPersons > 150)
            {
                double discount = totalPriceForClothes * 0.10;
                totalPriceForClothes -= discount;
            }

            double totalMoney = decorationPrice + totalPriceForClothes;

            if (totalMoney > budget)
            {
                double neededMoney = totalMoney - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }
            else
            {
                double moneyLeft = budget - totalMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
