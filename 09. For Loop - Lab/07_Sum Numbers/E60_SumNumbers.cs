using System;

namespace E60_SumNumbers
{
    class E60_SumNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 0; i < number; i++)
            {
                total += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(total);
        }
    }
}
