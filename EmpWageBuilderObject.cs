using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empwageassignment
{
    internal class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public string Company;
        public int NumberOfWorkingDays;
        public int MaxWorkingHrs;
        public int RatePerHr;
        public int TotalSalary=0;
        public EmpWageBuilderObject(string company, int ratePerHr, int numOfWorkingDays, int maxWorkingHrs)
        {
            this.Company = company;
            this.RatePerHr = ratePerHr;
            this.NumberOfWorkingDays = numOfWorkingDays;
            this.MaxWorkingHrs = maxWorkingHrs;
        }
        public  void EmpWageCalculation()
        {
            int  randomCheck, totalSalary = 0, salary, day = 1, empHrs = 0;
            while (day <= this.NumberOfWorkingDays && empHrs <= this.MaxWorkingHrs)
            {
                Random random = new Random();
                randomCheck = random.Next(0, 3);
                switch (randomCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                salary = empHrs * this.RatePerHr;
                totalSalary = totalSalary + salary;
                Console.WriteLine($"totalsalary after day{day} is {totalSalary}");
                day++;
            }
            this.TotalSalary = totalSalary;
        }
        public  string toString()
        {
            string result= "total emp wage for company " + this.Company + " is " + this.TotalSalary;
            return result;
        }
    }
}
