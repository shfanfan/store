using System;

namespace store
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            Console.WriteLine("total salaries = " + GetTotalSalaries(employees).ToString());
        }

        static int GetTotalSalaries(Employee[] employees)
        {
            return -1;
        }
    }
}
