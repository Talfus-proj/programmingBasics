using System;

namespace EXAM14_TennisEquipment
{
    class EXAM14_TennisEquipment
    {
        static void Main()
        {

            double priceOfRocket = double.Parse(Console.ReadLine());
            double numberTennisRockets = double.Parse(Console.ReadLine());
            double numberOfPairSneakers = double.Parse(Console.ReadLine());

            double priceOfFinalRockets = priceOfRocket * numberTennisRockets;
            double discountSneakers = priceOfRocket / 6;
            double priceOfPairSneakers = numberOfPairSneakers * discountSneakers;
            double priceOfOtherEquipment = (priceOfFinalRockets + priceOfPairSneakers) * 0.2;
            double totalAmount = priceOfFinalRockets + priceOfPairSneakers + priceOfOtherEquipment;

            double djokovicPrice = totalAmount / 8;
            double sponsorPrice = (totalAmount * 7) / 8;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(djokovicPrice)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsorPrice)}");

        }
    }
}
