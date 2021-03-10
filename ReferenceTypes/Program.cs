using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Customer customer = new Customer();
            customer.FirstName = "Berna";
            customer.CreditCardNumber = 456987;

            Employee employee = new Employee();
            Person person3 = customer;
            customer.FirstName = "Beyza";
            PersonManager personManager = new PersonManager();
            personManager.Add(person3);

            Console.WriteLine(((Customer)person3).CreditCardNumber);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }

    //base class
    class Customer:Person
    {
        public int CreditCardNumber { get; set; }

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
