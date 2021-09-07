using System;

namespace EXAM16_Skeleton
{
    class EXAM16_Skeleton
    {
        static void Main()
        {
            double controlMinutes = double.Parse(Console.ReadLine());
            double controlSeconds = double.Parse(Console.ReadLine());
            double lengthInMeters = double.Parse(Console.ReadLine());
            double secForOneHundred = double.Parse(Console.ReadLine());

            double calculateControl = (controlMinutes * 60) + controlSeconds;
            double timeReduce = lengthInMeters / 120;
            double speedReduce = timeReduce * 2.5;

            double marinTime = (lengthInMeters / 100) * secForOneHundred - speedReduce;

            if (calculateControl >= marinTime)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {marinTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {(marinTime - calculateControl):f3} second slower.");
            }
        }
    }
}
