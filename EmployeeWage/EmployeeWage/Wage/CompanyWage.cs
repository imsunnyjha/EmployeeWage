using System;
using System.Collections.Generic;
using System.Text;
using EmployeeWage.CompanyInterface;

namespace EmployeeWage.Wage
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int noOfWorkingDays, int maxMonthlyHours);
        public void computeEmpWage();
        public int getTotalWage(string company);

    }
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
            this.totalEmpWage = 0;
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
