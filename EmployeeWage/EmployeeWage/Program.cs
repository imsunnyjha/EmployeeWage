using System;
using EmployeeWage.Wage;
using EmployeeWage.CompanyInterface;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageBuilder empWageBuilder = new EmployeeWageBuilder();
            empWageBuilder.addCompanyEmpWage("BridgeLabz", 30, 10, 12);
            empWageBuilder.addCompanyEmpWage("Capgemini", 50, 15, 15);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage for BridgeLabz company : " + empWageBuilder.getTotalWage("BridgeLabz"));
        }
    }
}
