using System;

namespace EmployeeWage
{
    class Program
    {
        //Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NO_OF_WORKING_DAYS = 20;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Problem!");

            //Variables
            int empHours = 0;
            int empWage = 0;
            int monthlyWage = 0;

            for (int day = 0; day < NO_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();

                //Computation
                int empCheck = random.Next(0, 3);

                //Check Employee Attendance and WorkHours using Switch Case
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHours = 8;
                        Console.WriteLine("Full Time Employee is Present");
                        break;

                    case IS_PART_TIME:
                        empHours = 4;
                        Console.WriteLine("Part Time Employee is Present");
                        break;

                    default:
                        empHours = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }

                //DailyEmployeeWage

                empWage = empHours * EMP_RATE_PER_HOUR;
                monthlyWage += empWage;
                Console.WriteLine("Emp Wage: " + empWage);
            }
            Console.WriteLine("Total Monthly Wage: " + monthlyWage);
        }
    }
}
