using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastFood;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Restoran1 r1 = new Restoran1();

            int pocetnaVrijednost = 42;
            int ocekivanaVrijdnost = r1.ukupnaCijena;


            Assert.AreEqual(pocetnaVrijednost, ocekivanaVrijdnost);



        }
    }
}
