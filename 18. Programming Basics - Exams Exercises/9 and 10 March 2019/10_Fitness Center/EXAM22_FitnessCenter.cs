using System;

namespace EXAM22_FitnessCenter
{
    class EXAM22_FitnessCenter
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            double peopleWorking = 0;
            double peopleDrinking = 0;
            int counterBack = 0;
            int counterChest = 0;
            int counterLegs = 0;
            int counterAbs = 0;
            int counterShake = 0;
            int counterBar = 0;

            for (int i = 1; i <= input; i++)
            {
                string activity = Console.ReadLine();

                switch (activity)
                {
                    case "Back":
                        counterBack++;
                        peopleWorking++;
                        break;
                    case "Chest":
                        counterChest++;
                        peopleWorking++;
                        break;
                    case "Legs":
                        counterLegs++;
                        peopleWorking++;
                        break;
                    case "Abs":
                        counterAbs++;
                        peopleWorking++;
                        break;
                    case "Protein shake":
                        counterShake++;
                        peopleDrinking++;
                        break;
                    case "Protein bar":
                        counterBar++;
                        peopleDrinking++;
                        break;
                }
            }

            double percentWorkingOut = (peopleWorking / input) * 100;
            double percentDrinking = (peopleDrinking / input) * 100;

            Console.WriteLine($"{counterBack} - back");
            Console.WriteLine($"{counterChest} - chest");
            Console.WriteLine($"{counterLegs} - legs");
            Console.WriteLine($"{counterAbs} - abs");
            Console.WriteLine($"{counterShake} - protein shake");
            Console.WriteLine($"{counterBar} - protein bar");
            Console.WriteLine($"{percentWorkingOut:f2}% - work out");
            Console.WriteLine($"{percentDrinking:f2}% - protein");

        }
    }
}
