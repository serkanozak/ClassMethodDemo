using System;
using Business.Concrete;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(); 
            customer1.Id = 1;
            customer1.Name = "Serkan Özak";
            customer1.CreditNote = 50.5;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Engin Demiroğ";
            customer2.CreditNote = 90.8;

            List<Customer> customers = new List<Customer>() {customer1, customer2};

            foreach (var customer in customers)
            {
                Console.WriteLine("Müşteri ID : " + customer.Id);
                Console.WriteLine("Müşteri Adı ve Soyadı : " + customer.Name);
                Console.WriteLine("Müşteri Kredi Notu : " + customer.CreditNote);
                Console.WriteLine("-----------------------------------------------");
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer1);
            customerManager.GetAllCustomer(customer1);

            Console.WriteLine("---------------------------------------------------------");

            customerManager.Add(customer2);
            customerManager.Delete(customer2);
            customerManager.GetAllCustomer(customer2);









        }
    }
}