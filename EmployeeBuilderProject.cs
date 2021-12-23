using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10EmployeeWageUc7_uc14
{


    class EmployeeBuilderProject : IComputeEmpWage
    {
        public const int FULLTIME = 1;
        public const int PARTTIME = 2;

        private LinkedList<ComapnyEmpWage> comapnyEmpWagesList;
        private Dictionary<string, ComapnyEmpWage> CompanyToEmpWageMap;

        public EmployeeBuilderProject()
        {
            this.comapnyEmpWagesList = new LinkedList<ComapnyEmpWage>();
            this.CompanyToEmpWageMap = new Dictionary<string, ComapnyEmpWage>();

        }

        public void AddCompanyEmpWage(string company, int EmpRatePerHour, int numOFWorkingDays, int maxHourPerMOnth)
        {

            ComapnyEmpWage comapnyEmpWage = new ComapnyEmpWage(company, EmpRatePerHour, numOFWorkingDays, maxHourPerMOnth);
            this.comapnyEmpWagesList.AddLast(comapnyEmpWage);
            this.CompanyToEmpWageMap.Add(company, comapnyEmpWage);
        }

        public void computeEmpWage()
        {
            foreach (ComapnyEmpWage comapnyEmpWage in this.comapnyEmpWagesList)
            {
                comapnyEmpWage.setTotalEmpWage(this.computeEmpWage(comapnyEmpWage));
                Console.WriteLine(comapnyEmpWage.toString());
            }
        }
        private int computeEmpWage(ComapnyEmpWage comapnyEmpWage)
        {
            return 0;
        }
        public int getTotalWage(string company)
        {
            return this.CompanyToEmpWageMap[company].TotalEmpWage;
        }


    }
}









