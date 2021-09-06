using System;

namespace AE01_TrapezoidArea_First_Steps_in_Coding___More_Exercises
{
    class AE01_TrapezoidArea_First_Steps_in_Coding___More_Exercises
    {
        static void Main()
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double formula = (((b1 + b2) * h) / 2);

            Console.WriteLine($"{formula:f2}");

        }
    }
}
