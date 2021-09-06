using System;

namespace E57_EvenPowersof2
{
    class E57_EvenPowersof2
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i += 2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}

