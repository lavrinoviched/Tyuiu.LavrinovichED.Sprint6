using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.LavrinovichED.Sprint6.Task7.V23.Lib
{
    public class DataService : ISprint6Task7V23
    {
        public int[,] GetMatrix(string path)
        {

            int[,] matrix = ReadMatrixFromFile(path);
            ModifyLastColumn(matrix);
            return matrix;
        }

        private int[,] ReadMatrixFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int rows = lines.Length;
            int cols = lines[0].Split().Length;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            return matrix;
        }

        private void ModifyLastColumn(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int lastColIndex = matrix.GetLength(1) - 1;

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, lastColIndex] < 2)
                {
                    matrix[i, lastColIndex] = 2;
                }
            }
        }

    }
}
    
    

