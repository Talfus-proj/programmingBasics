using System;

namespace AE31_Hospital
{
    class AE31_Hospital
    {
        static void Main()
        {
            int daysPeriod = int.Parse(Console.ReadLine());
            int doctors = 7;
            int days = 1;
            double threated = 0;
            double nonThreated = 0;

            for (int i = 1; i <= daysPeriod; i++)
            {

                if (days % 3 == 0)
                {
                    if (nonThreated > threated)
                    {
                        doctors++;
                    }
                }

                double numberOfPatients = double.Parse(Console.ReadLine());

                if (numberOfPatients > doctors)
                {
                    threated += doctors;
                    nonThreated += numberOfPatients - doctors;
                }
                else
                {
                    threated += numberOfPatients;
                }
                days++;
            }

            Console.WriteLine($"Treated patients: {threated}.");
            Console.WriteLine($"Untreated patients: {nonThreated}.");
        }
    }
}
