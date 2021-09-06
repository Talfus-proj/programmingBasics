using System;

namespace AE25_TruckDriver
{
    class AE25_TruckDriver
    {
        static void Main()
        {
            string whichSeason = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            switch (whichSeason)
            {
                case "Spring":
                case "Autumn":

                    if (kmPerMonth <= 5000 )
                    {
                        kmPerMonth *= 0.75;
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        kmPerMonth *= 0.95;
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        kmPerMonth *= 1.45;
                    }

                    break;

                case "Summer":

                    if (kmPerMonth <= 5000)
                    {
                        kmPerMonth *= 0.90;
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        kmPerMonth *= 1.10;
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        kmPerMonth *= 1.45;
                    }

                    break;

                case "Winter":


                    if (kmPerMonth <= 5000)
                    {
                        kmPerMonth *= 1.05;
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        kmPerMonth *= 1.25;
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        kmPerMonth *= 1.45;
                    }

                    break;

            }

            kmPerMonth = (kmPerMonth * 4) * 0.90;

            Console.WriteLine($"{kmPerMonth:f2}");
        }
    }
}
