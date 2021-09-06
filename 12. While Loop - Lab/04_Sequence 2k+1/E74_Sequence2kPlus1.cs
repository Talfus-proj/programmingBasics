using System;

namespace E74_Sequence2k_1
{
    class E74_Sequence2kPlus1
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int k = 1;

            while (k <= number)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}
