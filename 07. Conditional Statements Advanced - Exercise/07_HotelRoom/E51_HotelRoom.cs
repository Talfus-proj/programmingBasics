using System;

namespace E51_HotelRoom
{
    class E51_HotelRoom
    {
        static void Main()
        {
            const double MAY_OCTOMBER_STUDIO = 50;
            const double JUNE_SEPTEMBER_STUDIO = 75.20;
            const double JULY_AUGUST_STUDIO = 76;
            const double MAY_OCTOMBER_APARTMENT = 65;
            const double JUNE_SEPTEMBER_APARTMENT = 68.70;
            const double JULY_AUGUST_APARTMENT = 77;



            string whatMonth = Console.ReadLine();
            double amountOfNights = double.Parse(Console.ReadLine());

            double totalStudioPrice = 0;
            double totalApartmentPrice = 0;


            if (whatMonth == "May" || whatMonth == "October")
            {
                totalStudioPrice += amountOfNights * MAY_OCTOMBER_STUDIO;
                totalApartmentPrice += amountOfNights * MAY_OCTOMBER_APARTMENT;

                if (amountOfNights > 14)
                {
                    totalStudioPrice *= 0.7;
                    totalApartmentPrice *= 0.9;
                }
                else if (amountOfNights > 7)
                {
                    totalStudioPrice *= 0.95;
                }
            }

            else if (whatMonth == "June" || whatMonth == "September")
            {
                totalStudioPrice += amountOfNights * JUNE_SEPTEMBER_STUDIO;
                totalApartmentPrice += amountOfNights * JUNE_SEPTEMBER_APARTMENT;

                if (amountOfNights > 14)
                {
                    totalStudioPrice *= 0.8;
                    totalApartmentPrice *= 0.9;
                }
                
            }
            else if (whatMonth == "July" || whatMonth == "August")
            {
                totalStudioPrice += amountOfNights * JULY_AUGUST_STUDIO;
                totalApartmentPrice += amountOfNights * JULY_AUGUST_APARTMENT;

                if (amountOfNights > 14)
                {
                    totalApartmentPrice *= 0.9;
                }

            }

            Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        }
    }
}
