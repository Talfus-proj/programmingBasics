using System;

namespace E71_ReadText_WhileLoop_Lab
{
    class E71_ReadText_WhileLoop_Lab
    {
        static void Main()
        {

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                Console.WriteLine(input);
            }
        }
    }
}
