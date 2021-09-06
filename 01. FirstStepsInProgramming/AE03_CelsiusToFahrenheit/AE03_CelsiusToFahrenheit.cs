using System;

namespace AE03_CelsiusToFahrenheit
{
    class AE03_CelsiusToFahrenheit
    {
        static void Main()
        {
            double Celsius = double.Parse(Console.ReadLine());

            double convertToFahrenheit = ((Celsius * 1.8) + 32);

            Console.WriteLine($"{convertToFahrenheit:f2}");
        }
    }
}
