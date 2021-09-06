using System;

namespace AE14_TransportPrice
{
    class AE14_TransportPrice
    {
        static void Main()
        {
            double numberOfKilometersN = int.Parse(Console.ReadLine());
            string whatPartofTheDay = Console.ReadLine();

            double travel = 0;

            if (numberOfKilometersN < 20)
            {
                if (whatPartofTheDay == "day")
                {
                    travel = (0.70 + (numberOfKilometersN * 0.79));
                }
                else if (whatPartofTheDay == "night")
                {
                    travel = (0.70 + (numberOfKilometersN * 0.90));
                }
            }
            else if (numberOfKilometersN >= 20 && numberOfKilometersN < 100)
            {
                if (whatPartofTheDay == "day" || whatPartofTheDay == "night")
                {
                    travel = numberOfKilometersN * 0.09;
                }
                
            }
            else if (numberOfKilometersN >= 100)
            {
                if (whatPartofTheDay == "day" || whatPartofTheDay == "night")
                {
                    travel = numberOfKilometersN * 0.06;
                }
                
            }

            Console.WriteLine($"{travel:f2}");
        }

    }
}
