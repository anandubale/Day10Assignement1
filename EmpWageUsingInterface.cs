using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10EmployeeWageUc7_uc14
{
    public interface IComputeEmpWage
    {
        public void AddCompanyEmpWage(string company, int EmpRatePerHour, int numOFWorkingDays, int maxHourPerMOnth);
        public void computeEmpWage();
        public int getTotalWage(string company);
    }
    public class ComapnyEmpWage
    {
        public string company;
        public int EmpRatePerHour;
        public int numOFWorkingDays;
        public int maxOfHoursPerMonth;
        public int TotalEmpWage;



        public ComapnyEmpWage(string company, int EmpRatePerHour, int numOFWorkingDays, int maxHourPerMOnth)
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
