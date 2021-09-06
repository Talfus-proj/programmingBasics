using System;

namespace E03_SquareArea
{
    class E03_SquareArea
    {
        static void Main()
        {
            Console.Write("Enter your number: ");

            var a = decimal.Parse(Console.ReadLine());

            a = a * a;

            Console.WriteLine(a);

            
        } 
    }
}
