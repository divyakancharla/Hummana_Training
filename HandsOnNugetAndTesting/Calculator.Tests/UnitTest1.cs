using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalculatorTask obj=new CalculatorTask();
            var Result=obj.Calculate();
            Assert.isInt(Result);
        }
    }
}
