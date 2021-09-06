using System;

namespace AE43_NumbersDividedby3WithoutReminder
{
    class AE43_NumbersDividedby3WithoutReminder
    {
        static void Main()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
