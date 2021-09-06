using System;

namespace E23_AreaOfFigures
{
    class E23_AreaOfFigures
    {
        static void Main()
        {
            string shape = Console.ReadLine();
            double area = 0;

            if (shape == "square") 
            { 
            double side = double.Parse(Console.ReadLine());
            area = side * side;
            }
            else if (shape == "rectangle")
            { 
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            area = sideA * sideB;
            }
            else if (shape == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());
                area = Math.PI * circleRadius * circleRadius;
            }
            else if(shape == "triangle")
            {
                double SideA = double.Parse(Console.ReadLine());
                double Height = double.Parse(Console.ReadLine());

                area = SideA * Height / 2;
            }
            //TODO: add more conditions
            Console.WriteLine(area);
        }
    }
}
