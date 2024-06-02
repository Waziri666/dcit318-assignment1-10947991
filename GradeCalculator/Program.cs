using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade (0-100): ");
            int grade = int.Parse(Console.ReadLine());

            string letterGrade = grade >= 90 ? "A" :
                                 grade >= 80 ? "B" :
                                 grade >= 70 ? "C" :
                                 grade >= 60 ? "D" : "F";

            Console.WriteLine($"The letter grade is: {letterGrade}");
        }
    }
}
