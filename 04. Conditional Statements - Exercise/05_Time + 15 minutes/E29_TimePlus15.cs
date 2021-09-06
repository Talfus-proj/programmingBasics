using System;

namespace E29_TimePlus15
{
    class E29_TimePlus15
    {
        static void Main()
        {
            const int TIME_PLUS = 15;

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += TIME_PLUS;

            if (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
            }

            if (hours >= 24)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
