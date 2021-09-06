using System;

namespace E31_WorldSwimmingRecord
{
    class E31_WorldSwimmingRecord
    {
        static void Main()
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double distanceInSeconds = distance * timeInSeconds;

            double delay = Math.Floor(distance / 15) * 12.5;

            double finalTime = distanceInSeconds + delay;

            if (finalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            }
            else
            {
                double timeNeeded = finalTime - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {timeNeeded:f2} seconds slower.");
            }
        }
    }
}
