using System;

namespace E12_DepositCalculator
{
    class E12_DepositCalculator
    {
        static void Main()
        {
            int deposit = int.Parse(Console.ReadLine());
            int durationOfDeposit = int.Parse(Console.ReadLine());
            double yearlyInterest = double.Parse(Console.ReadLine());


            double interestPercent = deposit * yearlyInterest / 100;
            double interestForAMonth = interestPercent / 12;

            double totalSum = deposit + durationOfDeposit * interestForAMonth;

            Console.WriteLine(totalSum);
        }
    }
}
