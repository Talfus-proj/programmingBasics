using System;

namespace AE30_BackToThePast_For_Loop_More_Exercises
{
    class AE30_BackToThePast_For_Loop_More_Exercises
    {
        static void Main()
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int whatYear = int.Parse(Console.ReadLine());

            int age = 18;
            double totalExpenses = 0.0;


            for (int i = 1800; i <= whatYear; i++)
            {
                if (i % 2 == 0)
                {
                    totalExpenses += 12000;
                   
                }
                else
                {
                    totalExpenses += 12000 + 50 * age;
                }
                age++;
            }

            if (inheritedMoney >= totalExpenses)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney - totalExpenses:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {totalExpenses - inheritedMoney:f2} dollars to survive.");
            }


        }
    }
}
