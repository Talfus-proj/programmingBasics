using System;

namespace FINALEXAM06
{
    class FINALEXAM06
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int firstDig = num % 10;
            int secondDig = (num / 10) % 10;
            int thirdDig = (num / 100) % 10;
            for (int a = 1; a <= firstDig; a++)
            {
                for (int b = 1; b <= secondDig; b++)
                {
                    for (int c = 1; c <= thirdDig; c++)
                    {
                        int result = a * b * c;
                        Console.WriteLine($"{a} * {b} * {c} = {result};");

                    }
                }
            }
        }
    }
}

