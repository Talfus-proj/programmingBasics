using System;

namespace AE19_FuelTank2
{
    class AE19_FuelTank2
    {
        static void Main()
        {
            const double GASOLINE = 2.22;
            const double DIESEL = 2.33;
            const double GAS = 0.93;

            string typeOfFuel = Console.ReadLine();
            double gasAmount = double.Parse(Console.ReadLine());
            string clubCardPossesion = Console.ReadLine();

            double fuelLitres = 0;
            double fuelDiscount = 0;

            switch (typeOfFuel)
            {
                case "Gasoline":

                    if (clubCardPossesion == "Yes")
                    {
                        fuelDiscount = GASOLINE - 0.18;
                        fuelLitres = gasAmount * fuelDiscount;
                        if (gasAmount >= 20 && gasAmount <= 25)
                        {
                            fuelLitres *= 0.92;
                        }

                        else if (gasAmount > 25)
                        {
                            fuelLitres *= 0.90;
                        }

                    }
                    else if (clubCardPossesion == "No")
                    {
                        fuelLitres = gasAmount * GASOLINE;
                        if (gasAmount >= 20 && gasAmount <= 25)
                        {
                            fuelLitres *= 0.92;
                        }

                        else if (gasAmount > 25)
                        {
                            fuelLitres *= 0.90;
                        }
                    }

                    break;

                case "Diesel":

                    if (clubCardPossesion == "Yes")
                    {
                        fuelDiscount = DIESEL - 0.12;
                        fuelLitres = gasAmount * fuelDiscount;
                        if (gasAmount >= 20 && gasAmount <= 25)
                        {
                            fuelLitres *= 0.92;
                        }

                        else if (gasAmount > 25)
                        {
                            fuelLitres *= 0.90;
                        }

                    }
                    else if (clubCardPossesion == "No")
                    {
                        fuelLitres = gasAmount * DIESEL;
                        if (gasAmount >= 20 && gasAmount <= 25)
                        {
                            fuelLitres *= 0.92;
                        }

                        else if (gasAmount > 25)
                        {
                            fuelLitres *= 0.90;
                        }
                    }

                    break;

                case "Gas":

                    if (clubCardPossesion == "Yes")
                    {
                        fuelDiscount = GAS - 0.08;
                        fuelLitres = gasAmount * fuelDiscount;
                        if (gasAmount >= 20 && gasAmount <= 25)
                        {
                            fuelLitres *= 0.92;
                        }

                        else if (gasAmount > 25)
                        {
                            fuelLitres *= 0.90;
                        }

                    }
                    else if (clubCardPossesion == "No")
                    {
                        fuelLitres = gasAmount * GAS;
                        if (gasAmount >= 20 && gasAmount <= 25)
                        {
                            fuelLitres *= 0.92;
                        }

                        else if (gasAmount > 25)
                        {
                            fuelLitres *= 0.90;
                        }
                    }

                    break;
            }
            Console.WriteLine($"{fuelLitres:f2} lv.");
        }
    }
}
