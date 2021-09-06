using System;

namespace AE57_PrimePairs
{
    class AE57_PrimePairs
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int maxA = a + c;
            int maxB = b + d;
            int counterA = 0;
            int counterB = 0;
            for (int i = a; i <= maxA; i++)
            {
                counterA = 0;
                for (int k = 1; k <= i; k++)
                {
                    if (i % k == 0)
                    {
                        counterA++;
                    }
                }
                if (counterA == 2)
                {
                    for (int j = b; j <= maxB; j++)
                    {
                        counterB = 0;
                        for (int l = 1; l <= j; l++)
                        {
                            if (j % l == 0)
                            {
                                counterB++;
                            }
                        }
                        if (counterB == 2)
                        {
                            Console.WriteLine($"{i}{j}");
                        }
                    }
                }
            }
        }
    }
}
