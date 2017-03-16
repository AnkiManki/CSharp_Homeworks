using System;

namespace BlankSolution_Homework09.Models
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; } // za da moze da se pristapi samo od klasi sto nasleduvaat
        public Gender Gender { get; set; }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, Gender: {Gender}, Salary {Salary}");
        }

    }
}
