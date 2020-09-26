using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Problem!");

            //Constants
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;

            //Variables
            int empHours = 0;
            int empWage = 0;

            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 3);

            //Check Employee Attendance
            if (empCheck == IS_FULL_TIME)
            {
                empHours = 8;
                Console.WriteLine("Employee is Present");
            }

            else if (empCheck == IS_PART_TIME)
            {
                empHours = 4;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                empHours = 0;
                Console.WriteLine("Employee is Absent");
            }

            //DailyEmployeeWage
           
            empWage = empHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
        }
    }
}
