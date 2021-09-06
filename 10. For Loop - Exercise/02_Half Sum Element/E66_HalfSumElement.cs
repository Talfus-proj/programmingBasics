using System;

namespace E66_HalfSumElement
{
    class E66_HalfSumElement
    {
        static void Main()
        {
            int numbersInput = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;

            for (int i = 0; i < numbersInput; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }

            int sumWithoutMax = sum - maxNumber;

            if (sumWithoutMax == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWithoutMax}");
            }
            else
            {
                int diff = Math.Abs(maxNumber - sumWithoutMax);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
