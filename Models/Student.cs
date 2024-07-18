using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege.Models
{
    internal class Student : Person
    {
        public string Branch { get; set; }

        public Student()
        {
            
        }

        public Student(int id, string address, DateTime dateOfBirth, string branch) : base(id, address,dateOfBirth) 
        {
            Branch = branch;
        }

        public override string PrintDetails()
        {
            return $"{base.PrintDetails()}\n" +
                $"Branch : {Branch}";
        }
    }
}
