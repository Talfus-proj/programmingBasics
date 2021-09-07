using System;

namespace FINALEXAM01
{
    class FINALEXAM01
    {
        static void Main()
        {
            double processor = double.Parse(Console.ReadLine());
            double videocard = double.Parse(Console.ReadLine());
            double ram = double.Parse(Console.ReadLine());
            double numberRam = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double priceProcessor = processor * 1.57;
            double priceCard = videocard * 1.57;
            double priceRAM = ram * 1.57;
            priceRAM *= numberRam;

            double priceAfterDiscountProcessor = priceProcessor - ( priceProcessor * discount);
            double priceAfterDiscountVideocard = priceCard - ( priceCard * discount);

            double total = priceAfterDiscountProcessor + priceAfterDiscountVideocard + priceRAM;

            Console.WriteLine($"Money needed - {total:f2} leva.");
        }
    }
}
