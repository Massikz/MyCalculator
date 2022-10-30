using Calc;

namespace MyCalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyCalc myCalc = new MyCalc();
            int actual = myCalc.Sum(1,2);
            Assert.AreEqual(3, actual);
        }
       
    }
}