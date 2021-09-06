using System;

namespace E04_InchesToCentimeters
{
    class E04_InchesToCentimeters
    {
        static void Main()
        {
           

            Console.Write("Enter your Inches: ");

            var inches = double.Parse(Console.ReadLine());

            var centimeters = inches * 2.54;

            Console.Write("Your Centimeters result is: ");

            Console.WriteLine(centimeters + "cm");

        }
    }
}
