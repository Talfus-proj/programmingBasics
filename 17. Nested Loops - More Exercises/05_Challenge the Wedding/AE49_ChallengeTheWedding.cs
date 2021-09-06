using System;

namespace AE49_ChallengeTheWedding
{
    class AE49_ChallengeTheWedding
    {
        static void Main()
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tablesMax = int.Parse(Console.ReadLine());
            int tableCounter = 0;

            for (int m = 1; m <= men; m++)
            {
                for (int f = 1; f <= women; f++)
                {
                    Console.Write($"({m} <-> {f}) ");
                    tableCounter++;
                    if (tableCounter == tablesMax)
                    {
                        return;
                    }
                }
            }
        }
    }
}
