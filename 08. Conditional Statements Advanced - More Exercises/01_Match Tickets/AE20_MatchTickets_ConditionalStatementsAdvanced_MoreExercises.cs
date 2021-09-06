using System;

namespace AE20_MatchTickets_ConditionalStatementsAdvanced_MoreExercises
{
    class AE20_MatchTickets_ConditionalStatementsAdvanced_MoreExercises
    {
        static void Main()
        {
            const double VIP_TICKET = 499.99;
            const double NORMAL_TICKET = 249.99;

            double budgetAmount = double.Parse(Console.ReadLine());
            string ticketCategorie = Console.ReadLine();
            int numberOfPeopleInGroup = int.Parse(Console.ReadLine());

            double budgetAfterDiscount = 0;
            double priceOfTicket = 0;

            switch (ticketCategorie)
            {
                case "VIP":

                    if (numberOfPeopleInGroup >= 1 && numberOfPeopleInGroup <= 4)
                    {
                        budgetAfterDiscount = budgetAmount * 0.25;
                    }

                    else if (numberOfPeopleInGroup >= 5 && numberOfPeopleInGroup <= 9)
                    {
                        budgetAfterDiscount = budgetAmount * 0.40;
                    }
                    else if (numberOfPeopleInGroup >= 10 && numberOfPeopleInGroup <= 24)
                    {
                        budgetAfterDiscount = budgetAmount * 0.50;
                    }
                    else if (numberOfPeopleInGroup >= 25 && numberOfPeopleInGroup <= 49)
                    {
                        budgetAfterDiscount = budgetAmount * 0.60;
                    }

                    else if (numberOfPeopleInGroup >= 50)
                    {
                        budgetAfterDiscount = budgetAmount * 0.75;
                    }

                    priceOfTicket = VIP_TICKET * numberOfPeopleInGroup;

                    break;

                case "Normal":

                    if (numberOfPeopleInGroup >= 1 && numberOfPeopleInGroup <= 4)
                    {
                        budgetAfterDiscount = budgetAmount * 0.25;
                    }

                    else if (numberOfPeopleInGroup >= 5 && numberOfPeopleInGroup <= 9)
                    {
                        budgetAfterDiscount = budgetAmount * 0.40;
                    }
                    else if (numberOfPeopleInGroup >= 10 && numberOfPeopleInGroup <= 24)
                    {
                        budgetAfterDiscount = budgetAmount * 0.50;
                    }
                    else if (numberOfPeopleInGroup >= 25 && numberOfPeopleInGroup <= 49)
                    {
                        budgetAfterDiscount = budgetAmount * 0.60;
                    }

                    else if (numberOfPeopleInGroup >= 50)
                    {
                        budgetAfterDiscount = budgetAmount * 0.75;
                    }

                    priceOfTicket = NORMAL_TICKET * numberOfPeopleInGroup;

                    break;
            }

            if (priceOfTicket < budgetAfterDiscount)
            {
                Console.WriteLine($"Yes! You have {(budgetAfterDiscount - priceOfTicket):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(priceOfTicket - budgetAfterDiscount):f2} leva.");
            }


        }
    }
}
