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
}
