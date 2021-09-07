using System;

namespace EXAM05_EasterTrip
{
    class EXAM05_EasterTrip
    {
        static void Main()
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            double numberOfNights = double.Parse(Console.ReadLine());

            double expenses = 0;

            switch (dates)
            {
                case "21-23":
                    switch (destination)
                    {
                        case "France":
                            expenses = 30 * numberOfNights;
                            break;
                        case "Italy":
                            expenses = 28 * numberOfNights;
                            break;
                        case "Germany":
                            expenses = 32 * numberOfNights;
                            break;
                    }
                    break;
                case "24-27":
                    switch (destination)
                    {
                        case "France":
                            expenses = 35 * numberOfNights;
                            break;
                        case "Italy":
                            expenses = 32 * numberOfNights;
                            break;
                        case "Germany":
                            expenses = 37 * numberOfNights;
                            break;
                    }
                    break;
                case "28-31":
                    switch (destination)
                    {
                        case "France":
                            expenses = 40 * numberOfNights;
                            break;
                        case "Italy":
                            expenses = 39 * numberOfNights;
                            break;
                        case "Germany":
                            expenses = 43 * numberOfNights;
                            break;
                    }
                    break;
            }
            Console.WriteLine($"Easter trip to {destination} : {expenses:f2} leva.");
        }
    }
}
