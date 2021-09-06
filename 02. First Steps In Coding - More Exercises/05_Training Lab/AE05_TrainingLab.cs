using System;

namespace AE05_TrainingLab
{
    class AE05_TrainingLab
    {
        static void Main()
        {
            double lengthInMeters = double.Parse(Console.ReadLine());
            double widthInMeters = double.Parse(Console.ReadLine());

            double minusCorridor = (widthInMeters * 100) - 100;

            double deskOnRow = minusCorridor / 70;

            double howManyRows = (lengthInMeters * 100) / 120;

            double resultFormatA = Math.Truncate(howManyRows);
            double resultFormatB = Math.Truncate(deskOnRow);

            Console.WriteLine((resultFormatA * resultFormatB)-3);
        }
    }
}
