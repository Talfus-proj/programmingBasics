using System;

namespace E36_SmallShop
{
    class E36_SmallShop
    {
        static void Main()
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    double productQuantity = amount * 0.50;
                    Console.WriteLine(productQuantity);
                }
                else if (product == "water")
                {
                    double productQuantity = amount * 0.80;
                    Console.WriteLine(productQuantity);
                }
                else if (product == "beer")
                {
                    double productQuantity = amount * 1.20;
                    Console.WriteLine(productQuantity);
                }
                else if (product == "sweets")
                {
                    double productQuantity = amount * 1.45;
                    Console.WriteLine(productQuantity);
                }
                else if (product == "peanuts")
                {
                    double productQuantity = amount * 1.60;
                    Console.WriteLine(productQuantity);
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    double productQuantity = amount * 0.40;
                    Console.WriteLine(productQuantity);
                }
                else if (product == "water")
                {
                    double productQuantity = amount * 0.70;
                    Console.WriteLine(productQuantity);
                }
                else if (product == "beer")
                {
                    double productQuantity = amount * 1.15;
                    Console.WriteLine(productQuantity);
                }
                else if (product == "sweets")
                {
                    double productQuantity = amount * 1.30;
                    Console.WriteLine(productQuantity);
                }
                else if (product == "peanuts")
                {
                    double productQuantity = amount * 1.50;
                    Console.WriteLine(productQuantity);
                }
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    double productQuantity = amount * 0.45;
                    Console.WriteLine(productQuantity);
                }
                else if (product == "water")
                {
                    double productQuantity = amount * 0.70;
                    Console.WriteLine(productQuantity);
                }
                else if (product == "beer")
                {
                    double productQuantity = amount * 1.10;
                    Console.WriteLine(productQuantity);
                }
                else if (product == "sweets")
                {
                    double productQuantity = amount * 1.35;
                    Console.WriteLine(productQuantity);
                }
                else if (product == "peanuts")
                {
                    double productQuantity = amount * 1.55;
                    Console.WriteLine(productQuantity);
                }
            }

        }
    }
}
