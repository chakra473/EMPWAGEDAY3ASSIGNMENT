using System;

namespace empwageassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            int isAbsent = 0;
            Random random = new Random();
            int randomCheck = random.Next(0, 2);
            if (randomCheck == isAbsent)
            {
                Console.WriteLine("EMPLOYEE IS ABSENT");
            }
            else
            {
                Console.WriteLine("EMPLOYEE IS PRESENT");

            }
        }
    }
}
