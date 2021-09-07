using System;

namespace FINALEXAM05
{
    class FINALEXAM05
    {
        static void Main()
        {
            int numberOfSea = int.Parse(Console.ReadLine());
            int numberOfMountain = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int totalAmount = 0;

            while (command != "Stop")
            {
                if (numberOfSea == 0 && numberOfMountain == 0)
                {
                    break;
                }

                if (command == "sea" && numberOfSea > 0)
                {
                    numberOfSea--;
                    totalAmount += 680;
                    if (numberOfSea == 0 && numberOfMountain == 0)
                    {
                        break;
                    }
                }


                if (command == "mountain" && numberOfMountain > 0)
                {
                    numberOfMountain--;
                    totalAmount += 499;
                    if (numberOfMountain == 0 && numberOfSea == 0)
                    {
                        break;
                    }
                }

                command = Console.ReadLine();
            }

            if (command == "Stop")
            {
                Console.WriteLine($"Profit: {totalAmount} leva.");
            }

            if (numberOfSea == 0 && numberOfMountain == 0)
            {
                Console.WriteLine($"Good job! Everything is sold.");
                Console.WriteLine($"Profit: {totalAmount} leva.");
            }
        }
    }
}
