using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.LavrinovichED.Sprint6.Task4.V24.Lib
{
    public class DataService : ISprint6Task4V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueWaitArray;
            int len = (stopValue -  startValue) + 1;
            valueWaitArray = new double[len];

            double y;
            double a;
            double b;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                a = Math.Sin(x) / (x + 1.2);
                b = (Math.Sin(x) * 2) - (2 * x);
                y = Math.Round(a - b, 2);
                valueWaitArray[count] = y;
                count++;
            }
            return valueWaitArray;
        }
    }
}
