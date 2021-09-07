using System;

namespace EXAM10_EasterBake
{
    class EXAM10_EasterBake
    {
        static void Main()
        {
            int numberOfKozunaci = int.Parse(Console.ReadLine());
            int maxSugar = int.MinValue;
            int maxFlour = int.MinValue;
            double totalSugar = 0;
            double totalFlour = 0;

            for (int i = 1; i <= numberOfKozunaci; i++)
            {
                int sugar = int.Parse(Console.ReadLine());
                int flour = int.Parse(Console.ReadLine());

                totalSugar += sugar;
                totalFlour += flour;

                if (sugar >= maxSugar)
                {
                    maxSugar = sugar;
                }

                if (flour >= maxFlour)
                {
                    maxFlour = flour;
                }
            }

            totalSugar /= 950;
            totalFlour /= 750;

            Console.WriteLine($"Sugar: {Math.Ceiling(totalSugar)}");
            Console.WriteLine($"Flour: {Math.Ceiling(totalFlour)}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
