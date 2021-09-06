using System;

namespace E69_DivideWithoutRemainder
{
    class E69_DivideWithoutRemainder
    {
        static void Main()
        {
            double numberInput = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < numberInput; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1++;
                }
                if (number % 3 == 0)
                {
                    p2++;
                }
                if (number % 4 == 0)
                {
                    p3++;
                }
            }

            double percentOne = (p1 / numberInput) * 100;
            double percentTwo = (p2 / numberInput) * 100;
            double percentThree = (p3 / numberInput) * 100;

            Console.WriteLine($"{percentOne:f2}%");
            Console.WriteLine($"{percentTwo:f2}%");
            Console.WriteLine($"{percentThree:f2}%");

        }
    }
}
