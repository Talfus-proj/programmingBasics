using System;

namespace E41_InvalidNumber
{
    class E41_InvalidNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0 || number >= 100 && number <= 200)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
