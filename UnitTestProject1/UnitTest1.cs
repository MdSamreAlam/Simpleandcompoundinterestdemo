using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleInterestCalculations;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FindInterest findInterest = new FindInterest();
            float result = findInterest.Interest(10, 20, 30);
            Assert.AreEqual(result, 60);
        }
       
        [TestMethod]
        public void TestMethod2()
        {
            FindInterest findInterest = new FindInterest();
            float result1 = findInterest.Interest(45, 20, 20);
            Assert.AreEqual(result1, 180);

        }
        [TestMethod]
        public void Testmethod3()
        {
            FindInterest findInterest = new FindInterest();
            float res = findInterest.Interest(10, 10, 40);
            Assert.AreNotEqual(" this values {res} not correct", res);
        }
    }
}
