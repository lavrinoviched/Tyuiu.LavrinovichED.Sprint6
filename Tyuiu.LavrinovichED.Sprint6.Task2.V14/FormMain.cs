using System.Windows.Forms.Design;
using Tyuiu.LavrinovichED.Sprint6.Task2.V14.Lib;

namespace Tyuiu.LavrinovichED.Sprint6.Task2.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_LED_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_LED.BackColor = Color.Red;
        }

        private void buttonDone_LED_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_LED.BackColor = Color.PaleGreen;
        }

        private void buttonDone_LED_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_LED.BackColor = Color.Blue;
        }

        private void buttonHelp_LED_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 Вариант 14 выполнила студентка группы АСОиУБ-24-1 Лавринович Елизавета");
        }

        private void buttonDone_LED_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_LED.Text);
                int stopValue = Convert.ToInt32(textBoxStop_LED.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartResult_LED.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartResult_LED.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_LED.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chartResult_LED.Series[0].Points.AddXY(startValue, valueArray[i]);

                    startValue++;
                }
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
