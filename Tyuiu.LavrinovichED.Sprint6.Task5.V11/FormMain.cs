using Tyuiu.LavrinovichED.Sprint6.Task5.V11;
using Tyuiu.LavrinovichED.Sprint6.Task5.V11.Lib;

namespace Tyuiu.LavrinovichED.Sprint6.Task5.V11
{
    public partial class FormMain_LED : Form
    {
        public FormMain_LED()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\y_lav\source\repos\Tyuiu.LavrinovichED.Sprint6\DataSprint6\InPutDataFileTask5V11.txt";

        private void buttonDone_LED_Click(object sender, EventArgs e)
        {
            dataGridViewResult_LED.ColumnCount = 2;
            dataGridViewResult_LED.Columns[0].Width = 20;
            dataGridViewResult_LED.Columns[1].Width = 50;

            this.chartResult_LED.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartResult_LED.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_LED.Series[0].Points.Clear();
            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult_LED.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartResult_LED.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonFile_LED_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_LED_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 вариант 11 выполнила студентка группы АСОиУБ-24-1 Лавринович Елизавета Дмитриевна");
        }
    }
}
