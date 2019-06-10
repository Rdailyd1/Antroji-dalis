using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NM11_1;
using VardasPavarde;

namespace UnitTestProjectNM11_5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateGetAge()
        {
            //--Arrange
            VardasPavarde_cs age = new VardasPavarde_cs();
            {
                
                age._GimMetai = Convert.ToDateTime("1985-05-25");
            };

            bool expected = true;

            //--Act
            bool actual = age.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
