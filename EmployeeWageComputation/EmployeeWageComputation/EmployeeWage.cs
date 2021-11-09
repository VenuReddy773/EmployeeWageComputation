using System;
using System.Collections.Generic;
using System.Text;
namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        public const int IS_PRESENT = 1;
        public void EmpAttendence()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_PRESENT)
                Console.WriteLine("Employee Present");
            else
                Console.WriteLine("Employee Absent");
        }        
    }
}
