using System;

namespace EmployeeWageuc11_14
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageBuilderUsingArray EmpwageBuilder = new EmployeeWageBuilderUsingArray();
            EmpwageBuilder.AddcompanyEmpWage("Dmart", 20, 2, 10);
            EmpwageBuilder.AddcompanyEmpWage("Relience", 10, 5, 13);
            EmpwageBuilder.AddcompanyEmpWage("JioShop", 10, 4, 20);
            EmpwageBuilder.computeEmpWage();

        }
    }
}
