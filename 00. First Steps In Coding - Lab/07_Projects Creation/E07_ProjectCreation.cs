using System;

namespace E07_ProjectCreation
{
    class E07_ProjectCreation
    {
        static void Main()
        {
            string name = Console.ReadLine();
      
            int number = int.Parse(Console.ReadLine());

            number = number * 3;

            int project = number / 3;

            Console.WriteLine($"The architect {name} will need {number} hours to complete {project} project/s.");

        }
    }
}
