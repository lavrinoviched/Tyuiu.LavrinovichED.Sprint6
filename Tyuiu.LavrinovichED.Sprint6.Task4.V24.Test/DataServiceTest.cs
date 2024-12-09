using Tyuiu.LavrinovichED.Sprint6.Task4.V24.Lib;

namespace Tyuiu.LavrinovichED.Sprint6.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -12.17;
            valueWaitArray[1] = -9.78;
            valueWaitArray[2] = -5.64;
            valueWaitArray[3] = -1.04;
            valueWaitArray[4] = -4.52;
            valueWaitArray[5] = 0.00;
            valueWaitArray[6] = 0.70;
            valueWaitArray[7] = 2.47;
            valueWaitArray[8] = 5.75;
            valueWaitArray[9] = 9.37;
            valueWaitArray[10] = 11.76;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, valueWaitArray);
        }
    }
}