using System;

namespace E13_VacationBookList
{
    class E13_VacationBookList
    {
        static void Main()
        {
            int pageNumber = int.Parse(Console.ReadLine());
            double pagesForHour = double.Parse(Console.ReadLine());
            int daysToReadTheBook = int.Parse(Console.ReadLine());

            double totalTimeToRead = pageNumber / pagesForHour;

            double hoursPerDay = totalTimeToRead / daysToReadTheBook;

            Console.WriteLine(hoursPerDay);
        }
    }
}
