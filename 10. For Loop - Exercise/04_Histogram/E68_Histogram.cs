using System;

namespace E68_Histogram
{
    class Program
    {
        static void Main()
        {
            double numberInput = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < numberInput; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1++;
                }
                else if (number >= 200 && number <= 399)
                {
                    p2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    p3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4++;
                }
                else if (number >= 800)
                {
                    p5++;
                }

            }

            double percentOne = (p1 / numberInput) * 100;
            double percentTwo = (p2 / numberInput) * 100;
            double percentThree = (p3 / numberInput) * 100;
            double percentFour = (p4 / numberInput) * 100;
            double percentFive = (p5 / numberInput) * 100;

            Console.WriteLine($"{percentOne:f2}%");
            Console.WriteLine($"{percentTwo:f2}%");
            Console.WriteLine($"{percentThree:f2}%");
            Console.WriteLine($"{percentFour:f2}%");
            Console.WriteLine($"{percentFive:f2}%");
        }
    }
}
