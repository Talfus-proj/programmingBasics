using System;

namespace E47_NewHouse
{
    class E47_NewHouse
    {
        static void Main()
        {
            const double PRICE_OF_ROSES = 5;
            const double PRICE_OF_DAHLIAS = 3.80;
            const double PRICE_OF_TULIPS = 2.80;
            const double PRICE_OF_NARCISSUS = 3;
            const double PRICE_OF_GLADIOLUS = 2.50;

            string typeOfFlower = Console.ReadLine();
            double numberOfFlowers = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double price = 0;

            if (typeOfFlower == "Roses")
            {
                price = numberOfFlowers * PRICE_OF_ROSES;
                if (numberOfFlowers > 80)
                {

                    price *= 0.90;
                }

            }
            if (typeOfFlower == "Dahlias")
            {
                price = numberOfFlowers * PRICE_OF_DAHLIAS;
                if (numberOfFlowers > 90)
                {
                    price *= 0.85;
                }

            }

            if (typeOfFlower == "Tulips")
            {
                price = numberOfFlowers * PRICE_OF_TULIPS;
                if (numberOfFlowers > 80)
                {
                    price *= 0.85;
                }

            }

            if (typeOfFlower == "Narcissus")
            {
                price = numberOfFlowers * PRICE_OF_NARCISSUS;
                if (numberOfFlowers < 120)
                {
                   price *= 1.15;
                }

            }

            if (typeOfFlower == "Gladiolus")
            {
                price = numberOfFlowers * PRICE_OF_GLADIOLUS;
                if (numberOfFlowers < 80)
                {
                   price *= 1.20;
                }
            }

            if (price <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlower} and {(budget - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(price - budget):f2} leva more.");
            }

        }
    }
}
