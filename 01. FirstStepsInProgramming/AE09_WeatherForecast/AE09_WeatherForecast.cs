using System;

namespace AE09_WeatherForecast
{
    class AE09_WeatherForecast
    {
        static void Main()
        {
            string weather = Console.ReadLine();

            if (weather == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (weather == "cloudy")
            {
                Console.WriteLine("It's cold outside!");
            }
            else if (weather == "snowy")
            {
                Console.WriteLine("It's cold outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
