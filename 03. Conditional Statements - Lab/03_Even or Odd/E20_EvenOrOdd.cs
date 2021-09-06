using System;

namespace E20_EvenOrOdd
{
    class E20_EvenOrOdd
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
