using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_3___CompanyTracker
{
    public class Company
    {
        public string Name { get; set; }

        public List<Employee> Employees = new List<Employee>();

        public Company(string name)
        {
            Name = name;
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public double SalaryCosts()
        {
            double total = 0;
            foreach (Employee employee in Employees)
            {
                total += employee.Salary;
            }
            return total;
        }

        public string PrintAllEmployeeSalaries()
        {
            string result = "";
            foreach (Employee employee in Employees)
            {
                result += $"{employee.Name} earns {employee.Salary} lv.\n";
            }
            return result;
        }
    }
}