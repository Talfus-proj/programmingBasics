using System;

namespace E55_NumbersNto1
{
    class E55_NumbersNto1
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = number ; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
