using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 2);

            Console.WriteLine(empCheck);

            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee present");
            else
                Console.WriteLine("Employee not present");
        }
    }
}
