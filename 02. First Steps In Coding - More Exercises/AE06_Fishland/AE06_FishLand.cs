using System;

namespace АЕ06_FishLand
{
    class AE06_FishLand
    {
        static void Main()
        {
            double priceOfSkumriaPerKilogram = double.Parse(Console.ReadLine());
            double priceOfSCacaPerKilogram = double.Parse(Console.ReadLine());
            double kilogramOfPalamud = double.Parse(Console.ReadLine());
            double kilogramOfSafrid = double.Parse(Console.ReadLine());
            double kilogramOfMidi = double.Parse(Console.ReadLine());

            double palamudPrice = priceOfSkumriaPerKilogram * 1.60;
            double sumOfPalamud = palamudPrice * kilogramOfPalamud;

            double safridPrice = priceOfSCacaPerKilogram * 1.80;
            double sumOfSafrid = safridPrice * kilogramOfSafrid;
            double midiPrice = kilogramOfMidi * 7.50;

            double totalAmount = sumOfPalamud + sumOfSafrid + midiPrice;

            Console.WriteLine($"{totalAmount:f2}");
        }
    }
}
