using System;

namespace empwageassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1, empHrs, empRatePerHr = 20, salary;
            Random rand = new Random();
            int randomCheck = rand.Next(0, 2);
            if (randomCheck == isPresent)
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
