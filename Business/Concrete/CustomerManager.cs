using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Name} eklendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine($"{customer.Name} silindi.");
        }

        public void GetAllCustomer(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + " numaralı müşteri" + " " + customer.Name + " bilgileri listelendi.");
            Console.WriteLine("Müşteri ID : " + customer.Id);
            Console.WriteLine("Müşteri Adı ve Soyadı : " + customer.Name);
            Console.WriteLine("Müşteri Kredi Notu : " + customer.CreditNote);
        }
    }
}
