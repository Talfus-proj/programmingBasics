using System;

namespace E77_MinNumber
{
    class E77_MinNumber
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int min = int.MaxValue;

            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number < min)
                {
                    min = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
