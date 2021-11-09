using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program.");
            EmployeeWage employee = new EmployeeWage();
            employee.DailyWage();
        }
    }
}
