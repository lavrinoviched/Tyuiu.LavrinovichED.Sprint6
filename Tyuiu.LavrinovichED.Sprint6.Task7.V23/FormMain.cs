using Tyuiu.LavrinovichED.Sprint6.Task7.V23.Lib;

namespace Tyuiu.LavrinovichED.Sprint6.Task7.V23
{
    public partial class FormMain_LED : Form
    {
        public FormMain_LED()
        {
            InitializeComponent();

            openFileDialog_LED.Filter = "��������, ����������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
            SaveFileDialog.Filter = "��������, ����������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
        }

        static int rows;
        static int cols;
        static string openFilePath;

        DataService ds = new DataService();

        private void buttonFile_LED_Click(object sender, EventArgs e)
        {
            


        }
    }
}
