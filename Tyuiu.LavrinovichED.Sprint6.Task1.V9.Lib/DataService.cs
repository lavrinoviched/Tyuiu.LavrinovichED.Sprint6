using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.LavrinovichED.Sprint6.Task1.V9.Lib
{
    public class DataService : ISprint6Task1V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueWaitArray;
            int len = (stopValue - startValue) + 1;
            valueWaitArray = new double[len];
            double y;
            double a;
            double b;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                a = 2 * x - 4;
                b = (2 * x - 1) / (Math.Sin(x) + 1);
                y = Math.Round(a + b, 2);
                valueWaitArray[count] = y;
                count++;
            }
            return valueWaitArray;
        }
    }
}
