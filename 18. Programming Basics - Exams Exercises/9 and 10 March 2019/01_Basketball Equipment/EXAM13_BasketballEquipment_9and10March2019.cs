using System;

namespace EXAM13_BasketballEquipment_9and10March2019
{
    class EXAM13_BasketballEquipment_9and10March2019
    {
        static void Main()
        {
            double priceForYear = double.Parse(Console.ReadLine());

            double basketballSneakers = priceForYear * 0.60;
            double basketballPack = basketballSneakers * 0.80;
            double basketball = basketballPack * 0.25;
            double basketAccessory = basketball * 0.20;

            double totalAmount = priceForYear + basketballSneakers + basketballPack + basketball + basketAccessory;

            Console.WriteLine($"{totalAmount:f2}");
        } 
    }
}
