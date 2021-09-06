using System;

namespace AE17_FlowerShop
{
    class AE17_FlowerShop
    {
        static void Main()
        {
            const double MAGNOLIES = 3.25;
            const double ZUMBULS = 4;
            const double ROSES = 3.50;
            const double CACTUSES = 8;

            double numberOfMagnolies = double.Parse(Console.ReadLine());
            double numberOfZumbuls = double.Parse(Console.ReadLine());
            double numberOfRoses = double.Parse(Console.ReadLine());
            double numberOfCactuses = double.Parse(Console.ReadLine());
            double priceOfGift = double.Parse(Console.ReadLine());

            double totalSum = ((numberOfMagnolies * MAGNOLIES) + (numberOfZumbuls * ZUMBULS) + (numberOfRoses * ROSES) + (numberOfCactuses * CACTUSES));

            double taxes = totalSum - (totalSum * 0.05);

            if (priceOfGift <= taxes)
            {
                Console.WriteLine($"She is left with {Math.Floor(taxes - priceOfGift)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(priceOfGift - taxes)} leva.");
            }
        }
    }
}
