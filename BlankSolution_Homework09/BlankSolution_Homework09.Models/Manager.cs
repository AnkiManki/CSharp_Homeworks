using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlankSolution_Homework09.Models
{
    public class Manager : Employee
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public List<SalesPerson> SalesPersons { get; set; }

        public Manager(int id, string firstName, string lastName, Gender gender, string department, double salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Department = department;
            Salary = salary;
            SalesPersons = new List<SalesPerson>();
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {Gender} is a manager in {Department} department with salary {Salary}");
        }

        public void PrintSalesPersonsByFirstName()
        {
            Console.WriteLine("Sales persons: ");

            if (!SalesPersons.Any())
            {
                Console.WriteLine("Empty sales person list");
            }
            else
            {
                foreach (var salesPerson in SalesPersons.OrderBy(sp => sp.FirstName))
                {
                    salesPerson.PrintInfo();
                }
            }
        }

        public void PrintFemaleSalesPersons()
        {
            Console.WriteLine("Sales persons: ");

            if (!SalesPersons.Any())
            {
                Console.WriteLine("Empty sales person list");
            }
            else
            {
                foreach (var salesPerson in SalesPersons.Where(sp => sp.Gender == Gender.Female).OrderBy(sp => sp.FirstName))
                {
                    salesPerson.PrintInfo();
                }
            }
        }

    }
}
