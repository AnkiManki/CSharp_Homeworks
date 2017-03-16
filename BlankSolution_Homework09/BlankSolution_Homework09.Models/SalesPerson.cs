using System;
using System.Collections.Generic;
using System.Text;

namespace BlankSolution_Homework09.Models
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string firstName, string lastName, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Salary = 500;
        }
    }
}
