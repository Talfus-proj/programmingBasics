using System;

namespace E82_Vacation
{
    class E82_Vacation
    {
        static void Main()
        {
            double requiredMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            double passedDays = 0;
            double spendingTimes = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double moneyAction = double.Parse(Console.ReadLine());

                passedDays++;

                if (action == "spend")
                {
                    spendingTimes++;
                    availableMoney -= moneyAction;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
                else if (action == "save")
                {
                   spendingTimes = 0;
                   availableMoney += moneyAction;  
                }

                if (spendingTimes == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{passedDays}");
                    return;
                }

                if (availableMoney >= requiredMoney)
                {
                    Console.WriteLine($"You saved the money for {passedDays} days.");
                    return;
                }
               
            }

        }
    }
}
