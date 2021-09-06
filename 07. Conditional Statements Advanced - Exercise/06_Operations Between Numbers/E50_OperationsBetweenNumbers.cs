using System;

namespace E50_OperationsBetweenNumbers
{
    class E50_OperationsBetweenNumbers
    {
        static void Main()
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            string whatOperationToDo = Console.ReadLine();

            double result = 0;

            if (whatOperationToDo == "+")
            {
                result = number1 + number2;
            }
            else if (whatOperationToDo == "-")
            {
                result = number1 - number2;
            }
            else if (whatOperationToDo == "*")
            {
                result = number1 * number2;
            }

            if (whatOperationToDo == "+" || whatOperationToDo == "-" || whatOperationToDo == "*")
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} {whatOperationToDo} {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} {whatOperationToDo} {number2} = {result} - odd");
                }

            }

            switch (whatOperationToDo)
            {
                case "/":
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        result = number1 / number2;
                        Console.WriteLine($"{number1} / {number2} = {result:f2}");
                    }
                    break;
                case "%":
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        result = number1 % number2;
                        Console.WriteLine($"{number1} % {number2} = {result}");
                    }
                    break;
            }
            

        }
    }
}
