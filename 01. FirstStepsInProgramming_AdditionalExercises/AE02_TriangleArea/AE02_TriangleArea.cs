using System;

namespace AE02_TriangleArea
{
    class AE02_TriangleArea
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = (a * h) / 2;

            Console.WriteLine($"{area:f2}");
        }
    }
}
