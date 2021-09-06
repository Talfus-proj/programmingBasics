using System;

namespace AE24_Vacation
{
    class AE24_Vacation
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string whichSeason = Console.ReadLine();

            string sleepingPlaceIs = "";
            string sleepingLocationIs = "";

            switch (whichSeason)
            {
                case "Summer":

                    sleepingLocationIs = "Alaska";

                    if (budget <= 1000)
                    {
                        sleepingPlaceIs = "Camp";
                        budget *= 0.65;
                    }
                    else if (budget > 1000 && budget <= 3000)
                    {
                        sleepingPlaceIs = "Hut";
                        budget *= 0.80;
                    }
                    else if (budget > 3000)
                    {
                        sleepingPlaceIs = "Hotel";
                        budget *= 0.90;
                    }


                    break;

                case "Winter":
                    sleepingLocationIs = "Morocco";

                    if (budget <= 1000)
                    {
                        sleepingPlaceIs = "Camp";
                        budget *= 0.45;
                    }
                    else if (budget > 1000 && budget <= 3000)
                    {
                        sleepingPlaceIs = "Hut";
                        budget *= 0.60;
                    }
                    else if (budget > 3000)
                    {
                        sleepingPlaceIs = "Hotel";
                        budget *= 0.90;
                    }

                    break;
            }

            Console.WriteLine($"{sleepingLocationIs} - { sleepingPlaceIs} - {budget:f2}");

        }
    }
}
