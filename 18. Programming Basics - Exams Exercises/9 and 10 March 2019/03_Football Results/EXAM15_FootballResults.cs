using System;

namespace EXAM15_FootballResults
{
    class EXAM15_FootballResults
    {
        static void Main()
        {
            string score1 = Console.ReadLine();
            string score2 = Console.ReadLine();
            string score3 = Console.ReadLine();


            int teamWin = 0;
            int teamLost = 0;
            int teamDrawn = 0;

            if ((score1[0]) > (score1[2]))
            {
                teamWin++;
            }
            else if ((score1[0]) < (score1[2]))
            {
                teamLost++;
            }
            else if ((score1[0]) == (score1[2]))
            {
                teamDrawn++;
            }

            if ((score2[0]) > (score2[2]))
            {
                teamWin++;
            }
            else if ((score2[0]) < (score2[2]))
            {
                teamLost++;
            }
            else if ((score2[0]) == (score2[2]))
            {
                teamDrawn++;
            }

            if ((score3[0]) > (score3[2]))
            {
                teamWin++;
            }
            else if ((score3[0]) < (score3[2]))
            {
                teamLost++;
            }
            else if ((score3[0]) == (score3[2]))
            {
                teamDrawn++;
            }

            Console.WriteLine($"Team won {teamWin} games.");
            Console.WriteLine($"Team lost {teamLost} games.");
            Console.WriteLine($"Drawn games: {teamDrawn}");

        }
    }
}
