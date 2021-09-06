using System;

namespace E86_Clock_NestedLoops_Lab
{
    class E86_Clock_NestedLoops_Lab
    {
        static void Main()
        {
            for (int h = 0; h < 24; h++)
            {
                for (int min = 0; min < 60; min++)
                {
                    Console.WriteLine($"{h}:{min}");
                }
            }
        }
    }
}
