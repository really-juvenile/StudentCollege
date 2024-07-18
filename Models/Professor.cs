using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege.Models
{
    internal class Professor : Person
    {
        public double Salary { get; set; }

        public Professor()
        {
            
        }

        public Professor(int id, string address, DateTime dateOfBirth,double salary) : base(id,address,dateOfBirth)
        {
            Salary = salary;
        }

        public override string PrintDetails()
        {
            return $"{base.PrintDetails()}\n" +
                $"Salary: {Salary}";
        }
    }
}
