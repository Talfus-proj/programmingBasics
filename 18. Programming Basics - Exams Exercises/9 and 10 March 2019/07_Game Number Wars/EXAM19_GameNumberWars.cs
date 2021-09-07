using System;

namespace EXAM19_GameNumberWars
{
    class Program
    {
        static void Main()
        {
            string gamer1 = Console.ReadLine();//ОТ КОНЗОЛАТА 
            string gamer2 = Console.ReadLine();//

            int totalGamer1 = 0;
            int totalGamer2 = 0;

            string command = Console.ReadLine();//команда се въвежда от конзолата

            while (command != "End of game")
            {
                int card1 = int.Parse(command);// вътре в цикъла . като започва с команда
                int card2 = int.Parse(Console.ReadLine());
                if (card1 > card2)//първия е победител
                {
                    totalGamer1 += card1 - card2;
                }
                else if (card2 > card1)
                {
                    totalGamer2 += card2 - card1;
                }
                else//булевия израз става true  ,заради команда number wars
                {
                    while (true)
                    {
                        card1 = int.Parse(Console.ReadLine());
                        card2 = int.Parse(Console.ReadLine());

                        if (card1 > card2)
                        {

                            // card1 = card1 - card2;
                            //totalGamer1 = card1;
                            Console.WriteLine($"Number wars!");
                            Console.WriteLine($"{gamer1} is winner with {totalGamer1} points");
                            return;
                        }
                        else
                        {

                            //card2 = card2 - card1;
                            //totalGamer2 = card2;
                            Console.WriteLine($"Number wars!");
                            Console.WriteLine($"{gamer2} is winner with {totalGamer2} points");
                            return;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            if (command == "End of game")
            {
                Console.WriteLine($"{gamer1} has {totalGamer1} points");
                Console.WriteLine($"{gamer2} has {totalGamer2} points");
            }
        }
    }
}
