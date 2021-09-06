using System;

namespace AE21_BikeRace
{
    class AE21_BikeRace
    {
        static void Main()
        {
            int numberOfJuniorBikers = int.Parse(Console.ReadLine());
            int numberOfSeniorBikers = int.Parse(Console.ReadLine());
            string kindOfTrack = Console.ReadLine();

            double juniorTaxes = 0;
            double seniorTaxes = 0;
            double finalDiscount = 0;

            switch (kindOfTrack)
            {
                case "trail":

                    juniorTaxes = numberOfJuniorBikers * 5.50;
                    seniorTaxes = numberOfSeniorBikers * 7;

                    break;
                case "cross-country":
                    juniorTaxes = numberOfJuniorBikers * 8;
                    seniorTaxes = numberOfSeniorBikers * 9.50;
                    if ((numberOfJuniorBikers + numberOfSeniorBikers) >= 50)
                    {
                        finalDiscount = (juniorTaxes + seniorTaxes) * 0.75;
                        finalDiscount *= 0.95;

                        Console.WriteLine($"{finalDiscount:f2}");
                        return;
                    }

                    break;
                case "downhill":
                    juniorTaxes = numberOfJuniorBikers * 12.25;
                    seniorTaxes = numberOfSeniorBikers * 13.75;


                    break;
                case "road":

                    juniorTaxes = numberOfJuniorBikers * 20;
                    seniorTaxes = numberOfSeniorBikers * 21.50;

                    break;

            }

            finalDiscount = (juniorTaxes + seniorTaxes) * 0.95;
            Console.WriteLine($"{finalDiscount:f2}");


        }
    }
}
