using System;

namespace Day10EmployeeWageUc7_uc14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Company Name: ");
            string Name = Console.ReadLine();


            Console.WriteLine("Enter Rate Per hour for Company");
            int EmpRatePerHr = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Woriking days per month");
            int WorkingDaysPerMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter working hours per week");
            int EmpWorkingHrs = int.Parse(Console.ReadLine());

            EmployeeWageForMultipleCompanies c1 = new EmployeeWageForMultipleCompanies(Name, EmpRatePerHr, WorkingDaysPerMonth, EmpWorkingHrs);
            c1.Solution();


        }
    }
}
