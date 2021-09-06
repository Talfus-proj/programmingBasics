using System;

namespace AE07_HousePainting
{
    class AE07_HousePainting
    {
        static void Main()
        {
            double heightHouseX = double.Parse(Console.ReadLine());
            double lengthOfSideY = double.Parse(Console.ReadLine());
            double heightOfRoofH = double.Parse(Console.ReadLine());

            double sideWall = heightHouseX * lengthOfSideY;
            double windowSize = 1.5 * 1.5;

            double TotalTwoSides = (sideWall * 2) - (windowSize * 2);

            double backWall = heightHouseX * heightHouseX;
            double frontDoor = 1.2 * 2;

            double frontAndBack = (backWall * 2) - frontDoor;

            double totalArea = TotalTwoSides + frontAndBack;

            double greenPainting = totalArea / 3.4;

            double twoRoofRecrangle = (heightHouseX * lengthOfSideY) * 2;
            double twoRoofTriangle = ((heightHouseX * heightOfRoofH) / 2) * 2;
            
            double totalArea2 = twoRoofRecrangle + twoRoofTriangle;

            double redPaining = totalArea2 / 4.3;

            Console.WriteLine($"{greenPainting:f2}");
            Console.WriteLine($"{redPaining:f2}");
        }
    }
}
