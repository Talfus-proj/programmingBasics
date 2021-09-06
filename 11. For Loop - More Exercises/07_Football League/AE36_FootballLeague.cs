using System;

namespace AE36_FootballLeague
{
    class AE36_FootballLeague
    {
        static void Main()
        {
            double stadiumCapacity = double.Parse(Console.ReadLine());
            double numberOfFans = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;

            for (int i = 0; i < numberOfFans; i++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A":
                        p1++;
                        break;
                    case "B":
                        p2++;
                        break;
                    case "V":
                        p3++;
                        break;
                    case "G":
                        p4++;
                        break;
                }
            }

            double percentOne = (p1 / numberOfFans) * 100;
            double percentTwo = (p2 / numberOfFans) * 100;
            double percentThree = (p3 / numberOfFans) * 100;
            double percentFour = (p4 / numberOfFans) * 100;
            double wholeStadiumCapacity = (numberOfFans / stadiumCapacity) * 100;

            Console.WriteLine($"{percentOne:f2}%");
            Console.WriteLine($"{percentTwo:f2}%");
            Console.WriteLine($"{percentThree:f2}%");
            Console.WriteLine($"{percentFour:f2}%");
            Console.WriteLine($"{wholeStadiumCapacity:f2}%");
        }
    }
}
