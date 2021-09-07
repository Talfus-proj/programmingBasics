using System;

namespace EXAM09_EasterEggs
{
    class EXAM09_EasterEggs
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;
            int maxValue = int.MinValue;
            string biggestColour = "";

            for (int i = 1; i <= number; i++)
            {
                string colour = Console.ReadLine();

                switch (colour)
                {
                    case "red":
                        red++;
                        if (red >= maxValue)
                        {
                            maxValue = red;
                            biggestColour = "red";
                        }
                        break;
                    case "orange":
                        orange++;
                        if (orange >= maxValue)
                        {
                            maxValue = orange;
                            biggestColour = "orange";
                        }
                        break;
                    case "blue":
                        blue++;
                        if (blue >= maxValue)
                        {
                            maxValue = blue;
                            biggestColour = "blue";
                        }
                        break;
                    case "green":
                        green++;
                        if (green >= maxValue)
                        {
                            maxValue = green;
                            biggestColour = "green";
                        }
                        break;
                }
            }
            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {maxValue} -> {biggestColour}");
        }
    }
}
