using System;

namespace E45_Cinema_ConditionalStatementsAdvanced_Exercise
{
    class E45_Cinema_ConditionalStatementsAdvanced_Exercise
    {
        static void Main()
        {
            string typeOfProjection = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double column = double.Parse(Console.ReadLine());

            double totalIncome = rows * column;
            double totalPrice = 0;

            if (typeOfProjection == "Premiere")
            {
                totalPrice = totalIncome * 12.00;
            }

            else if (typeOfProjection == "Normal")
            {
                totalPrice = totalIncome * 7.50;
            }

            else if (typeOfProjection == "Discount")
            {
                totalPrice = totalIncome * 5.00;
            }

            Console.WriteLine($"{totalPrice:F2} leva");

        }
    }
}
