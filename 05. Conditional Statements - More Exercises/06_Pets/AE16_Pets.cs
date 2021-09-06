using System;

namespace AE16_Pets
{
    class AE16_Pets
    {
        static void Main()
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dogFoodForADay = double.Parse(Console.ReadLine());
            double catFoodForADay = double.Parse(Console.ReadLine());
            double turtleFoodForADay = double.Parse(Console.ReadLine());

            double requiredFoodForDog = numberOfDays * dogFoodForADay;
            double requiredFoodForCat = numberOfDays * catFoodForADay;

            double requiredFoodForTurtle = ( numberOfDays * turtleFoodForADay ) / 1000;

            double totalFood = requiredFoodForDog + requiredFoodForCat + requiredFoodForTurtle;

            if (foodLeft >= totalFood)
            {
                Console.WriteLine($"{Math.Floor(foodLeft-totalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood - foodLeft)} more kilos of food are needed.");
            }

        }
    }
}
