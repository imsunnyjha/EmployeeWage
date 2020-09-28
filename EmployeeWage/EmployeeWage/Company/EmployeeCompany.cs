using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage.Company
{
        public class EmployeeCompany
        {
            //Constants
            public const int IS_FULL_TIME = 1;
            public const int IS_PART_TIME = 2;

            private string company;
            private int empRatePerHour;
            private int noOfWorkingDays;
            private int maxMonthlyHours;
            private int totalEmpWage;

            public EmployeeCompany(string company, int empRatePerHour, int noOfWorkingDays, int maxMonthlyHours)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.noOfWorkingDays = noOfWorkingDays;
                this.maxMonthlyHours = maxMonthlyHours;
            }

            public void computeEmpWage()
            {
                //Variables
                int empHours = 0;
                int totalEmpHours = 0;
                int totalWorkingDays = 0;

                while (totalEmpHours <= this.maxMonthlyHours && totalWorkingDays < this.noOfWorkingDays)
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
                totalEmpWage = totalEmpHours * this.empRatePerHour;
                Console.WriteLine("Total Working Days: " + totalWorkingDays + " Total Emp Hours: " + totalEmpHours);
                Console.WriteLine("Total Employee Wage for Company " + company + " is " + totalEmpWage);
            }

            public string toString()
            {
                return "Total Emp Wage for Company " + this.company + " is:" + this.totalEmpWage;
            }

        }
}
