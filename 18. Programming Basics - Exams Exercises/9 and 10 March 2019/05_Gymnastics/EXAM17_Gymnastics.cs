using System;

namespace EXAM17_Gymnastics
{
    class EXAM17_Gymnastics
    {
        static void Main()
        {
            string country = Console.ReadLine();
            string discipline = Console.ReadLine();
            double difficulty = 0;
            double action = 0;

            switch (country)
            {
                case "Russia":
                    switch (discipline)
                    {
                        case "ribbon":
                            difficulty = 9.100;
                            action = 9.400;
                            break;
                        case "hoop":
                            difficulty = 9.300;
                            action = 9.800;
                            break;
                        case "rope":
                            difficulty = 9.600;
                            action = 9.000;
                            break;
                    }
                    break;

                case "Bulgaria":
                    switch (discipline)
                    {
                        case "ribbon":
                            difficulty = 9.600;
                            action = 9.400;
                            break;
                        case "hoop":
                            difficulty = 9.550;
                            action = 9.750;
                            break;
                        case "rope":
                            difficulty = 9.500;
                            action = 9.400;
                            break;
                    }
                    break;

                case "Italy":
                    switch (discipline)
                    {
                        case "ribbon":
                            difficulty = 9.200;
                            action = 9.500;
                            break;
                        case "hoop":
                            difficulty = 9.450;
                            action = 9.350;
                            break;
                        case "rope":
                            difficulty = 9.700;
                            action = 9.150;
                            break;
                    }
                    break;
            }

            double disciplineSum = difficulty + action;
            double percent = 20 - disciplineSum;
            double finalPercent = (percent / 20) * 100;

            Console.WriteLine($"The team of {country} get {disciplineSum:f3} on {discipline}.");
            Console.WriteLine($"{finalPercent:f2}%");
        }
    }
}
