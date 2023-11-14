using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        public void Add(Customer customer);
        public void GetAllCustomer(Customer customer);
        public void Delete(Customer customer);
    }
}
