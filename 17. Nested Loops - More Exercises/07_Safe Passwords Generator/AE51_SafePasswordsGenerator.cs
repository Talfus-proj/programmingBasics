using System;

namespace AE51_SafePasswordsGenerator
{
    class AE51_SafePasswordsGenerator
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int counter = 0;
            int i = 35;
            int j = 64;



            while (i <= 55)
            {
                while (j <= 96)
                {
                    for (int k = 1; k <= a; k++)
                    {
                        for (int l = 1; l <= b; l++)



                        {
                            char one = ((char)i);
                            char two = ((char)j);


                            Console.Write($"{one}{two}{k}{l}{two}{one}|");
                            counter += 1;
                            i++;
                            j++;


                            if (counter >= max)
                            {
                                return;
                            }
                            if (i > 55)
                            { 
                                i = 35; 
                            }
                            if (j > 96)
                            { 
                                j = 64; 
                            }
                            
                            if (k == a && l == b)
                            {
                                return;
                            }
                        }

                    }

                }

            }

        }
    }
}
