using System;

namespace FINALEXAM04
{
    class FINALEXAM04
    {
        static void Main()
        {
            double daysInput = double.Parse(Console.ReadLine());
            double totalAmount = 0;
            double totalDegrees = 0;

            for (int i = 1; i <= daysInput; i++)
            {
                double amount = double.Parse(Console.ReadLine());
                double degree = double.Parse(Console.ReadLine());

                totalAmount += amount;
                totalDegrees += amount * degree;
            }

            double avarage = totalDegrees / totalAmount;

            Console.WriteLine($"Liter: {totalAmount:f2}");
            Console.WriteLine($"Degrees: {avarage:f2}");

            if (avarage < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (avarage >= 38 && avarage < 42)
            {
                Console.WriteLine($"Super!");
            }
            else if (avarage > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }

        }

    }
}
