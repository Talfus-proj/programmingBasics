using System;

namespace EXAM06_PaintingEggs
{
    class EXAM06_PaintingEggs
    {
        static void Main()
        {
            string eggsSize = Console.ReadLine();
            string eggsColour = Console.ReadLine();
            double numberOfBatch = double.Parse(Console.ReadLine());
            double expenses = 0;

            switch (eggsColour)
            {
                case "Red":

                    switch (eggsSize)
                    {
                        case "Large":
                            expenses = numberOfBatch * 16;
                            break;
                        case "Medium":
                            expenses = numberOfBatch * 13;
                            break;
                        case "Small":
                            expenses = numberOfBatch * 9;
                            break;
                    }

                    break;
                case "Green":
                    switch (eggsSize)
                    {
                        case "Large":
                            expenses = numberOfBatch * 12;
                            break;
                        case "Medium":
                            expenses = numberOfBatch * 9;
                            break;
                        case "Small":
                            expenses = numberOfBatch * 8;
                            break;
                    }
                    break;
                case "Yellow":
                    switch (eggsSize)
                    {
                        case "Large":
                            expenses = numberOfBatch * 9;
                            break;
                        case "Medium":
                            expenses = numberOfBatch * 7;
                            break;
                        case "Small":
                            expenses = numberOfBatch * 5;
                            break;
                    }
                    break;
            }
            double expensePercent = expenses * 0.35;

            double sumAfterExpenses = expenses - expensePercent;

            Console.WriteLine($"{sumAfterExpenses:f2} leva.");
        }
    }
}
