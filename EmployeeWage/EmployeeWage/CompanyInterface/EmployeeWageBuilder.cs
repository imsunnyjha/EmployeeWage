using System;
using System.Collections.Generic;
using System.Text;
using EmployeeWage.Wage;

namespace EmployeeWage.CompanyInterface
{
    public class EmployeeWageBuilder:IComputeEmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private LinkedList<CompanyWage> companyWageList;
        private Dictionary<string, CompanyWage> compantToEmpWageMap;

        public EmployeeWageBuilder()
        {
            this.companyWageList = new LinkedList<CompanyWage>();
            this.compantToEmpWageMap = new Dictionary<string, CompanyWage>();
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int noOfWorkingDays, int maxMonthlyHours)
        {
           CompanyWage companyWage = new CompanyWage(company, empRatePerHour, noOfWorkingDays, maxMonthlyHours);
            this.companyWageList.AddLast(companyWage);
            this.compantToEmpWageMap.Add(company, companyWage);
        }
        public void computeEmpWage()
        {
            foreach(CompanyWage companyWage in this.companyWageList)
            {
                companyWage.setTotalEmpWage(this.computeEmpWage(companyWage));
                Console.WriteLine(companyWage.toString());
            }
        }
        private int computeEmpWage(CompanyWage companyWage)
        {
            //Variables
            int empHours = 0;
            int totalEmpHours = 0;
            int totalWorkingDays = 0;

            while (totalEmpHours <= companyWage.maxMonthlyHours && totalWorkingDays < companyWage.noOfWorkingDays)
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
                Console.WriteLine("Total Working Days: " + totalWorkingDays + " Total Emp Hours: " + totalEmpHours);
            }
            return totalEmpHours * companyWage.empRatePerHour;
        }
        
        public int getTotalWage(string company)
        {
            return this.compantToEmpWageMap[company].totalEmpWage;
        }

    }
}
