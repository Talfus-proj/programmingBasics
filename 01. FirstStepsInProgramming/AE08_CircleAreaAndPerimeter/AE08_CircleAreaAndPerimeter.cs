using System;

namespace AE08_CircleAreaAndPerimeter
{
    class AE08_CircleAreaAndPerimeter
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());

            double area = (Math.PI * radius) * 2;

            double licetoNaKrug = (((Math.PI * (radius * radius)) * 2) * 2) / 4;

            Console.WriteLine($"{licetoNaKrug:f2}");
            Console.WriteLine($"{area:f2}");
        }
    }
}
