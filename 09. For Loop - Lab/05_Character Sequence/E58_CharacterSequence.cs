using System;

namespace E58_CharacterSequence
{
    class E58_CharacterSequence
    {
        static void Main()
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                Console.WriteLine(letter);
            }
        }
    }
}
