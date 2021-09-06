using System;

namespace AE26_SchoolCamp
{
    class AE26_SchoolCamp
    {
        static void Main()
        {
            string whichSeason = Console.ReadLine();
            string kindOfGroup = Console.ReadLine();
            double numberOfStudents = double.Parse(Console.ReadLine());
            double numberOfNights = double.Parse(Console.ReadLine());

            string whichSport = "";
            double seasonalFee = 0;
            double priceOfNights = 0;

            switch (whichSeason)
            {
                case "Winter":


                    switch (kindOfGroup)
                    {

                        case "boys":
                            whichSport = "Judo";
                            seasonalFee = 9.60;
                            break;

                        case "girls":
                            whichSport = "Gymnastics";
                            seasonalFee = 9.60;

                            break;

                        case "mixed":
                            whichSport = "Ski";
                            seasonalFee = 10;


                            break;
                    }

                    break;

                case "Spring":

                    switch (kindOfGroup)
                    {

                        case "boys":
                            whichSport = "Tennis";
                            seasonalFee = 7.20;


                            break;

                        case "girls":
                            whichSport = "Athletics";
                            seasonalFee = 7.20;

                            break;

                        case "mixed":
                            whichSport = "Cycling";
                            seasonalFee = 9.50;

                            break;
                    }

                    break;

                case "Summer":

                    switch (kindOfGroup)
                    {

                        case "boys":
                            whichSport = "Football";
                            seasonalFee = 15;

                            break;

                        case "girls":
                            whichSport = "Volleyball";
                            seasonalFee = 15;

                            break;

                        case "mixed":
                            whichSport = "Swimming";
                            seasonalFee = 20;

                            break;
                    }
                    break;   

            }


            priceOfNights = numberOfNights * seasonalFee * numberOfStudents;

            if (numberOfStudents >= 50)
            {
                priceOfNights *= 0.50;
            }
            else if (numberOfStudents >= 20 && numberOfStudents < 50)
            {
                priceOfNights *= 0.85;
            }

            else if (numberOfStudents >= 10 && numberOfStudents < 20)
            {
                priceOfNights *= 0.95;
            }


            Console.WriteLine($"{whichSport} {priceOfNights:f2} lv.");

        }
    }
}
