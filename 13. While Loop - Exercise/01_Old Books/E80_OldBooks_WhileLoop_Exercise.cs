using System;

namespace E80_OldBooks_WhileLoop_Exercise
{
    class E80_OldBooks_WhileLoop_Exercise
    {
        static void Main()
        {

            string bookName = Console.ReadLine();

            int booksChecked = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "No More Books")
                {
                    break;
                }

                if (bookName == input)
                {
                    Console.WriteLine($"You checked {booksChecked} books and found it.");
                    return;
                }
                booksChecked++;
            }

            Console.WriteLine($"The book you search is not here!");
            Console.WriteLine($"You checked {booksChecked} books.");
        }
    }
}
