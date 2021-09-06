using System;

namespace AE13_Harvest
{
    class AE13_Harvest
    {
        static void Main()
        {
            int areaHarvestX = int.Parse(Console.ReadLine());
            double grapesForSquareMeterY = double.Parse(Console.ReadLine());
            int requiredLitreWines = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());

            double totalGrapes = areaHarvestX * grapesForSquareMeterY;
            double wine = (0.4 * totalGrapes) / 2.5;

            double litreRemaining = wine - requiredLitreWines;
            double litrePerPerson = litreRemaining / numberOfWorkers;

            if (requiredLitreWines <= wine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(litreRemaining)} liters left -> {Math.Ceiling(litrePerPerson)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(requiredLitreWines - wine)} liters wine needed.");
            }
        }
    }
}
