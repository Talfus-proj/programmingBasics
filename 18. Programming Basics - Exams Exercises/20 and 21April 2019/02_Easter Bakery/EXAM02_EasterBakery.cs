using System;

namespace EXAM02_EasterBakery
{
    class EXAM02_EasterBakery
    {
        static void Main()
        {
            double priceBrashno = double.Parse(Console.ReadLine());
            double kgBrashno = double.Parse(Console.ReadLine());
            double kgSugar = double.Parse(Console.ReadLine());
            double eggs = double.Parse(Console.ReadLine());
            double packageMaya = double.Parse(Console.ReadLine());

            double brashno = priceBrashno * kgBrashno;

            double sugar = (priceBrashno * 0.75) * kgSugar;


            double egg = (priceBrashno * 1.1) * eggs;

            double maya = ((priceBrashno * 0.75) * 0.20) * packageMaya;

            double totalAmount = brashno + sugar + egg + maya;

            Console.WriteLine($"{totalAmount:f2}");



        }
    }
}
