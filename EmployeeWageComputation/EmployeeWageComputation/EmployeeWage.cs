using System;
using System.Collections.Generic;
using System.Text;
namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        public const int IS_FULL_TIME = 1,IS_PART_TIME = 2, WAGE_PER_HR = 20, FULL_WORKING_HRS=8, PARTTIME_WORKING_HRS = 4;
        int TotalEmpWage;
        public void DailyWage()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            if (empcheck == IS_FULL_TIME)
            {
                this.TotalEmpWage = FULL_WORKING_HRS * WAGE_PER_HR;
                Console.WriteLine("Employee Present and Daily Wage is: " + TotalEmpWage );
            }          
            else if(empcheck == IS_PART_TIME)
            {
                this.TotalEmpWage = PARTTIME_WORKING_HRS * WAGE_PER_HR;
                Console.WriteLine("Employee Present and Daily Wage is: " + TotalEmpWage);
            }
            else
            Console.WriteLine("Employee Absent");
        }        
    }
}
