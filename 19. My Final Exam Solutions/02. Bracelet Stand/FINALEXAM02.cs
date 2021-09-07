using System;

namespace FINALEXAM02
{
    class FINALEXAM02
    {
        static void Main()
        {
            double dailyBudget = double.Parse(Console.ReadLine());
            double dailySales = double.Parse(Console.ReadLine());
            double wholePeriodExpenses = double.Parse(Console.ReadLine());
            double priceOfGift = double.Parse(Console.ReadLine());

            double curBudget = dailyBudget * 5;
            double curSales = dailySales * 5;
            double curExpenses = (curBudget + curSales) - wholePeriodExpenses;

            if (curExpenses > priceOfGift)
            {
                Console.WriteLine($"Profit: {curExpenses:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {(priceOfGift - curExpenses):f2} BGN.");
            }
        }
    }
}
