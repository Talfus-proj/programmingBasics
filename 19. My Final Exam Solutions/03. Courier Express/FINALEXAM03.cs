using System;

namespace FINALEXAM03
{
    class FINALEXAM03
    {
        static void Main()
        {
            //            1.Тегло на пратката в килограми – реално число в интервала[0.01... 150.00]
            //2.Тип услуга –  текст със следните възможности: "standard" или "express"
            //3.Разстояние в километри – цяло число в интервала[1... 1000]

            double weightOfPackage = double.Parse(Console.ReadLine());
            string typeOfDelivery = Console.ReadLine();
            double distanceInKilometers = double.Parse(Console.ReadLine());

            double expensePerKilometer = 0;
            double additionalPercent = 0;

            switch (typeOfDelivery)
            {
                case "standard":
                    if (weightOfPackage < 1)
                    {
                        expensePerKilometer = 0.03;
                    }
                    else if (weightOfPackage >= 1 && weightOfPackage < 10)
                    {
                        expensePerKilometer = 0.05;
                    }
                    else if (weightOfPackage >= 10 && weightOfPackage < 40)
                    {
                        expensePerKilometer = 0.10;
                    }
                    else if (weightOfPackage >= 40 && weightOfPackage < 90)
                    {
                        expensePerKilometer = 0.15;
                    }
                    else if (weightOfPackage >= 90 && weightOfPackage < 150)
                    {
                        expensePerKilometer = 0.20;
                    }

                    break;

                case "express":
                    if (weightOfPackage < 1)
                    {
                        expensePerKilometer = 0.03;
                        additionalPercent = expensePerKilometer * 0.80;

                    }
                    else if (weightOfPackage >= 1 && weightOfPackage < 10)
                    {
                        expensePerKilometer = 0.05;
                        additionalPercent = expensePerKilometer * 0.40;
                    }
                    else if (weightOfPackage >= 10 && weightOfPackage < 40)
                    {
                        expensePerKilometer = 0.10;
                        additionalPercent = expensePerKilometer * 0.05;
                    }
                    else if (weightOfPackage >= 40 && weightOfPackage < 90)
                    {
                        expensePerKilometer = 0.15;
                        additionalPercent = expensePerKilometer * 0.02;
                    }
                    else if (weightOfPackage >= 90 && weightOfPackage < 150)
                    {
                        expensePerKilometer = 0.20;
                        additionalPercent = expensePerKilometer * 0.01;
                    }
                    break;
            }

            double expressFinal = (distanceInKilometers * expensePerKilometer);
            double expressFinal2 = additionalPercent * weightOfPackage;
            expressFinal2 = expressFinal2 * distanceInKilometers;
            double totalExpress = expressFinal + expressFinal2;
            


            if (typeOfDelivery == "standard")
            {
                Console.WriteLine($"The delivery of your shipment with weight of {weightOfPackage:f3} kg. would cost {(distanceInKilometers * expensePerKilometer):f2} lv.");
            }
            else
            {
                Console.WriteLine($"The delivery of your shipment with weight of {weightOfPackage:f3} kg. would cost {totalExpress:f2} lv.");
            }

        }
    }
}
