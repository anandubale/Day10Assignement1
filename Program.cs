using System;
using System.Collections.Generic;
using System.Collections;

namespace MyPotential
{
    class Program
    {
       // public const int RateOfWorkingPerHr = 200;
        //public const int MinNumberOfDays = 20;
        //public const int MinNumberOfHrs = 100;


        public static int EmpWage(string Company, int RateOfWorkingPerHr, int MinNumberOfDays, int MinNumberOfHrs)
        { 
                 int WorkingHr = 0;
                 int TotalHrs = 0;
                 int TotalEmpWage = 0;
                 int Days = 0;


            while (Days < MinNumberOfDays && TotalHrs < MinNumberOfHrs)
            {
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case 1:
                        Console.WriteLine("Employee is working Full Time");
                        WorkingHr = 8;
                        break;
                    case 2:
                        Console.WriteLine("Employee is working Half Time");
                        WorkingHr = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        WorkingHr = 0;
                        break;

                }
                int EmpWage = WorkingHr * RateOfWorkingPerHr;
                Console.WriteLine("Employee wage of {0}", EmpWage);

                Days++;
                TotalHrs += WorkingHr;
                Console.WriteLine("Number Of hrs: " + TotalHrs);
                TotalEmpWage += EmpWage;

            }
            ArrayList Name_Of_ArrayList = new ArrayList();
            Name_Of_ArrayList.Add(Company);
            Name_Of_ArrayList.Add(TotalEmpWage);
            var firstElement = Name_Of_ArrayList[0];
            var secondElement = Name_Of_ArrayList[1];
            Console.WriteLine("totalEmpWage for {0} is {1}", firstElement, secondElement);
            return TotalEmpWage;

        }


        static void Main(string[] args)
        {

            //Wage for month till no. of days or Working hrs didnt reach

            EmpWage("Dmart", 100,25,120);

        }

    }
}
