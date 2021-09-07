using System;

namespace EXAM18_WorldSnookerChampionship
{
    class EXAM18_WorldSnookerChampionship
    {
        static void Main()
        {
            string stageOfCompetition = Console.ReadLine();
            string ticketType = Console.ReadLine();
            double numberOfTickets = double.Parse(Console.ReadLine());
            string pictureWithTrophy = Console.ReadLine();

            double standard = 0;
            double premium = 0;
            double vip = 0;
            double totalTicketPrice = 0;

            switch (stageOfCompetition)
            {
                case "Quarter final":
                    switch (ticketType)
                    {
                        case "Standard":
                            standard = 55.50;
                            totalTicketPrice = standard * numberOfTickets;
                            break;
                        case "Premium":
                            premium = 105.20;
                            totalTicketPrice = premium * numberOfTickets;

                            break;
                        case "VIP":
                            vip = 118.90;
                            totalTicketPrice = vip * numberOfTickets;

                            break;
                    }

                    break;

                case "Semi final":
                    switch (ticketType)
                    {
                        case "Standard":
                            standard = 75.88;
                            totalTicketPrice = standard * numberOfTickets;

                            break;
                        case "Premium":
                            premium = 125.22;
                            totalTicketPrice = premium * numberOfTickets;

                            break;
                        case "VIP":
                            vip = 300.40;
                            totalTicketPrice = vip * numberOfTickets;

                            break;
                    }
                    break;

                case "Final":
                    switch (ticketType)
                    {
                        case "Standard":
                            standard = 110.10;
                            totalTicketPrice = standard * numberOfTickets;
                            break;
                        case "Premium":
                            premium = 160.66;
                            totalTicketPrice = premium * numberOfTickets;

                            break;
                        case "VIP":
                            vip = 400;
                            totalTicketPrice = vip * numberOfTickets;

                            break;
                    }
                    break;
            }

            if (totalTicketPrice > 4000)
            {
                totalTicketPrice *= 0.75;
            }
            else if (totalTicketPrice > 2500)
            {
                totalTicketPrice *= 0.90;
                if (pictureWithTrophy == "Y")
                {
                    double pictureExpenses = numberOfTickets * 40;
                    totalTicketPrice += pictureExpenses;
                }
            }
            else
            {
                if (pictureWithTrophy == "Y")
                {
                    double pictureExpenses = numberOfTickets * 40;
                    totalTicketPrice += pictureExpenses;
                }
            }

            Console.WriteLine($"{totalTicketPrice:f2}");
        }
    }
}
