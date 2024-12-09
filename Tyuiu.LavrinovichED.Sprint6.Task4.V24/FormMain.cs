using Tyuiu.LavrinovichED.Sprint6.Task4.V24.Lib;

namespace Tyuiu.LavrinovichED.Sprint6.Task4.V24
{
    public partial class FormMain_LED : System.Windows.Forms.Form
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

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueWaitArray;
                valueWaitArray = new double[len];

                valueWaitArray = ds.GetMassFunction(startValue, stopValue);

                this.chart_LED.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chart_LED.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_LED.Text = "";

                chart_LED.Series[0].Points.Clear();
                for (int i = 0; i <= len; i++)
                {
                    this.chart_LED.Series[0].Points.AddXY(startValue, valueWaitArray[i]);
                    textBoxResult_LED.AppendText(valueWaitArray[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_LED_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 вариант 24 выполнила студентка группы АСОиУБ-24-1 Лавринович Елизавета Дмитриевна");
        }

        private void buttonSave_LED_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4.txt" });
                File.WriteAllText(path, textBoxResult_LED.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен усешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
