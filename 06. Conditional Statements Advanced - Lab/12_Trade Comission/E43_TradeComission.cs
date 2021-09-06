using System;

namespace E43_TradeComission
{
    class E43_TradeComission
    {
        static void Main()
        {
            string city = Console.ReadLine();
            double volumeSales = double.Parse(Console.ReadLine());


            if (city == "Sofia")
            {
                if (volumeSales <= 0 || volumeSales <= 500)
                {
                    double commisionAmount = volumeSales * 0.05;
                    Console.WriteLine($"{commisionAmount:f2}");
                }
                else if (volumeSales < 500 || volumeSales <= 1000)
                {
                    double commisionAmount = volumeSales * 0.07;
                    Console.WriteLine($"{commisionAmount:f2}");
                }
                else if (volumeSales < 1000 || volumeSales <= 10000)
                {
                    double commisionAmount = volumeSales * 0.08;
                    Console.WriteLine($"{commisionAmount:f2}");
                }
                else if (volumeSales > 10000)
                {
                    double commisionAmount = volumeSales * 0.12;
                    Console.WriteLine($"{commisionAmount:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (city == "Varna")
            {
                if (volumeSales <= 0 || volumeSales <= 500)
                {
                    double commisionAmount = volumeSales * 0.045;
                    Console.WriteLine($"{commisionAmount:f2}");
                }
                else if (volumeSales < 500 || volumeSales <= 1000)
                {
                    double commisionAmount = volumeSales * 0.075;
                    Console.WriteLine($"{commisionAmount:f2}");
                }
                else if (volumeSales < 1000 || volumeSales <= 10000)
                {
                    double commisionAmount = volumeSales * 0.10;
                    Console.WriteLine($"{commisionAmount:f2}");
                }
                else if (volumeSales > 10000)
                {
                    double commisionAmount = volumeSales * 0.13;
                    Console.WriteLine($"{commisionAmount:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (city == "Plovdiv")
            {
                if (volumeSales < 0)
                {
                    Console.WriteLine("error");
                }

                else if (volumeSales >= 0 && volumeSales <= 500)
                {
                    double commisionAmount = volumeSales * 0.055;
                    Console.WriteLine($"{commisionAmount:f2}");
                }
                else if (volumeSales < 500 || volumeSales <= 1000)
                {
                    double commisionAmount = volumeSales * 0.08;
                    Console.WriteLine($"{commisionAmount:f2}");
                }
                else if (volumeSales < 1000 || volumeSales <= 10000)
                {
                    double commisionAmount = volumeSales * 0.12;
                    Console.WriteLine($"{commisionAmount:f2}");
                }
                else if (volumeSales > 10000)
                {
                    double commisionAmount = volumeSales * 0.145;
                    Console.WriteLine($"{commisionAmount:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
