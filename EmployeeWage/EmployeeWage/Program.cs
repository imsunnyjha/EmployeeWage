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
        public const int MAX_MONTHLY_HOURS = 100;


        public static int computeEmpWage()
        {
            Console.WriteLine("Welcome To Employee Wage Computation Problem!");

            //Variables
            int empHours;
            int totalEmpHours = 0;
            int totalWorkingDays = 0;

            while (totalEmpHours <= MAX_MONTHLY_HOURS && totalWorkingDays < NO_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();

                //Computation
                int empCheck = random.Next(0, 3);

                //Check Employee Attendance and WorkHours using Switch Case
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHours = 8;
                        break;

                    case IS_PART_TIME:
                        empHours = 4;
                        break;

                    default:
                        empHours = 0;
                        break;
                }

                //DailyEmployeeWage
                totalEmpHours += empHours;
            }
            int totalEmpWage = totalEmpHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Days: " + totalWorkingDays + " Total Emp Hours: " + totalEmpHours);
            Console.WriteLine("Total Employee Wage: " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage();
        }
    }
}
