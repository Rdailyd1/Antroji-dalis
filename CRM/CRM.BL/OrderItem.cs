using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderitemID)
        {
           OrderItemID = orderitemID;
        }
        public int OrderItemID { get; set; }
        public int ProductID { get; set; }
        public decimal Purchaseprice { get; set; }
        public int Quantity { get; set; }
        public bool Validate()
        {
            var isValid = true;
            if (Purchaseprice != 0)
            {
                isValid = false;
            }
            return isValid;
        }
        public OrderItem Retrieve(int orderitemID)
        {
            return new OrderItem();
        }
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }
        public bool Save()
        {

            return true;
        }
    }
}
