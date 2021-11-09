using System;
using System.Collections.Generic;
using System.Text;
namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        public const int IS_FULL_TIME = 1,IS_PART_TIME = 2, WAGE_PER_HR = 20, FULL_WORKING_HRS=8, PARTTIME_WORKING_HRS = 4,WORKING_DAYS = 20;
        int TotalEmpWage,Emphrs=0;
        public void MonthlyWage()
        {
            Random random = new Random();
            for(int i=0;i<WORKING_DAYS;i++)
            {
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_FULL_TIME:
                        this.Emphrs += FULL_WORKING_HRS;
                        break;
                    case IS_PART_TIME:
                        this.TotalEmpWage += PARTTIME_WORKING_HRS;                        
                        break;
                    default:
                        this.Emphrs +=0;
                        break;
                }
            }
            this.TotalEmpWage = this.Emphrs * WAGE_PER_HR;
            Console.WriteLine(this.TotalEmpWage);
        }        
    }
}
