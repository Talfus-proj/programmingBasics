using System;

namespace E22_PasswordGuess
{
    class E22_PasswordGuess
    {
        static void Main()
        {
            string Password = Console.ReadLine();

            if (Password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
