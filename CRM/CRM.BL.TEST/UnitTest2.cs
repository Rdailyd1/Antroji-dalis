using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRM.BL.TEST
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidateProductName()
        {
            //--Arrange
            Product product = new Product();
            {
                product.ProductName = "Saldytuvas";
            };

           bool expected = true;

            //--Act
            bool actual = product.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void ValidateOrderData()
        {
            //--Arrange
            Order order = new Order();
            {
                order.OrderDate = DateTime.Now;
            };

            bool expected = true;

            //--Act
            bool actual = order.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
