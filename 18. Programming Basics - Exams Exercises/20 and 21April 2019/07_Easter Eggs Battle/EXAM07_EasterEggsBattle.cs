using System;

namespace EXAM07_EasterEggsBattle
{
    class EXAM07_EasterEggsBattle
    {
        static void Main()
        {
            int numberOfEggsPlayerOne = int.Parse(Console.ReadLine());
            int numberOfEggsPlayerTwo = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "End of battle")
            {
                switch (input)
                {
                    case "one":
                        numberOfEggsPlayerTwo--;

                        if (numberOfEggsPlayerOne == 0 && numberOfEggsPlayerTwo > 0 )
                        {
                            Console.WriteLine($"Player one is out of eggs. Player two has {numberOfEggsPlayerTwo} eggs left.");
                        }

                        if (numberOfEggsPlayerTwo == 0)
                        {
                            Console.WriteLine($"Player two is out of eggs. Player one has {numberOfEggsPlayerOne} eggs left.");
                            return;
                        }
                        break;
                    case "two":
                        numberOfEggsPlayerOne--;
                        if (numberOfEggsPlayerTwo == 0 && numberOfEggsPlayerOne > 0)
                        {
                            Console.WriteLine($"Player two is out of eggs. Player one has {numberOfEggsPlayerOne} eggs left.");
                        }
                        if (numberOfEggsPlayerOne == 0)
                        {
                            Console.WriteLine($"Player one is out of eggs. Player two has {numberOfEggsPlayerTwo} eggs left.");
                            return;
                        }
                        break;
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine($"Player one has {numberOfEggsPlayerOne} eggs left.");
            Console.WriteLine($"Player two has {numberOfEggsPlayerTwo} eggs left.");
        }
    }
}
