using System;

namespace E17_FishTank
{
    class E17_FishTank
    {
        static void Main()
        {
            var lengthInCentimeters = int.Parse(Console.ReadLine());
            var widthInCentimeters = int.Parse(Console.ReadLine());
            var heightInCentimeters = int.Parse(Console.ReadLine());
            var percentage = double.Parse(Console.ReadLine());

            var volumeOfTheTankInCent = lengthInCentimeters * widthInCentimeters * heightInCentimeters;
            var volumeOfTheTankInLiters = volumeOfTheTankInCent * (1.0 / 1000.0);
            var percentageInRealNumbers = percentage * (1.0 / 100);
            var neededLiters = volumeOfTheTankInLiters * (1.0 - percentageInRealNumbers);

            Console.WriteLine($"{neededLiters:f5}");
        }
    }
}
