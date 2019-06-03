using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderID)
        {
            OrderID = orderID;
        }
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate.Date != DateTime.Now.Date)
            {
                isValid = false;
            }
            return isValid;
        }
        public Order Retrieve(int orderId)
        {
            return new Order();
        }
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }
        public bool Save()
        {

            return true;
        }
    }
}
