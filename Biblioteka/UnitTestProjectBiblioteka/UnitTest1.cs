using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotekosKnyga;
namespace UnitTestProjectBiblioteka
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateArGrazinoLaiku()
        {
            //--Arrange
            BibliotekosKnygaCs knygaLaiku = new BibliotekosKnygaCs(5,"Pavad", 10);

            knygaLaiku.PaemimoData = Convert.ToDateTime("2019-06-05");
           

            bool expected = true;

            //--Act
            bool actual = knygaLaiku.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

