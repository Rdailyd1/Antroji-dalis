using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParduotuvesKasosSistemaBL;

namespace UnitTestProjectKasosSistema
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateCekioPridejimas()
        {
            //--Arrange
            CekiuRepozitorija cekis = new CekiuRepozitorija();
            cekis.IdejimasIKrepseli(1, "98745", "Batai", 50);
            int expected = cekis.Retrieve().Count;

            //--Act
            int actual = cekis.Retrieve().Count;

            //--Assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void ValidatePrekesPridejimas()
        {
            //--Arrange
            PrekiuRepozitorija preke = new PrekiuRepozitorija();
            preke.PrekiuPridejimas("Batai", "98745", 50);
            int expected = preke.Retrieve().Count;

            //--Act
            int actual = preke.Retrieve().Count;

            //--Assert
            Assert.AreEqual(9, actual);
        }
    }
}
