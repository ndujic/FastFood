using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Tests
{
    [TestClass()]
    public class Restoran1Tests
    {
        [TestMethod()]
        public void Restoran1Test()
        {
            int ocekivani = 0;
            Restoran1 rest = new Restoran1();


            Assert.AreEqual(ocekivani, rest.ukupnaCijena);
        }
    }
}