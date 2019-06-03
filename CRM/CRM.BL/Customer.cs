using System;
using System.Collections.Generic;

namespace CRM.BL
{
    public class Customer
    {
        public Customer()
        {
           
        }
        public Customer(int customerId)
        {

        }
        public int CustemerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public string FullName
        {

            get
            {
                if (String.IsNullOrWhiteSpace(LastName) && !String.IsNullOrWhiteSpace(FirstName))
                {
                    return FirstName;
                }
                else if (!String.IsNullOrWhiteSpace(LastName) && String.IsNullOrWhiteSpace(FirstName))
                {
                    return LastName;
                }
                else if (!String.IsNullOrWhiteSpace(LastName) && !String.IsNullOrWhiteSpace(FirstName))
                {
                    return LastName + ", " + FirstName;
                }
                else return "";

            }
        }
        public bool Save()
        {

            return true;
        }
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }
        public List<Customer>Retrieve()
        {
            return new List<Customer>();
        }
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
