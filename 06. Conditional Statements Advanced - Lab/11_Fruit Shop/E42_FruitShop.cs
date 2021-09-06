using System;

namespace E42_FruitShop
{
    class E42_FruitShop
    {
        static void Main()
        {
            string specificFruit = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double quantityOfFruit = double.Parse(Console.ReadLine());


            if (dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday" || dayOfTheWeek == "Friday")
            {
                switch (specificFruit)
                {
                    case "banana":
                        double priceOfProductB = quantityOfFruit * 2.50;
                        Console.WriteLine($"{priceOfProductB:f2}");
                        break;
                    case "apple":
                        double priceOfProductA = quantityOfFruit * 1.20;
                        Console.WriteLine($"{priceOfProductA:f2}");
                        break;
                    case "orange":
                        double priceOfProductO = quantityOfFruit * 0.85;
                        Console.WriteLine($"{priceOfProductO:f2}");
                        break;
                    case "grapefruit":
                        double priceOfProductG = quantityOfFruit * 1.45;
                        Console.WriteLine($"{priceOfProductG:f2}");
                        break;
                    case "kiwi":
                        double priceOfProductK = quantityOfFruit * 2.70;
                        Console.WriteLine($"{priceOfProductK:f2}");
                        break;
                    case "pineapple":
                        double priceOfProductP = quantityOfFruit * 5.50;
                        Console.WriteLine($"{priceOfProductP:f2}");
                        break;
                    case "grapes":
                        double priceOfProductS = quantityOfFruit * 3.85;
                        Console.WriteLine($"{priceOfProductS:f2}");
                        break;
                    default:
                        Console.WriteLine("error"); break;
                }
            }

            else if (dayOfTheWeek == "Saturday" || dayOfTheWeek == "Sunday")
            {
                switch (specificFruit)
                {
                    case "banana":
                        double priceOfProductB = quantityOfFruit * 2.70;
                        Console.WriteLine($"{priceOfProductB:f2}");
                        break;
                    case "apple":
                        double priceOfProductA = quantityOfFruit * 1.25;
                        Console.WriteLine($"{priceOfProductA:f2}");
                        break;
                    case "orange":
                        double priceOfProductO = quantityOfFruit * 0.90;
                        Console.WriteLine($"{priceOfProductO:f2}");
                        break;
                    case "grapefruit":
                        double priceOfProductG = quantityOfFruit * 1.60;
                        Console.WriteLine($"{priceOfProductG:f2}");
                        break;
                    case "kiwi":
                        double priceOfProductK = quantityOfFruit * 3.00;
                        Console.WriteLine($"{priceOfProductK:f2}");
                        break;
                    case "pineapple":
                        double priceOfProductP = quantityOfFruit * 5.60;
                        Console.WriteLine($"{priceOfProductP:f2}");
                        break;
                    case "grapes":
                        double priceOfProductS = quantityOfFruit * 4.20;
                        Console.WriteLine($"{priceOfProductS:f2}");
                        break;
                    default:
                        Console.WriteLine("error"); break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }


    }
}

