using System;

namespace E93_NumberPyramid_NestedLoops_Exercise
{
    class E93_NumberPyramid_NestedLoops_Exercise
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool isBigger = false;
            int current = 1;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
