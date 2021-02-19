using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustumerManager custumerManager = new CustumerManager();
            custumerManager.Add();
            custumerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Custumer custumer = new Custumer();
            custumer.Ctiy = "İzmir";
            custumer.Id = 12345;
            custumer.FirstName = "Batuhan";
            custumer.LastName = "Şen";

            Custumer custumer2 = new Custumer
            {
                Id = 2, FirstName = "Büşra", LastName = "Taştekin", Ctiy = "Afyon"
            };

            Console.WriteLine(custumer2.FirstName);

            Console.ReadLine();
        }
    }
}
