using System;

namespace E10_CurrencyConvertor_FirststepsExercises
{
    class E10_CurrencyConvertor_FirststepsExercises
    {
        static void Main()
        {
            const double USD_CURRENCY = 1.79549;

            double leva = double.Parse(Console.ReadLine());

            double convert = leva * USD_CURRENCY;

            Console.WriteLine(convert);

         
            
        }
    }
}
