using System;

namespace AE15_Firm
{
    class AE15_Firm
    {
        static void Main()
        {
            double requiredHours = double.Parse(Console.ReadLine());
            double numberOfDaysCompanyHas = double.Parse(Console.ReadLine());
            double numberOfOohEmployees = double.Parse(Console.ReadLine());

            double minusPercentWorkDays = (numberOfDaysCompanyHas * 0.90) * 8;

            double employeesDoingOvertime = numberOfOohEmployees * (numberOfDaysCompanyHas * 2);

            double totalHours = minusPercentWorkDays + employeesDoingOvertime;

            if (totalHours >= requiredHours)
            {
                Console.WriteLine($"Yes!{Math.Floor(totalHours - requiredHours)} hours left.");
            }
            else if (requiredHours > totalHours)
            {
                Console.WriteLine($"Not enough time!{Math.Ceiling(requiredHours - totalHours)} hours needed.");
            }
        }
    }
}
