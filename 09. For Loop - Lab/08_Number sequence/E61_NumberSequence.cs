using System;

namespace E61_NumberSequence
{
    class E61_NumberSequence
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int tempN = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < number; i++)
            {
                tempN = int.Parse(Console.ReadLine());
                if (tempN > max) 
                { 
                    max = tempN; 
                }
                if (tempN < min) 
                { 
                    min = tempN; 
                }
            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
