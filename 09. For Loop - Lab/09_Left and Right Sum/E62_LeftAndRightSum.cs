using System;

namespace E62_LeftAndRightSum
{
    class E62_LeftAndRightSum
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sumOne = 0;
            int sumTwo = 0;

            for (int i = 0; i < num; i++)
            {
                sumOne += int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < num; i++)
            {
                sumTwo += int.Parse(Console.ReadLine());
            }

            int diff = Math.Abs(sumOne - sumTwo);

            if (sumOne == sumTwo)
            {
                Console.WriteLine($"Yes, sum = {sumOne}");
            }
            else
            {
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
