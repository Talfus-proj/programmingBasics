using System;

namespace AE22_Flowers
{
    class AE22_Flowers
    {
        static void Main()
        {
            double numberOfHrizantems = double.Parse(Console.ReadLine());
            double numberOfRoses = double.Parse(Console.ReadLine());
            double numberOfLaleta = double.Parse(Console.ReadLine());
            string whichSeason = Console.ReadLine();
            string holidayOrNot = Console.ReadLine();

            double priceOfHrizantems = 0;
            double priceOfHRoses = 0;
            double priceOfHLaleta = 0;

            double totalPrice = 0;

            double totalNumberOfFlowers = numberOfHrizantems + numberOfRoses + numberOfLaleta;

            switch (whichSeason)
            {
                case "Spring":
                case "Summer":
                    priceOfHrizantems = 2.00;
                    priceOfHRoses = 4.10;
                    priceOfHLaleta = 2.50;

                    totalPrice = (numberOfHrizantems * priceOfHrizantems) + (numberOfRoses * priceOfHRoses) + (numberOfLaleta * priceOfHLaleta);

                    if (holidayOrNot == "Y")
                    {
                        totalPrice *= 1.15;
                    }

                    if (numberOfLaleta >= 7)
                    {
                        totalPrice *= 0.95;
                        
                    }

                    if (totalNumberOfFlowers >= 20)
                    {
                        totalPrice *= 0.80;
                    }

                    Console.WriteLine($"{(totalPrice+2):f2}");
                    break;
                case "Autumn":
                case "Winter":

                    priceOfHrizantems = 3.75;
                    priceOfHRoses = 4.50;
                    priceOfHLaleta = 4.15;

                    totalPrice = (numberOfHrizantems * priceOfHrizantems) + (numberOfRoses * priceOfHRoses) + (numberOfLaleta * priceOfHLaleta);

                    if (holidayOrNot == "Y")
                    {
                        totalPrice *= 1.15;
                    }

                    if (numberOfRoses >= 10 & whichSeason == "Winter")
                    {
                        totalPrice *= 0.90;
                        
                    }

                    if (totalNumberOfFlowers >= 20)
                    {
                        totalPrice *= 0.80;
                    }

                    Console.WriteLine($"{(totalPrice + 2):f2}");

                    break;
   
            }
        }
    }
}
