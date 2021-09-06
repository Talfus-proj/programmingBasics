using System;

namespace E90_Travelling
{
    class E90_Travelling
    {
        static void Main()
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double vacationPrice = double.Parse(Console.ReadLine());
                double budget = 0;

                while (budget < vacationPrice)
                {
                    budget += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}