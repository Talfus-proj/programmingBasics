using System;

namespace EXAM20_Darts
{
    class EXAM20_Darts
    {
        static void Main()
        {

            string playerName = Console.ReadLine();
            string command = Console.ReadLine();
            int startScore = 301;
            int shots = 0;
            int failed = 0;

            while (command != "Retire")
            {
                int score = int.Parse(Console.ReadLine());
                shots++;
                switch (command)
                {
                    case "Single":
                        if (score > startScore)
                        {
                            failed++;
                            shots--;
                            break;
                        }
                        else
                        {
                            startScore -= score;
                        }
                        break;

                    case "Double":
                        if ((score * 2 ) > startScore)
                        {
                            failed++;
                            shots--;
                            break;

                        }
                        else
                        {
                            startScore -= score * 2;
                        }
                        break;

                    case "Triple":
                        if ((score * 3) > startScore)
                        {
                            failed++;
                            shots--;
                            break;
                        }
                        else
                        {
                            startScore -= score * 3;
                        }
                        break;
                }

                if (startScore == 0)
                {
                    Console.WriteLine($"{playerName} won the leg with {shots} shots.");
                    return;
                }

                command = Console.ReadLine(); 
            }

            if (command == "Retire")
            {
                Console.WriteLine($"{playerName} retired after {failed} unsuccessful shots.");
            }
        }
    }
}
