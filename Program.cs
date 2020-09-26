using Microsoft.VisualBasic.CompilerServices;
using System;




namespace usecase2
{


    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        static void Main(string[] args)
        {

            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 2);

            //if (empCheck == IS_FULL_TIME)
            //{
            //    empHrs = 8;
            //}
            //else
            //{
            //    empHrs = 0;
            //}

            switch (empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default :   
                    empHrs=0;
                    break;


            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);

        }
    }
}