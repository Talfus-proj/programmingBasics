using System;

namespace E08_PetShopExpenses
{
    class E08_PetShopExpenses
    {
        static void Main()
        {
            double myDogs = int.Parse(Console.ReadLine());
            myDogs = myDogs * 2.50;

            int neighbourDogs = int.Parse(Console.ReadLine());
            neighbourDogs = neighbourDogs * 4;

            double sum = myDogs + neighbourDogs;

            Console.WriteLine(sum + " lv.");

        }
    }
}
