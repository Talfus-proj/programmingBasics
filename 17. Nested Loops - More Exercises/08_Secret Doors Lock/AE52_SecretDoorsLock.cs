using System;

namespace AE52_SecretDoorsLock
{
    class AE52_SecretDoorsLock
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            for (int i = 1; i < a + 1; i++)
            {
                for (int j = 2; j < b + 1; j++)
                {
                    if (j == 2 || j == 3 || j == 5 || j == 7)
                    {
                        for (int k = 1; k < c + 1; k++)
                        {
                            if (k % 2 == 0 && i % 2 == 0)
                            {
                                Console.WriteLine($"{i} {j} {k}");
                                
                            }
                           
                        }
                        
                    }
                }
            }
        }
    }
}
