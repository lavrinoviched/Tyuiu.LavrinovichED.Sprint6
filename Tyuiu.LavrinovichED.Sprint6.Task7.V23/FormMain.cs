using Tyuiu.LavrinovichED.Sprint6.Task7.V23.Lib;

namespace Tyuiu.LavrinovichED.Sprint6.Task7.V23
{
    public partial class FormMain_LED : Form
    {
        public FormMain_LED()
        {
            InitializeComponent();

            openFileDialog_LED.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_LED.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int cols;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries); ;
            
            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonFile_LED_Click(object sender, EventArgs e)
        {
            


        }
    }
}
