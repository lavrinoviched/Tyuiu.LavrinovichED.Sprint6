using System.IO;
using Tyuiu.LavrinovichED.Sprint6.Task7.V23.Lib;

namespace Tyuiu.LavrinovichED.Sprint6.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\y_lav\source\repos\Tyuiu.LavrinovichED.Sprint6\DataSprint6\InPutDataFileTask7V23.csv";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}