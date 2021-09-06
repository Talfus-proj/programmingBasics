using System;

namespace E65_NumbersEndingin7_ForLoop_Exercise
{
    class E65_NumbersEndingin7_ForLoop_Exercise
    {
        static void Main()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
