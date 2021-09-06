using System;

namespace E38_WorkingHours
{
    class E38_WorkingHours
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string dayOfTheWeek = Console.ReadLine();

            if (number >= 10 && number <= 18)
            {
                switch (dayOfTheWeek)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday": Console.WriteLine("open");break;

                    default:
                        Console.WriteLine("closed");
                        break;
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
