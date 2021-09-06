using System;

namespace AE39_Clock2
{
    class AE39_Clock2
    {
        static void Main()
        {
            for (int i = 0; i < 24; i++)
            {
                for (int m = 0; m < 60; m++)
                {
                    for (int s = 0; s < 60; s++)
                    {
                        Console.WriteLine($"{i} : {m} : {s}");
                    }
                }
            }

            
        }
    }
}
