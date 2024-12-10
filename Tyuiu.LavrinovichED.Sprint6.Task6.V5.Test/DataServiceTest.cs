using System.IO;

using Tyuiu.LavrinovichED.Sprint6.Task6.V5.Lib;

namespace Tyuiu.LavrinovichED.Sprint6.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\y_lav\source\repos\Tyuiu.LavrinovichED.Sprint6\DataSprint6\InPutDataFileTask6V5.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "ulzPXa sMLuPzlvneiTo tfouGdncXlJ";

            Assert.AreEqual(wait, res);
        }
    }
}