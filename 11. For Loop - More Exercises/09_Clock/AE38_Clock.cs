using System;

namespace AE38_Clock
{
    class AE38_Clock
    {
        static void Main()
        {
            for (int i = 0; i < 24; i++)
            {
                for (int m = 0; m < 60; m++)
                {
                    Console.WriteLine($"{i} : {m}");
                }
            }
        }
    }
}
