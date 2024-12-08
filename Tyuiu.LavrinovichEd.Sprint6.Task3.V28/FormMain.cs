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

        private void buttonHelp_LED_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 вариант 28 выполнила студентка группы АСОиУБ-24-1 Лавринович Елизавета Дмитриевна");
        }

        private void buttonDone_LED_Click(object sender, EventArgs e)
        {
            textBoxResult_LED.Text = Convert.ToString(ds.Calculate(matrix));
        }

        private void FormMain_LED_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            dataGridView_LED.ColumnCount = colums;
            dataGridView_LED.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridView_LED.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            { 
                for (int j = 0; j < colums; j++) 
                {
                    dataGridView_LED.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                } 
            }
        
        }
    }
}
