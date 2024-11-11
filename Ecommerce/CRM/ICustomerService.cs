using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    internal interface ICustomerService
    {
        List<Customer> GetAll();
        Customer Get(int id);
        bool insert(Customer customer);
        bool update(Customer customer);
        bool delete(int id);


    }
}
