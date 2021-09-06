using System;

namespace E79_Moving
{
    class E79_Moving
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int totalSpace = width * length * height;

            while (input != "Done")
            {
                int spaceRequired = int.Parse(input);
                totalSpace -= spaceRequired;

                if (totalSpace <= 0)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (totalSpace > 0)
            {
                Console.WriteLine($"{(totalSpace)} Cubic meters left.");

            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(totalSpace)} Cubic meters more.");

            }
        }
    }
}
