using System;

namespace EmployeeWage
{
    class Program
    {
        //Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        
        public static int computeEmpWage(string company, int empRatePerHour, int noOfWorkingDays, int maxMonthlyHours)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Problem!");

            //Variables
            int empHours;
            int totalEmpHours = 0;
            int totalWorkingDays = 0;

            while (totalEmpHours <= maxMonthlyHours && totalWorkingDays < noOfWorkingDays)
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
            int totalEmpWage = totalEmpHours * empRatePerHour;
            Console.WriteLine("Total Working Days: " + totalWorkingDays + " Total Emp Hours: " + totalEmpHours);
            Console.WriteLine("Total Employee Wage for Company " +company+ " is " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("BridgeLabz", 30, 10, 12);
            computeEmpWage("Capgemini", 50, 15, 15);
        }
    }
}
