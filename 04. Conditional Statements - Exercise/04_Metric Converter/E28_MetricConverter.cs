using System;

namespace E28_MetricConverter
{
    class E28_MetricConverter
    {
        static void Main()
        {
            double convertNumber = double.Parse(Console.ReadLine());
            string inputValue = Console.ReadLine();
            string outputValue = Console.ReadLine();

            if (inputValue == "mm" && outputValue == "m")
            {
                convertNumber /= 1000;
            }
            else if (inputValue == "m" && outputValue == "mm")
            {
                convertNumber *= 1000;
            }
            else if (inputValue == "cm" && outputValue == "m")
            {
                convertNumber /= 100;
            }
            else if (inputValue == "m" && outputValue == "cm")
            {
                convertNumber *= 100;
            }
            else if (inputValue == "mm" && outputValue == "cm")
            {
                convertNumber /= 10;
            }
            else if (inputValue == "cm" && outputValue == "mm")
            {
                convertNumber *= 10;
            }

            Console.WriteLine($"{convertNumber:f3}");
        }
    }
}
