using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastFood;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void TestMethod1()
        {
            Restoran1 r1 = new Restoran1();
            int rijesenje = 45;
            int stvarno = r1.ukupnaCijena;
            

            Assert.AreEqual(rijesenje, stvarno, "Riješenje nije toèno");
        }
    }
}
