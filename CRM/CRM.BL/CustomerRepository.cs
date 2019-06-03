using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.BL
{
    class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.EmailAddress = "dfadfbd@fdgsfgsbrt.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }
    }
}
