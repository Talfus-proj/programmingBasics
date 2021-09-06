using System;

namespace E37_NumberInRange
{
    class E37_NumberInRange
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());

            if (number != 0 && (number >= -100 && number <= 100))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
