using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 3, FirstName="Berna", LastName="Taşdemir",City="Ankara" };
            Customer customer2 = new Customer(4, "Burak", "Taşdemir", "Ankara");
            Customer customer3 = new Customer();
            customer3.Id = 3;
            Console.WriteLine(customer2.FirstName); ;
        }
    }
    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        //default constructor parametresi olmayan constructor 1-3 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
