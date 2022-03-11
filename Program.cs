using System;

namespace empwageassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPartTime = 1, isPresent = 2, empHrs, empRatePerHr = 20, salary;
            Random rand = new Random();
            int randomCheck = rand.Next(0, 3);
            switch (randomCheck)
            {
                case 1:
                    empHrs = 4;
                    break;
                case 2:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            salary = empRatePerHr * empHrs;
            Console.WriteLine($"salary is {salary}");
        }
    }
}
