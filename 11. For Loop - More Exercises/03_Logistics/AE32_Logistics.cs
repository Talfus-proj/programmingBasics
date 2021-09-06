using System;

namespace AE32_Logistics
{
    class AE32_Logistics
    {
        static void Main()
        {
            const double MICROBUS = 200;
            const double TRUCK = 175;
            const double TRAIN = 120;



            double numberOfWeightInput = double.Parse(Console.ReadLine());

            double totalWeight = 0;
            double priceForTon1 = 0;
            double priceForTon2 = 0;
            double priceForTon3 = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < numberOfWeightInput; i++)
            {
                double everyWeight = double.Parse(Console.ReadLine());

                if (everyWeight <= 3)
                {
                    totalWeight += everyWeight;
                    priceForTon1 += everyWeight;
                    p1 += everyWeight;
                }
                else if (everyWeight >= 4 && everyWeight <= 11 )
                {
                    totalWeight += everyWeight;
                    priceForTon2 += everyWeight;
                    p2 += everyWeight;
                }
                else if (everyWeight >= 12)
                {
                    totalWeight += everyWeight;
                    priceForTon3 += everyWeight;
                    p3 += everyWeight;
                }
            }

            double avarageTon = ((priceForTon1 * MICROBUS) + (priceForTon2 * TRUCK) + (priceForTon3 * TRAIN))/ totalWeight;


            double percentOne = (p1 / totalWeight) * 100;
            double percentTwo = (p2 / totalWeight) * 100;
            double percentThree = (p3 / totalWeight) * 100;

            Console.WriteLine($"{avarageTon:f2}");
            Console.WriteLine($"{percentOne:f2}%");
            Console.WriteLine($"{percentTwo:f2}%");
            Console.WriteLine($"{percentThree:f2}%");
        }
    }
}
