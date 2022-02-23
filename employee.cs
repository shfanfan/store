using System;

namespace store
{
    class Employee
    {
        string name;
        int salary;
        int yearsSeniority;

        private Employee(){}

        public Employee(String name, int salary, int yearsSeniority)
        {
            this.name = name;
            this.salary = salary;
            this.yearsSeniority = yearsSeniority;
        }

        public int GetSalary()
        {
            return salary;
        }

        public string GetName()
        {
            return name;
        }

        public int GetYearsSeniority()
        {
            return yearsSeniority;
        }
    }
}
