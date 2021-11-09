using System;
using System.Collections.Generic;
using System.Text;
namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        public const int IS_PRESENT = 1,WAGE_PER_HR = 20, FULL_WORKING_HRS=8;
        int TotalEmpWage;
        public void DailyWage()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_PRESENT)
            {
                this.TotalEmpWage = FULL_WORKING_HRS * WAGE_PER_HR;
                Console.WriteLine("Employee Present and Daily Wage is: " + TotalEmpWage );
            }
                
            else
                Console.WriteLine("Employee Absent");
        }        
    }
}
