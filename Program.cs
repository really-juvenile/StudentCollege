using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCollege.Models;

namespace StudentCollege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(101,"Mumbai", new DateTime(1990,5,1) );
            Student student = new Student(102,"Delhi",new DateTime (2000,7,8), "IT");
            Professor professor = new Professor(103,"DELHI", new DateTime(1995,9,17),40000);


            PrintPersonDetails(person);
            PrintPersonDetails(student);
            PrintPersonDetails(professor);
        }

        static void PrintPersonDetails(Person person)
        {
            Console.WriteLine($"=================Role: {person.GetType()}=============================");
            Console.WriteLine(person.PrintDetails());
        }
    }

}
