using System;

namespace E73_SumNumbers
{
    class E73_SumNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < n)
            {
                int currentSum = int.Parse(Console.ReadLine());
                sum += currentSum;

            }
            Console.WriteLine(sum);
        }
    }
}
