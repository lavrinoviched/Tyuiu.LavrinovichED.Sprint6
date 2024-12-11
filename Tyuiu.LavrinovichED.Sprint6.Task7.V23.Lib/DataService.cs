using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.LavrinovichED.Sprint6.Task7.V23.Lib
{
    public class DataService : ISprint6Task7V23
    {
        public int[,] GetMatrix(string path)
        {
            // Чтение файла и преобразование в матрицу
            var lines = File.ReadAllLines(path);
            int rowCount = lines.Length;
            int colCount = lines[0].Split(' ').Length;
            int[,] matrix = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                var values = lines[i].Split(' ');
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            return matrix;
        }

        public void UpdateLastColumn(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);

            // Изменение значений в последнем столбце
            for (int i = 0; i < rowCount; i++)
            {
                if (matrix[i, colCount - 1] < 2)
                {
                    matrix[i, colCount - 1] = 2;
                }
            }
        }

        public void WriteMatrixToFile(int[,] matrix, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                int rowCount = matrix.GetLength(0);
                int colCount = matrix.GetLength(1);

                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        writer.Write(matrix[i, j]);
                        if (j < colCount - 1)
                        {
                            writer.Write(" ");
                        }
                    }
                    writer.WriteLine();
                }
            }
        }
    }
    
}
