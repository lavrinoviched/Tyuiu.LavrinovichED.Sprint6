using System.Drawing.Drawing2D;
using Tyuiu.LavrinovichED.Sprint6.Task3.V28.Lib;

namespace Tyuiu.LavrinovichEd.Sprint6.Task3.V28
{
    public partial class FormMain_LED : Form
    {
        public FormMain_LED()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { {-9, 8, 9, 16, -18 },
                              {-13, -11, -20, -15, 9},
                              {18, 13, -12, -15, -11 },
                              {10, -2, 19, -4, -10 },
                              {6, -20, -4, 13, -14 }
                                                     };
        private void FormMain_LED_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewVar_LED.ColumnCount = columns;
            dataGridViewVar_LED.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewVar_LED.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewVar_LED.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }


        private void buttonHelp_LED_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 вариант 28 выполнила студентка группы АСОиУБ-24-1 Лавринович Елизавета Дмитриевна");
        }

        private void buttonDone_LED_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(matrix);
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewResult_LED.ColumnCount = columns;
            dataGridViewResult_LED.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_LED.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_LED.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }
    }
}  

