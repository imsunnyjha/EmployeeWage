using System;
using System.Collections.Generic;
using System.Text;
using EmployeeWage.Company;

namespace EmployeeWage.Wage
{
    class CompanyWage
    {
        public string company;
        public int empRatePerHour;
        public int noOfWorkingDays;
        public int maxMonthlyHours;
        public int totalEmpWage;

        public CompanyWage(string company, int empRatePerHour, int noOfWorkingDays, int maxMonthlyHours)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxMonthlyHours = maxMonthlyHours;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for Company " + this.company + " is:" + this.totalEmpWage;
        }
    }
}
