using Tyuiu.LavrinovichED.Sprint6.Task3.V28.Lib;

namespace Tyuiu.LavrinovichED.Sprint6.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = { {-9, 8, 9, 16, -18 },
                              {-13, -11, -20, -15, 9},
                              {18, 13, -12, -15, -11 },
                              {10, -2, 19, -4, -10 },
                              {6, -20, -4, 13, -14 }
                                                     };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = { {-9, 8, 9, 16, -18 },
                              {-13, -11, -20, -15, 9},
                              {18, 13, -12, -15, -11 },
                              {0, -2, 0, -4, -10 },
                              {6, -20, -4, 13, -14 }
                                                     };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}