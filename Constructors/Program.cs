using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Custumer custumer1 = new Custumer { Id = 1, FirstName = "Batuhan", LastName = "Şen", Ctiy = "İzmir" };
            Custumer custumer2 = new Custumer(2, "Sinem", "Şen", "İzmir");
            Custumer custumer3 = new Custumer();
            custumer3.Id = 3;

            Console.WriteLine(custumer2.FirstName);

        }
    }
    class Custumer
    {
        public Custumer()
        {
           
        }
        //Default Constructors
        public Custumer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ctiy { get; set; }
    }
}
