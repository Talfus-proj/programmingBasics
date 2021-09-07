using System;

namespace EXAM21_TennisRanklist
{
    class EXAM21_TennisRanklist
    {
        static void Main()
        {

            int input = int.Parse(Console.ReadLine());
            double startPoints = double.Parse(Console.ReadLine());
            double winsCounter = 0;
            double tournamentCounter = 0;
            double avarage = 0;

            for (int i = 1; i <= input; i++)
            {
                string tournaments = Console.ReadLine();

                switch (tournaments)
                {
                    case "W":
                        winsCounter++;
                        tournamentCounter++;
                        startPoints += 2000;
                        avarage += 2000;
                        break;
                    case "F":
                        startPoints += 1200;
                        tournamentCounter++;
                        avarage += 1200;
                        break;
                    case "SF":
                        startPoints += 720;
                        avarage += 720;
                        tournamentCounter++;
                        break;
                }
            }

            avarage /= tournamentCounter;
    
            double percent = (winsCounter / tournamentCounter) * 100;

            Console.WriteLine($"Final points: {startPoints}");
            Console.WriteLine($"Average points: {Math.Floor(avarage)}");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}



