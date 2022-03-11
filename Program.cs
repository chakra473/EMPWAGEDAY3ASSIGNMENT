using System;

namespace empwageassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPartTime = 1, IsFullTime = 2, empHrs, empRatePerHr = 20, salary, randomCheck;
            Random rand = new Random();
            randomCheck = rand.Next(0, 3);
            if (randomCheck == isPartTime)
            {
                empHrs = 4;
                salary = empHrs * empRatePerHr;
                Console.WriteLine($"salary is {salary}");
            }
            else if (randomCheck == IsFullTime)
            {
                empHrs = 8;
                salary = empHrs * empRatePerHr;
                Console.WriteLine($"salary is {salary}");
            }
            else
            {
                empHrs = 0;
                salary = empHrs * empRatePerHr;
                Console.WriteLine($"salary is {salary}");
            }
        }
    }
}
