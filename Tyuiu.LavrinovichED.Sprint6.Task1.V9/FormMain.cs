using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Tyuiu.LavrinovichED.Sprint6.Task1.V9.Lib;

namespace Tyuiu.LavrinovichED.Sprint6.Task1.V9
{
    public partial class FormMain_LED : Form
    {
        public FormMain_LED()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_LED_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_LED.Text);
                int stopValue = Convert.ToInt32(textBoxStop_LED.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_LED.Text = "";
                textBoxResult_LED.AppendText("+-----------+-------------+" + Environment.NewLine);
                textBoxResult_LED.AppendText("|     X     |     f(x)    |" + Environment.NewLine);
                textBoxResult_LED.AppendText("+-----------+-------------+" + Environment.NewLine);

                for (int i = 0; i < len - 1; i++)
                {
                    strLine = String.Format("| {0,6:d}     |    {1, 5:f2}   |", startValue, valueArray[i]);
                    textBoxResult_LED.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxResult_LED.AppendText("+-----------+-------------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_LED_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы АСОиУБ-24-1 Лавринович Елизавета Дмитриевна");
        }
    }
}
