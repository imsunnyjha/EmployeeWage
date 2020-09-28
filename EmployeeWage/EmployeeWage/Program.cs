using System;
using EmployeeWage.Company;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeCompany bridgeLabz = new EmployeeCompany("BridgeLabz", 30, 10, 12);
            EmployeeCompany capgemini = new EmployeeCompany("Capgemini", 50, 15, 15);
            bridgeLabz.computeEmpWage();
            Console.WriteLine(bridgeLabz.toString());
            capgemini.computeEmpWage();
            Console.WriteLine(capgemini.toString());
        }
    }
}
