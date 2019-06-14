using System;
using Mokiniai;
using MokinysClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MokinioRepozitorija;

namespace UnitTestProjectMokiniai
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void pazymiuVidurkiuSkaiciavimasBePazymiu()
        {
            // Asign
            MokinysCS mok = new MokinysCS();

            //Act
            List<int> pazymiai = new List<int>();

            decimal vidurkis = mok.VidurkioSkaiciavimas(pazymiai);
            //Assert

            Assert.AreEqual(0, vidurkis);
        }
        [TestMethod]
        public void pazymiuVidurkiuSkaiciavimasSuVienuPazymiu()
        {
            // Asign
            MokinysCS mok = new MokinysCS();

            //Act
            List<int> pazymiai = new List<int>();
            pazymiai.Add(7);

            decimal vidurkis = mok.VidurkioSkaiciavimas(pazymiai);
            //Assert

            Assert.AreEqual(7, vidurkis);
        }
        [TestMethod]
        public void pazymiuVidurkiuSkaiciavimasSuKeliaisPazymiais()
        {
            // Asign
            MokinysCS mok = new MokinysCS();

            //Act
            List<int> pazymiai = new List<int>();
            pazymiai.Add(7);
            pazymiai.Add(9);
            pazymiai.Add(8);

            decimal vidurkis = mok.VidurkioSkaiciavimas(pazymiai);
            //Assert

            Assert.AreEqual(8, vidurkis);
        }
    }
}
