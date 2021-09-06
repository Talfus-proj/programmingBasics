using System;

namespace AE11_PipesInPool_ConditionalStatements_MoreExercises
{
    class AE11_PipesInPool_ConditionalStatements_MoreExercises
    {
        static void Main()
        {
            double poolValumeInLitre = double.Parse(Console.ReadLine());
            double firstPipePerHour = double.Parse(Console.ReadLine());
            double secondPipePerHour = double.Parse(Console.ReadLine());
            double numberHoursWorkerIsAbscent = double.Parse(Console.ReadLine());

            double p1 = firstPipePerHour * numberHoursWorkerIsAbscent;
            double p2 = secondPipePerHour * numberHoursWorkerIsAbscent;

            double checkFirstPipe = (p1 / (p1 + p2)) * 100;
            double checkSecondPipe = (p2 / (p1 + p2)) * 100;

            double totalAmount = ((p1 + p2) / poolValumeInLitre) * 100;


            if (p1 + p2 <= poolValumeInLitre)
            {
                Console.WriteLine($"The pool is {totalAmount:f2}% full. Pipe 1: {checkFirstPipe:f2}%. Pipe 2: {checkSecondPipe:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {numberHoursWorkerIsAbscent} hours the pool overflows with {((p1 + p2)- poolValumeInLitre)} liters.");
            }
        }
    }
}
