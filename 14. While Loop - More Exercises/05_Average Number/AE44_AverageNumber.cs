using System;

namespace AE44_AverageNumber
{
    class AE44_AverageNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double readNumbers = double.Parse(Console.ReadLine());
                sum += readNumbers;
            }

            Console.WriteLine($"{(sum / n):f2}");
        }
    }
}
