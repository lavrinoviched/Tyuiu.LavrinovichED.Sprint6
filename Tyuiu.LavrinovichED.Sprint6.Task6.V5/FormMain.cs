using Tyuiu.LavrinovichED.Sprint6.Task6.V5.Lib;

namespace Tyuiu.LavrinovichED.Sprint6.Task6.V5
{
    public partial class FormMain_LED : Form
    {
        public FormMain_LED()
        {
            InitializeComponent();
        }

        string OpenFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_LED_Click(object sender, EventArgs e)
        {
            openFileDialog_LED.ShowDialog();
            OpenFilePath = openFileDialog_LED.FileName;
            textBoxVar_LED.Text = File.ReadAllText(OpenFilePath);
            groupBoxTask_LED.Text = groupBoxTask_LED.Text + " " + openFileDialog_LED.FileName;
            buttonDone_LED.Enabled = true;
        }

        private void buttonHelp_LED_Click(object sender, EventArgs e)
        {

            FormAbout_LED formAbout = new FormAbout_LED();
            formAbout.ShowDialog();
        }

        private void buttonDone_LED_Click(object sender, EventArgs e)
        {
            textBoxResult_LED.Text = ds.CollectTextFromFile(OpenFilePath);
        }
    }
}
