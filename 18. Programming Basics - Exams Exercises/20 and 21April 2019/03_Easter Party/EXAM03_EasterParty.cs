using System;

namespace EXAM03_EasterParty
{
    class EXAM03_EasterParty
    {
        static void Main()
        {
            double numberOfGuests = double.Parse(Console.ReadLine());
            double pricePerPerson = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            if (numberOfGuests >= 10 && numberOfGuests <= 15)
            {
                pricePerPerson *= 0.85;
            }
            else if (numberOfGuests > 15 && numberOfGuests <= 20)
            {
                pricePerPerson *= 0.80;
            }
            else if (numberOfGuests > 20)
            {
                pricePerPerson *= 0.75;
            }

            double price = numberOfGuests * pricePerPerson;
            double cakePrice = budget - (budget * 0.90);

            double totalPrice = cakePrice + price;

            if (budget > totalPrice)
            {
                Console.WriteLine($"It is party time! {(budget - totalPrice):f2} leva left.");
            }
            else if (budget < totalPrice)
            {
                Console.WriteLine($"No party! {(totalPrice - budget):f2} leva needed.");
            }

        }
    }
}
