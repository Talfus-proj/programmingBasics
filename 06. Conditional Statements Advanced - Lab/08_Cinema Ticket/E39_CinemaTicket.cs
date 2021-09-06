using System;

namespace E39_CinemaTicket
{
    class E39_CinemaTicket
    {
        static void Main()
        {
            string dayOfTheWeek = Console.ReadLine();

            switch (dayOfTheWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Friday": Console.WriteLine("12");break;

                case "Wednesday":
                case "Thursday": Console.WriteLine("14");break;

                case "Saturday":
                case "Sunday": Console.WriteLine("16"); break;
            }
        }
    }
}
