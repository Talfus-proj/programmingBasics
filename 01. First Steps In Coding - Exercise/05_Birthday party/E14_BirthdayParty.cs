using System;

namespace E14_BirthdayParty
{
    class E14_BirthdayParty
    {
        static void Main()
        {
            double rent = double.Parse(Console.ReadLine());

            double priceOfCake = rent * 0.20;

            double priceOfDrinks = priceOfCake - (priceOfCake * 0.45);

            double priceForAnimator = rent / 3;

            double totalSum = rent + priceOfCake + priceForAnimator + priceOfDrinks;

            Console.WriteLine(totalSum);
        }
    }
}
