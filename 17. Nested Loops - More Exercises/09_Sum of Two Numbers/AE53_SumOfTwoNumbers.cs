using System;

namespace AE53_SumOfTwoNumbers
{
    class AE53_SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int startOfInterval = int.Parse(Console.ReadLine());
            int endOfInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool isFound = false;

            for (int i = startOfInterval; i <= endOfInterval; i++)
            {
                for (int b = startOfInterval; b <= endOfInterval; b++)
                {
                    combinations++;
                    if (i + b == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {b} = {magicNumber})");
                        return;
                    }

                }
            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
        }
    }
}
