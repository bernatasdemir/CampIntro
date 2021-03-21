using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Berna";
            customer1.Surname = "Taşdemir";
            customer1.TcNumber = "12345645450";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "45872";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "45845526";

            //GERCEK MÜŞTERİ - TÜZEL MÜŞTERİ

            Customer customer3 = new CorporateCustomer();
            Customer customer4 = new IndividualCustomer();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
