using System;

namespace E15_CharityCampaign
{
    class E15_CharityCampaign
    {
        static void Main()
        {
            const int PRICE_OF_CAKE = 45;
            const double PRICE_OF_WAFFLE = 5.80;
            const double PRICE_OF_PANCAKE = 3.20;

            int campaignDays = int.Parse(Console.ReadLine());
            int numberOfBakers = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());

            double cakes = numberOfCakes * PRICE_OF_CAKE;
            double waffles = numberOfWaffles * PRICE_OF_WAFFLE;
            double pancake = numberOfPancakes * PRICE_OF_PANCAKE;

            double totalSumForADay = (cakes + waffles + pancake)*numberOfBakers;

            double sumForWholeCampaign = totalSumForADay * campaignDays;

            double sumForCampaign = sumForWholeCampaign - ( sumForWholeCampaign / 8);

            Console.WriteLine(sumForCampaign);
        }
    }
}
