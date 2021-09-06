using System;

namespace AE33_Grades
{
    class AE33_Grades
    {
        static void Main()
        {
            double numberOfStudents = double.Parse(Console.ReadLine());

            double totalGrades = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double numberOfExams = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                double numberOfExamScores = double.Parse(Console.ReadLine());

                if (numberOfExamScores >= 2.00 && numberOfExamScores <= 2.99)
                {
                    totalGrades += numberOfExamScores;
                    p1++;
                    numberOfExams++;
                }
                else if (numberOfExamScores >= 3.00 && numberOfExamScores <= 3.99)
                {
                    totalGrades += numberOfExamScores;
                    p2++;
                    numberOfExams++;
                }
                else if (numberOfExamScores >= 4.00 & numberOfExamScores <= 4.99)
                {
                    totalGrades += numberOfExamScores;
                    p3++;
                    numberOfExams++;
                }
                else if (numberOfExamScores >= 5.00)
                {
                    totalGrades += numberOfExamScores;
                    p4++;
                    numberOfExams++;
                }
            }

            double percentOne = (p1 / numberOfExams) * 100;
            double percentTwo = (p2 / numberOfExams) * 100;
            double percentThree = (p3 / numberOfExams) * 100;
            double percentFour = (p4 / numberOfExams) * 100;

            double avarageScore = totalGrades / numberOfExams;

            Console.WriteLine($"Top students: {percentFour:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentThree:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentTwo:f2}%");
            Console.WriteLine($"Fail: {percentOne:f2}%");
            Console.WriteLine($"Average: {avarageScore:f2}");
        }
    }
}
