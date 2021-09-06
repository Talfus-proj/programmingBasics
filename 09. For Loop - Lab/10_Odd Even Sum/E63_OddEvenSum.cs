using System;

namespace E63_OddEvenSum
{
    class E63_OddEvenSum
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sumOne = 0;
            int sumTwo = 0;

            for (int i = 1; i <= num; i++)
            {
                int numTwo = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumOne += numTwo;
                }
                else
                {
                    sumTwo += numTwo;
                }
            }

            int diff = Math.Abs(sumOne - sumTwo);

            if (sumOne == sumTwo)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sumOne}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
