using System;

namespace E85_Cake
{
    class E85_Cake
    {
        static void Main()
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int totalCake = cakeLength * cakeWidth;

            while (input != "STOP")
            {
                totalCake -= int.Parse(input);
                
                if (totalCake <= 0) 
                { 
                    break; 
                }

                input = Console.ReadLine();
            }

            if (totalCake > 0)
            {
                Console.WriteLine($"{totalCake} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalCake)} pieces more.");
            }
        }
    }
}
