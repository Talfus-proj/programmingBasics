using System;

namespace E16_FruitMarket
{
    class E16_FruitMarket
    {
        static void Main()
        {
            double priceOfStrawberries = double.Parse(Console.ReadLine());
            double amountOfBananas = double.Parse(Console.ReadLine());
            double amountOfOranges = double.Parse(Console.ReadLine());
            double amountOfRaspberries = double.Parse(Console.ReadLine());
            double amountOfStrawberries = double.Parse(Console.ReadLine());

            double priceOfRaspberries = priceOfStrawberries / 2;
            double priceOfOranges = priceOfRaspberries - (priceOfRaspberries * 0.4);
            double priceOfBananas = priceOfRaspberries - (priceOfRaspberries * 0.8);
            

            double sumOfRaspberries = amountOfRaspberries * priceOfRaspberries;
            double sumOfOranges = amountOfOranges * priceOfOranges;
            double sumOfBananas = amountOfBananas * priceOfBananas;
            double sumOfStrawberries = priceOfStrawberries * amountOfStrawberries;

            double totalSum = sumOfRaspberries + sumOfOranges + sumOfBananas + sumOfStrawberries;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
