using System;

namespace empwageassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPartTime = 1, randomCheck, isFullTime = 2, totalSalary = 0, salary, ratePerHr = 20, numOfWorkingDays = 20, day = 1, empHrs;
            while (day <= numOfWorkingDays)
            {
                Random random = new Random();
                randomCheck = random.Next(0, 3);
                switch (randomCheck)
                {
                    case 2:
                        empHrs = 8;
                        break;

                    case 1:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                salary = empHrs * ratePerHr;
                totalSalary = totalSalary + salary;
                Console.WriteLine($"totalsalary after day{day} is {totalSalary}");
                day++;
            }
        }
    }
}
