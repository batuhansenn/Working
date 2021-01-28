using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayı1 = 10;
            //int sayı2 = 20;

            //sayı1 = sayı2;
            //sayı2 = 100;

            //console.writeline("sayı 1 : " + sayı1);

            //int[] sayılar1 = new int[] { 1,2,3 };
            //int[] sayılar2 = new int[] { 10, 20, 30 };

            //sayılar1 = sayılar2;
            //sayılar2[0] = 1000;
            //console.writeline(sayılar1[0]);



            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Batuhan";


            person2 = person1;
            person1.FirstName = "Engin";

           


            Console.WriteLine(person2);


            Person person = new Person();

            Custumer custumer = new Custumer();
            custumer.FirstName = "Salih";
            custumer.CreditCardNumber = "123345678901";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = custumer;
            custumer.FirstName = "Ahmet";
        

            Console.WriteLine(((Custumer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);

        }
    }
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Custumer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
