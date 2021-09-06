using System;

namespace AE40_Dishwasher_While_Loop_MoreExercises
{
    class AE40_Dishwasher_While_Loop_MoreExercises
    {
        static void Main()
        {
            const int DETERGENT = 750;
            const int DISHES = 5;
            const int POT = 15;

            int bottlesRequired = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();


            int totalDetergentAmount = bottlesRequired * DETERGENT;

            int dishes = 0;
            int pots = 0;
            int timesWashed = 0;

            while (input != "End")
            {
                int thingsToWash = int.Parse(input);
                timesWashed++;
                
                if (timesWashed % 3 == 0)
                {
                    totalDetergentAmount -= thingsToWash * POT;
                    pots += thingsToWash;
                }
                else
                {
                    totalDetergentAmount -= thingsToWash * DISHES;
                    dishes += thingsToWash;
                }

                 if (totalDetergentAmount < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(totalDetergentAmount)} ml. more necessary!");
                    return;
                }


                input = Console.ReadLine();
            }

                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {totalDetergentAmount} ml.");
            
           
        }
    }
}
