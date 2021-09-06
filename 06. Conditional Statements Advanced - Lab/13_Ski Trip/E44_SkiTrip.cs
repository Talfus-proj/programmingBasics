using System;

namespace E44_SkiTrip
{
    class E44_SkiTrip
    {
        static void Main()
        {
            const double ROOM_FOR_ONE_PERSON = 18.00;
            const double APARTMENT = 25.00;
            const double PRESIDENT_APARTMENT = 35.00;

            int daysInResort = int.Parse(Console.ReadLine());
            daysInResort = daysInResort - 1;
            string whatRoom = Console.ReadLine();
            string evaluation = Console.ReadLine();
            double nightForStaying = 0;

            if (whatRoom == "apartment")
            {
                if (daysInResort < 10)
                {
                    nightForStaying = daysInResort * APARTMENT;
                    nightForStaying = nightForStaying - (nightForStaying * 0.30);

                }
                else if (daysInResort > 10 && daysInResort < 15)
                {
                    nightForStaying = daysInResort * APARTMENT;
                    nightForStaying = nightForStaying - (nightForStaying * 0.35);

                }
                if (daysInResort > 15)
                {
                    nightForStaying = daysInResort * APARTMENT;
                    nightForStaying = nightForStaying - (nightForStaying * 0.50);

                }
            }
            if (whatRoom == "president apartment")
            {
                if (daysInResort < 10)
                {
                    nightForStaying = daysInResort * PRESIDENT_APARTMENT;
                    nightForStaying = nightForStaying - (nightForStaying * 0.10);

                }
                else if (daysInResort > 10 && daysInResort < 15)
                {
                    nightForStaying = daysInResort * PRESIDENT_APARTMENT;
                    nightForStaying = nightForStaying - (nightForStaying * 0.15);

                }
                if (daysInResort > 15)
                {
                    nightForStaying = daysInResort * PRESIDENT_APARTMENT;
                    nightForStaying = nightForStaying - (nightForStaying * 0.20);

                }
            }

            if (whatRoom == "room for one person")
            {
                nightForStaying = daysInResort * ROOM_FOR_ONE_PERSON;
            }

            if (evaluation == "positive")
            {
                double positiveAmount = nightForStaying * 1.25;

                Console.WriteLine($"{positiveAmount:f2}");
            }
            else if (evaluation == "negative")
            {
                double negativeAmount = nightForStaying - (nightForStaying * 0.10);

                Console.WriteLine($"{negativeAmount:f2}");
            }


        }
    }
}
