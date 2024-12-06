using Tyuiu.LavrinovichED.Sprint6.Task0.V11.Lib;

namespace Tyuiu.LavrinovichED.Sprint6.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(2);
            double wait = 18.4;
            Assert.AreEqual(res, wait);
        }
    }
}