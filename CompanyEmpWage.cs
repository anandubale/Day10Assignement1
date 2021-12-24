using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageuc11_14
{
    public class CompanyEmpWage
    {
        public string company;
        public int EmpRatePerHour;
        public int numOFWorkingDays;
        public int maxOfHoursPerMonth;
        public int TotalEmpWage;

        public CompanyEmpWage(string company, int EmpRatePerHour, int numOFWorkingDays, int MaxHourPerMOnth)
        {
            this.company = company;
            this.EmpRatePerHour = EmpRatePerHour;
            this.numOFWorkingDays = numOFWorkingDays;
            this.maxOfHoursPerMonth = maxOfHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.TotalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total EMployee is Wage for Company: " + this.company + "is: " + this.TotalEmpWage;
        }
    }
}
