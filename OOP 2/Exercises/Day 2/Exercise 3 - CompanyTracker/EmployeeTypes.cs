using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_3___CompanyTracker
{
    public abstract class Employee
    {
        public string Name { get; set; }
        
        public virtual double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    public class Administrator : Employee
    {
        public Administrator(string name, double salary) : base(name, salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    public class Salesman : Employee
    {
        public double Commision { get; set; }
        public double BaseSalary { get; set; }
        public Salesman(string name, double baseSalary, double commision) : base(name, baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
            Commision = commision;
        }

        public override double Salary { 
            get{
                return BaseSalary + Commision;
            }
        }
    }

    public class Worker : Employee
    {
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }
        public Worker(string name, double hourlyRate, double hoursWorked) : base(name, hourlyRate)
        {
            Name = name;
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double Salary { 
            get{
                return HourlyRate * HoursWorked;
            }
        }
    }
}