using System;

namespace AE18_FuelTank
{
    class AE18_FuelTank
    {
        static void Main()
        {
            string typeOfFuel = Console.ReadLine();
            double litresInTank = double.Parse(Console.ReadLine());

            switch (typeOfFuel)
            {
                case "Diesel":
                    if (litresInTank >= 25)
                    {
                        Console.WriteLine($"You have enough diesel.");
                    }
                    else if (litresInTank < 25)
                    {
                        Console.WriteLine($"Fill your tank with diesel!");
                    }
                    break;
                case "Gasoline":
                    if (litresInTank >= 25)
                    {
                        Console.WriteLine($"You have enough gasoline.");
                    }
                    else if (litresInTank < 25)
                    {
                        Console.WriteLine($"Fill your tank with gasoline!");
                    }
                    break;
                case "Gas":
                    if (litresInTank >= 25)
                    {
                        Console.WriteLine($"You have enough gas.");
                    }
                    else if (litresInTank < 25)
                    {
                        Console.WriteLine($"Fill your tank with gas!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid fuel!");
                    break;
            }
        }
    }
}
