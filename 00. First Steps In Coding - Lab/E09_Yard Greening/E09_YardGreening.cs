using System;

namespace E09_YardGreening
{
    class E09_YardGreening
    {
        static void Main()
        {

            double squareMeter = double.Parse(Console.ReadLine());

            squareMeter = squareMeter * 7.61;

            double discountPrice = squareMeter * 0.18;

            double finalprice = squareMeter - discountPrice;

            Console.WriteLine("The final price is: " + finalprice + " lv.");
            Console.WriteLine("The discount is: " + discountPrice + " lv.");

        }
    }
}
