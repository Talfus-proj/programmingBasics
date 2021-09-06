using System;

namespace E70_Salary
{
    class E70_Salary
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber; i++)
            {
                string tabOpenned = Console.ReadLine();

                if (tabOpenned == "Facebook")
                {
                    budget -= 150;
                }
                if (tabOpenned == "Instagram")
                {
                    budget -= 100;
                }
                if (tabOpenned == "Reddit")
                {
                    budget -= 50;
                }

                if (budget <= 0)
                {
                    break;
                }
            }

            if (budget <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(budget);
            }
        }
    }
}
