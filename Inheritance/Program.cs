using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Batuhan"},
                new Person{FirstName = "batu" },
                new Student{LastName= "Şen" }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Person2
    {

    }
    class Customer:Person
    {
        public string Ctiy { get; set; }
        
    }
    class Student:Person
    {
        public string Department { get; set; }
    }
}
