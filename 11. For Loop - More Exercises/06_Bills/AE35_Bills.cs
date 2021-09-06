using System;

namespace AE35_Bills
{
    class AE35_Bills
    {
        static void Main()
        {
            const double WATER = 20;
            const double INTERNET = 15;

            double electricty = 0;
           
            double other = 0;
            double avarage = 0;
            double total = 0;
            
            double monthsForExpenses = double.Parse(Console.ReadLine());

            double water = monthsForExpenses * WATER;
            double internet = monthsForExpenses * INTERNET;

            for (int i = 0; i < monthsForExpenses; i++)
            {
                double electricBill = double.Parse(Console.ReadLine());

                electricty += electricBill;

                other = (electricBill + WATER + INTERNET) *1.20;
                total += other;
            }

            avarage = (electricty + water + internet + total) / monthsForExpenses;

            Console.WriteLine($"Electricity: {electricty:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {total:f2} lv");
            Console.WriteLine($"Average: {avarage:f2} lv");
        }
    }
}
