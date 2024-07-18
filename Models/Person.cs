using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Person()
        {
            
        }

        public Person(int id, string address, DateTime dateOfBirth)
        {
            Id = id;
            Address = address;
            DateOfBirth = dateOfBirth;
        }

        public virtual string PrintDetails()
        {
            return $" Person's ID: {Id}\n" +
                $"Person's Address: {Address}\n" +
                $"Person's Date Of Birth: {DateOfBirth}";
        }
    }
}
