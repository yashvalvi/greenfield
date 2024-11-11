using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    internal class CustomerService : ICustomerService
    {
        private List<Customer> _customerList=new List<Customer>();
        public CustomerService()
        {
            this._customerList=new List<Customer>();
        }
        public bool delete(int id)
        {
            Customer theCustomer=this.Get(id);
            return this._customerList.Remove(theCustomer);
        }
        public Customer Get(int id)
        {
            foreach(Customer customer in _customerList) 
            {
                if(customer.id== id)
                    return customer;
            }
            return null;
        }
        public List<Customer> GetAll()
        {
            return _customerList;
        }
        public bool insert(Customer customer)
        {
            _customerList.Add(customer);
            return true;
        }
        public bool update(Customer customer)
        {
            _customerList.Remove(customer);
            -_customerList.Add
            return true;

        }
}