using System;

namespace AE12_SleepyTomCat
{
    class AE12_SleepyTomCat
    {
        static void Main()
        {
            //5725 мин = 95 часа и 25 мин

            double numberOfDaysOff = double.Parse(Console.ReadLine());

            double playNorm = 30000;

            double restDays = numberOfDaysOff * 127;
            double workDays = (365 - numberOfDaysOff) *63;

            double playTime = workDays + restDays;

            double differentInNorm = Math.Abs(playNorm - playTime);

            double hours = differentInNorm / 60;
            double minutes = differentInNorm % 60;

            if (playNorm >= playTime)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Floor(hours)} hours and {minutes} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Floor(hours)} hours and {minutes} minutes more for play");
            }

        }
    }
}
