using System;
using EmployeeWage.Company;
using EmployeeWage.Wage;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeCompany employeeCompany = new EmployeeCompany();
            employeeCompany.addCompanyEmpWage("BridgeLabz", 30, 10, 12);
            employeeCompany.addCompanyEmpWage("Capgemini", 50, 15, 15);
            employeeCompany.computeEmpWage();
        }
    }
}
