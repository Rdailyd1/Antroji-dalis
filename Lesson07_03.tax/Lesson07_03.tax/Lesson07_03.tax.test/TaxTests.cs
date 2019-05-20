using System;
using Lesson07_03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson07_03.tax.test
{
    [TestClass]
    public class TaxTests
    {
        [TestMethod]
        public void TaxShouldCalculate5PercentWhenIcnomIsLess40000()
        {
            //Arrange
            decimal incom = 1000;
            decimal tax = 50;
            decimal calculatedTax = 0;
            //Act
            calculatedTax = Program.Tax(incom);
            //Assert
            Assert.AreEqual(calculatedTax, tax);
        }

        [TestMethod]
        public void TaxShouldCalculate15PercenttWhenIcnomIsEqual00000()
        {
            //Arrange
            decimal incom = 100000;
            decimal tax = 15000;
            decimal calculatedTax = 0;
            //Act
            calculatedTax = Program.Tax(incom);
            //Assert
            Assert.AreEqual(calculatedTax, tax);
        }

        [TestMethod]
        public void TaxShouldCalculate25PercenttWhenIcnomIsMoreThan100000()
        {
            //Arrange
            decimal incom = 1000000;
            decimal tax = 250000;
            decimal calculatedTax = 0;
            //Act
            calculatedTax = Program.Tax(incom);
            //Assert
            Assert.AreEqual(calculatedTax, tax);
        }

        [TestMethod]
        public void TaxShouldReturn0WhenIcnomIs0()
        {
            //Arrange
            decimal incom = 0;
            decimal tax = 0;
            decimal calculatedTax = 0;
            //Act
            calculatedTax = Program.Tax(incom);
            //Assert
            Assert.AreEqual(calculatedTax, tax);
        }
        [TestMethod]
        public void TaxShouldReturn0WhenIcnomIsLessThan0()
        {
            //Arrange
            decimal incom = -1;
            decimal tax = 0;
            decimal calculatedTax = 0;
            //Act
            calculatedTax = Program.Tax(incom);
            //Assert
            Assert.AreEqual(calculatedTax, tax);
        }
    }
}
