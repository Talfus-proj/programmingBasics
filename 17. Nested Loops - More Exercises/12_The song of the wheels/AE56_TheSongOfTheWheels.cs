using System;

namespace AE56_TheSongOfTheWheels
{
    class AE56_TheSongOfTheWheels
    {
        static void Main()
        {
            int controlNum = int.Parse(Console.ReadLine());
            int counter = 0;
            int number = 0;
            int password1 = 0;
            int password2 = 0;
            int password3 = 0;
            int password4 = 0;
            bool flag = false;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            
                            if ((a * b) + (c * d) == controlNum)
                            {
                                if (a < b)
                                {
                                    if (c > d)
                                    {
                                        Console.Write($"{a}{b}{c}{d} ");
                                        counter++;
                                        if (counter == 4)
                                        {
                                            password1 = a;
                                            password2 = b;
                                            password3 = c;
                                            password4 = d;

                                            flag = true;
                                        }
                                        else if (counter == 0)
                                        {
                                            Console.WriteLine("No!");
                                            return;
                                        }
                                    }

                                }
                            }  

                            
                        }
                    }
                }
            }
            if (counter < 4)
            {
                Console.WriteLine();
                Console.WriteLine($"No!");
                return;
            }
            if (flag)
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {password1}{password2}{password3}{password4}");
            }
        }
    }
}
