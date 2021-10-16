using System;
using System.Collections.Generic;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            getAverage(getInput());
        }

        private static double[] getInput()
        {
            Console.WriteLine("Enter 5 Grades seperated by new line:");
            List<double> grades = new List<double>();
            while (grades.Count < 5)
            {
                double input;
                if (double.TryParse(Console.ReadLine(), out input)) grades.Add(input);
                else Console.WriteLine("Please enter a valid number");
            }
            return grades.ToArray();
        }

        private static void getAverage(double[] grades)
        {
            double average = 0;
            foreach (double grade in grades) average += grade;
            average /= grades.Length;
            Console.WriteLine($"the average is {average} and round off to {Math.Round(average)}");
        }
    }
}
