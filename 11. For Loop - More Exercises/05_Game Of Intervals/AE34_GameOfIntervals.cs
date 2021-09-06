using System;

namespace AE34_GameOfIntervals
{
    class AE34_GameOfIntervals
    {
        static void Main()
        {
            int movesInGame = int.Parse(Console.ReadLine());
            double finalResult = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double p6 = 0;
            double totalMoves = 0;

            for (int i = 0; i < movesInGame; i++)
            {
                double everyMove = double.Parse(Console.ReadLine());

                if (everyMove >= 0 && everyMove <= 9)
                {
                    finalResult += everyMove * 0.20;
                    p1++;
                    totalMoves++;
                }
                else if (everyMove >= 10 && everyMove <= 19)
                {
                    finalResult += everyMove * 0.30;
                    p2++;
                    totalMoves++;

                }
                else if (everyMove >= 20 && everyMove <= 29)
                {
                    finalResult += everyMove * 0.40;
                    p3++;
                    totalMoves++;

                }
                else if (everyMove >= 30 && everyMove <= 39)
                {
                    finalResult += 50;
                    p4++;
                    totalMoves++;

                }
                else if (everyMove >= 40 && everyMove <= 50)
                {
                    finalResult += 100;
                    p5++;
                    totalMoves++;

                }
                else if (everyMove <= 0 || everyMove > 50)
                {
                    finalResult /= 2;
                    p6++;
                    totalMoves++;

                }
            }

            double percentOne = (p1 / totalMoves) * 100;
            double percentTwo = (p2 / totalMoves) * 100;
            double percentThree = (p3 / totalMoves) * 100;
            double percentFour = (p4 / totalMoves) * 100;
            double percentFive = (p5 / totalMoves) * 100;
            double percentSix = (p6 / totalMoves) * 100;

            Console.WriteLine($"{finalResult:f2}");
            Console.WriteLine($"From 0 to 9: {percentOne:f2}%");
            Console.WriteLine($"From 10 to 19: { percentTwo:f2}%");
            Console.WriteLine($"From 20 to 29: {percentThree:f2}%");
            Console.WriteLine($"From 30 to 39: {percentFour:f2}%");
            Console.WriteLine($"From 40 to 50: {percentFive:f2}%");
            Console.WriteLine($"Invalid numbers: {percentSix:f2}%");
        }
    }
}
