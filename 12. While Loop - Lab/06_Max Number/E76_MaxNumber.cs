using System;

namespace E76_MaxNumber
{
    class E76_MaxNumber
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int max = int.MinValue;

            while (input != "Stop")
            {
                int number = int.Parse(input);

                if (number > max)
                {
                    max = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
