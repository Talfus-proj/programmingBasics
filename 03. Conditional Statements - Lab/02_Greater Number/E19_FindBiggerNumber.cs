using System;

namespace E19_FindBiggerNumber
{
    class E19_FindBiggerNumber
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number2);
            }
        }
    }
}
