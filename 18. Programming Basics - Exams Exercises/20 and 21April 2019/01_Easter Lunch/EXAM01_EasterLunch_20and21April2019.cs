using System;

namespace EXAM01_EasterLunch_20and21April2019
{
    class EXAM01_EasterLunch_20and21April2019
    {
        static void Main()
        {
            double kozunak = 3.20;
            double eggs = 4.35;
            double kurabii = 5.40;
            double eggPaint = 0.15;

            int numberKozunak = int.Parse(Console.ReadLine());
            int numberEggs = int.Parse(Console.ReadLine());
            int numberKurabii = int.Parse(Console.ReadLine());

            double num1 = numberKozunak * kozunak;
            double num2 = numberEggs * eggs;
            double num3 = numberKurabii * kurabii;
            double num4 = numberEggs * 12 * 0.15;

            double totalSum = num1 + num2 + num3 + num4;

            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
