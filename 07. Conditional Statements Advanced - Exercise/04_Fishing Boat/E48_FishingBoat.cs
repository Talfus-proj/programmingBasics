using System;

namespace E48_FishingBoat
{
    class E48_FishingBoat
    {
        static void Main()
        {


            double groupBudget = double.Parse(Console.ReadLine());
            string whatSeason = Console.ReadLine();
            int numberOfFisherman = int.Parse(Console.ReadLine());

            double rentOfShip = 0;

            switch (whatSeason)
            {
                case "Spring":
                    rentOfShip = 3000;

                    if (numberOfFisherman <= 6)
                    {
                        rentOfShip *= 0.90;
                    }
                    else if (numberOfFisherman >= 7 && numberOfFisherman <= 11)
                    {
                        rentOfShip *= 0.85;
                    }
                    else if (numberOfFisherman > 12)
                    {
                        rentOfShip *= 0.75;
                    }
                    break;

                case "Summer":
                case "Autumn":
                    rentOfShip = 4200;

                    if (numberOfFisherman <= 6)
                    {
                        rentOfShip *= 0.90;
                    }
                    else if (numberOfFisherman >= 7 && numberOfFisherman <= 11)
                    {
                        rentOfShip *= 0.85;
                    }
                    else if (numberOfFisherman > 12)
                    {
                        rentOfShip *= 0.75;
                    }
                    break;

                case "Winter":
                    rentOfShip = 2600;

                    if (numberOfFisherman <= 6)
                    {
                        rentOfShip *= 0.90;
                    }
                    else if (numberOfFisherman >= 7 && numberOfFisherman <= 11)
                    {
                        rentOfShip *= 0.85;
                    }
                    else if (numberOfFisherman > 12)
                    {
                        rentOfShip *= 0.75;
                    }
                    break;

            }

            if (whatSeason != "Autumn" && numberOfFisherman % 2 == 0)
            {
                rentOfShip *= 0.95;
            }

            if (groupBudget >= rentOfShip)
            {
                Console.WriteLine($"Yes! You have {(groupBudget - rentOfShip):f2} leva left.");
            }
            else if (groupBudget < rentOfShip)
            {
                Console.WriteLine($"Not enough money! You need {(rentOfShip - groupBudget):f2} leva.");
            }

        }
    }
}
