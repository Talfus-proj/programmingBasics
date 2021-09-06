using System;

namespace AE55_HappyCatParking
{
    class AE55_HappyCatParking
    {
        static void Main()
        {
            double numberOfDays = double.Parse(Console.ReadLine());
            double numberOfHours = double.Parse(Console.ReadLine());

            double expenses = 0;
            double currentSum = 0;


            for (int days = 1; days <= numberOfDays; days++)
            {
                for (int hours = 1; hours <= numberOfHours; hours++)
                {

                    if (days % 2 == 0 && hours % 2 != 0)
                    {
                        expenses += 2.50;
                        currentSum += 2.50;
                    }
                   
                    else if (days % 2 != 0 && hours % 2 == 0)
                    {
                        expenses += 1.25;
                        currentSum += 1.25;
                    }
                    else
                    {
                        expenses += 1;
                        currentSum += 1;
                    }
                }
                Console.WriteLine($"Day: {days} - {currentSum:f2} leva");
                currentSum = 0;
            }
            Console.WriteLine($"Total: {expenses:f2} leva");
        }
    }
}
