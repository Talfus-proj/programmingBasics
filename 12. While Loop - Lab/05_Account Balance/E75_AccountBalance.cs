﻿using System;

namespace E75_AccountBalance
{
    class E75_AccountBalance
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double balance = 0.0;
            while (input != "NoMoreMoney")
            {
                double amount = double.Parse(input);

                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                balance += amount;
                Console.WriteLine($"Increase: {amount:F2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {balance:F2}");
        }
    }
}
