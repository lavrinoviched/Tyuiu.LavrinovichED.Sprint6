using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.LavrinovichED.Sprint6.Task2.V14.Lib
{
    public class DataService : ISprint6Task2V14
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
                a = 5 - 3 * x;
                b = (1 + Math.Sin(x)) / (2 * x - 0.5);
                y = Math.Round(a + b, 2);
                valueWaitArray[count] = y;
                count++;
            }
            return valueWaitArray; 

        }
    }
}
