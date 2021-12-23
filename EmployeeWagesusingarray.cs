using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10EmployeeWageUc7_uc14
{
    class EmployeeWagesusingarray
    {
        public const int FULLTIME = 1;
        public const int PARTTIME = 2;

        private int NumberOfCompany = 0;

        private ComapnyEmpWage[] companyEmpWageArray;
        public EmployeeWagesusingarray()
        {
            this.companyEmpWageArray = new ComapnyEmpWage[5];

        }
        public void AddcompanyEmpWage(string company, int EmpRatePerHour, int numOFWorkingDays, int maxHourPerMOnth)
        {
            companyEmpWageArray[this.NumberOfCompany] = new ComapnyEmpWage(company, EmpRatePerHour, numOFWorkingDays, maxHourPerMOnth);
            NumberOfCompany++;  
        }
        public void computeEmpWage()
        {

            for (int i = 0; i < NumberOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int computeEmpWage(ComapnyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalEmpgHr = 0;
            int totalWorkingDays = 0;
            while (totalEmpgHr <= companyEmpWage.maxOfHoursPerMonth && totalWorkingDays <= companyEmpWage.maxOfHoursPerMonth)
            {
                totalWorkingDays++;

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
                totalEmpgHr += empHrs;
                Console.WriteLine("day#: " + totalWorkingDays + "Emo hrs: " + empHrs);


            }
            return totalEmpgHr * companyEmpWage.EmpRatePerHour;
        }
    }
}
