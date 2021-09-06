using System;

namespace E87_MultiplicationTable
{
    class E87_MultiplicationTable
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    double multiply = i * j;

                    Console.WriteLine($"{i} * {j} = {multiply}");
                }
            }
        }
    }
}
