using System;

namespace AE29_MultiplyBy2
{
    class AE29_MultiplyBy2
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            

            while (number >= 0)
            {
                number *= 2;
                Console.WriteLine($"Result: {number:f2}");
                number = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("Negative number!");

        }
    }
}
