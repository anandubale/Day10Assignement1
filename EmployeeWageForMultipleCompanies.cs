using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10EmployeeWageUc7_uc14
{
    class EmployeeWageForMultipleCompanies
    {
        //Fields


        //Each COmpany has its own Wage Number of Working Days and Working Hours Per Month.
        //use class method with function parameters instead of class variables.
        int FullTime = 1;
        int HalfTIme = 2;


        int EmpRatePerHr;
        int WorkingDaysPerMonth;
        int EmpWorkingHrsPerMonth;
        string Name;

        //Constructor

        public EmployeeWageForMultipleCompanies(string Name, int RatePerHr, int NoOfWorkingDays, int WorkingHrs)
        {
            this.Name = Name;
            this.EmpRatePerHr = RatePerHr;
            this.WorkingDaysPerMonth = NoOfWorkingDays;
            this.EmpWorkingHrsPerMonth = WorkingHrs;

        }

        int WorkingHrs;
        int empWage = 0;
        Random random = new Random();
        int totalEmpWage = 0;

        //Methods
        public void Solution()
        {
            int empWage;
            int totalEmpWage = 0;
            int empHrs = 0;
            int totalWorlkingHr = 0;
            int day = 0;
            while (day <= WorkingDaysPerMonth || totalWorlkingHr <= EmpWorkingHrsPerMonth)
            {
                Random random = new Random();
                int empCheck = random.Next(1, 4);
                switch (empCheck)
                {
                    case 1:
                        Console.WriteLine("Employee is full Time");
                        empHrs = 8;
                        break;

                    case 2:
                        Console.WriteLine("Employee is Part Time");

                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");

                        empHrs = 0;
                        break;

                }
                empWage = empHrs * EmpRatePerHr;
                totalEmpWage += empWage;
                totalWorlkingHr += empHrs;
                Console.WriteLine("Total Emp Hr : " + totalWorlkingHr);
                Console.WriteLine("Employee Wage : " + empWage);

                day++;

                totalWorlkingHr++;


            }
            Console.WriteLine("For company Name : " + Name);

            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            Console.WriteLine("Total Emp Hr : " + totalWorlkingHr);

        }
    }
}
