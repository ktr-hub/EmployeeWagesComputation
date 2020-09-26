using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are now in Welcome page of Employee Wages");

            int IS_FULL_TIME = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 2);

            Console.WriteLine(empCheck);

            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is not present");

            int EMP_RATE_PER_HOUR = random.Next(0, 2);
            int empHrs = 0;

            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);

        }
    }
}