using System;

namespace AE04_VegetableMarket
{
    class AE04_VegetableMarket
    {
        static void Main()
        {
            double priceForVegetablesPerKilogram = double.Parse(Console.ReadLine());
            double priceForFruitsPerKilogram = double.Parse(Console.ReadLine());
            double totalKilogramsForVegetables = double.Parse(Console.ReadLine());
            double totalKilogramsForFruits = double.Parse(Console.ReadLine());

            double totalFruitsAndVegetables = (priceForVegetablesPerKilogram * totalKilogramsForVegetables) + (priceForFruitsPerKilogram * totalKilogramsForFruits);

            double convertToEuro = totalFruitsAndVegetables / 1.94;

            Console.WriteLine($"{convertToEuro:f2}");
        }
    }
}
