using System;

namespace empwageassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage calculation!");
            EmpWageBuilderObject dmart = new EmpWageBuilderObject("dmart", 200, 25, 200);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("reliance", 250, 30, 300);
            dmart.EmpWageCalculation();
            Console.WriteLine(dmart.toString());
            reliance.EmpWageCalculation();
            Console.WriteLine(reliance.toString());
           
        }
        
    }
}
