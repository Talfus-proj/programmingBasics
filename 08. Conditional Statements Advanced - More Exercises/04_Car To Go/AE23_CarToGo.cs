using System;

namespace AE23_CarToGo
{
    class AE23_CarToGo
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string car = "";
            string carClass = "";


            switch (season)
            {
                case "Summer":
                    car = "Cabrio";

                    if (budget <= 100)
                    {
                        carClass = "Economy class";
                        budget *= 0.35;
                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        carClass = "Compact class";
                        budget *= 0.45;
                    }
                    else if (budget > 500)
                    {
                        carClass = "Luxury class";
                        budget *= 0.90;
                        car = "Jeep";
                    }

                    break;

                case "Winter":
                    car = "Jeep";

                    if (budget <= 100)
                    {
                        carClass = "Economy class";
                        budget *= 0.65;
                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        carClass = "Compact class";
                        budget *= 0.80;
                    }
                    else if (budget > 500)
                    {
                        carClass = "Luxury class";
                        budget *= 0.90;
                        car = "Jeep";
                    }

                    break;

            }

            Console.WriteLine(carClass);
            Console.WriteLine($"{car} - {budget:f2}");
        }
    }
}
