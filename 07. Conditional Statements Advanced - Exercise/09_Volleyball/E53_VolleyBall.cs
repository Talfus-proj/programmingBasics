using System;

namespace E53_VolleyBall
{
    class E53_VolleyBall
    {
        static void Main()
        {
            string typeOfYear = Console.ReadLine();

            double holidaysP = double.Parse(Console.ReadLine());
            double weekendsH = double.Parse(Console.ReadLine());


            double weekendsInHomeTown = 48 - weekendsH;
            double weekendsInSofia = (weekendsInHomeTown * 3) / 4;
            double numberOfHolidays = (holidaysP * 2) / 3;

            double totalNumberOfGames = weekendsInSofia + weekendsH + numberOfHolidays;

            if (typeOfYear == "leap")
            {
                double plusLeapAmount = totalNumberOfGames * 1.15;
                Console.WriteLine(Math.Floor(plusLeapAmount));
            }
            else
            {
                Console.WriteLine(Math.Floor(totalNumberOfGames));
            }

        }
    }
}
