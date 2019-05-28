using System;
using Pirkinys;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_NM8
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void kainaTuriButi2302()
        {
            // Asign
            pirkinys vardas = new pirkinys("stalas", 10, 230.20m);
            //Act
            decimal kainaViso = vardas.KainaViso;
            //Assert
           
            Assert.AreEqual(2302, kainaViso);
        }

        [TestMethod]
        public void kainaTuriButi0KaiKiekis0()
        {
            // Asign
            pirkinys vardas = new pirkinys("stalas", 0, 230.20m);
            //Act
            decimal kainaViso = vardas.KainaViso;
            //Assert

            Assert.AreEqual(0, kainaViso);
        }
        [TestMethod]
        public void kainaTuriButi0KaiVienetoKaina0()
        {
            // Asign
            pirkinys vardas = new pirkinys("spinta", 5, 0);
            //Act
            decimal kainaViso = vardas.KainaViso;
            //Assert

            Assert.AreEqual(0, kainaViso);
        }
    }
}
