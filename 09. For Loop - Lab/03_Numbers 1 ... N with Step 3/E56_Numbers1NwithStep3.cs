using System;

namespace E56_Numbers1NwithStep3
{
    class E56_Numbers1NwithStep3
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i+= 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
