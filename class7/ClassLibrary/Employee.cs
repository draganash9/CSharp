using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public Employee(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
        public void PrintInfo(string firstName, string lastName, double salary)
        {
            Console.WriteLine($"{firstName} {lastName} {salary}");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
