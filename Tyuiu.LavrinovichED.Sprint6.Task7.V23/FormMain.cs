using Tyuiu.LavrinovichED.Sprint6.Task7.V23.Lib;

namespace Tyuiu.LavrinovichED.Sprint6.Task7.V23
{
    public partial class FormMain_LED : System.Windows.Forms.Form
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

        public static int[,] LoadFromFileData(string openFilePath)
        {
            string fileData = File.ReadAllText(openFilePath);

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

            openFileDialog_LED.ShowDialog();
            openFilePath = openFileDialog_LED.FileName;

            int[,] arrayValues = new int[rows, cols];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewVar_LED.ColumnCount = cols;
            dataGridViewVar_LED.RowCount = rows;
            dataGridViewResult_LED.ColumnCount = cols;
            dataGridViewResult_LED.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                dataGridViewVar_LED.Columns[i].Width = 45;
                dataGridViewResult_LED.Columns[i].Width = 45;

            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewVar_LED.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_LED.Enabled = true;

        }

        private void buttonDone_LED_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, cols];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewResult_LED.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonFile_LED.Enabled = true;
            buttonPush_LED.Enabled = true;
        }

        private void buttonPush_LED_Click(object sender, EventArgs e)
        {
            saveFileDialog_LED.FileName = "OutPutFileTask7.csv";
            saveFileDialog_LED.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_LED.ShowDialog();

            string path = saveFileDialog_LED.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewResult_LED.Rows.Count;
            int cols = dataGridViewResult_LED.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + dataGridViewResult_LED.Rows[i].Cells[j].Value + ";";

                    }
                    else
                    {
                        str = str + dataGridViewResult_LED.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
                
            }
        }

        private void buttonFile_LED_MouseEnter(object sender, EventArgs e)
        {
            toolTip_LED.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_LED_MouseEnter(object sender, EventArgs e)
        {
            toolTip_LED.ToolTipTitle = "Выполнить";
        }

        private void buttonPush_LED_MouseEnter(object sender, EventArgs e)
        {
            toolTip_LED.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_LED_MouseEnter(object sender, EventArgs e)
        {
            toolTip_LED.ToolTipTitle = "Справка";
        }

        private void buttonHels_LED_Click(object sender, EventArgs e)
        {
            FormAbout_LED formAbout = new FormAbout_LED();
            formAbout.ShowDialog();
        }
    }
}
