namespace Tyuiu.LavrinovichED.Sprint6.Task6.V5
{
    partial class FormMain_LED
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelTask_LED = new Panel();
            buttonHelp_LED = new Button();
            buttonOpenFile_LED = new Button();
            buttonDone_LED = new Button();
            groupBoxTask_LED = new GroupBox();
            textBoxTask_LED = new TextBox();
            panelVar_LED = new Panel();
            groupBoxVar_LED = new GroupBox();
            textBoxVar_LED = new TextBox();
            panelResult_LED = new Panel();
            groupBoxResult_LED = new GroupBox();
            textBoxResult_LED = new TextBox();
            splitter1 = new Splitter();
            openFileDialog_LED = new OpenFileDialog();
            toolTip_LED = new ToolTip(components);
            panelTask_LED.SuspendLayout();
            groupBoxTask_LED.SuspendLayout();
            panelVar_LED.SuspendLayout();
            groupBoxVar_LED.SuspendLayout();
            panelResult_LED.SuspendLayout();
            groupBoxResult_LED.SuspendLayout();
            SuspendLayout();
            // 
            // panelTask_LED
            // 
            panelTask_LED.Controls.Add(buttonHelp_LED);
            panelTask_LED.Controls.Add(buttonOpenFile_LED);
            panelTask_LED.Controls.Add(buttonDone_LED);
            panelTask_LED.Controls.Add(groupBoxTask_LED);
            panelTask_LED.Dock = DockStyle.Top;
            panelTask_LED.Location = new Point(0, 0);
            panelTask_LED.Name = "panelTask_LED";
            panelTask_LED.Size = new Size(1042, 125);
            panelTask_LED.TabIndex = 0;
            // 
            // buttonHelp_LED
            // 
            buttonHelp_LED.BackColor = Color.PaleTurquoise;
            buttonHelp_LED.Location = new Point(936, 12);
            buttonHelp_LED.Name = "buttonHelp_LED";
            buttonHelp_LED.Size = new Size(94, 43);
            buttonHelp_LED.TabIndex = 2;
            buttonHelp_LED.Text = "Справка";
            toolTip_LED.SetToolTip(buttonHelp_LED, "Сведения о программе");
            buttonHelp_LED.UseVisualStyleBackColor = false;
            buttonHelp_LED.Click += buttonHelp_LED_Click;
            // 
            // buttonOpenFile_LED
            // 
            buttonOpenFile_LED.BackColor = Color.PaleGreen;
            buttonOpenFile_LED.Location = new Point(15, 3);
            buttonOpenFile_LED.Name = "buttonOpenFile_LED";
            buttonOpenFile_LED.Size = new Size(129, 43);
            buttonOpenFile_LED.TabIndex = 1;
            buttonOpenFile_LED.Text = "Открыть файл";
            toolTip_LED.SetToolTip(buttonOpenFile_LED, "Поиск в файле слов,в которых встречается l в результатирующую строку");
            buttonOpenFile_LED.UseVisualStyleBackColor = false;
            buttonOpenFile_LED.Click += buttonOpenFile_LED_Click;
            // 
            // buttonDone_LED
            // 
            buttonDone_LED.BackColor = Color.LightSeaGreen;
            buttonDone_LED.Location = new Point(150, 3);
            buttonDone_LED.Name = "buttonDone_LED";
            buttonDone_LED.Size = new Size(120, 43);
            buttonDone_LED.TabIndex = 1;
            buttonDone_LED.Text = "Выполнить";
            toolTip_LED.SetToolTip(buttonDone_LED, "Открыть файл\r\nВыберите нужный файл для  обработки");
            buttonDone_LED.UseVisualStyleBackColor = false;
            buttonDone_LED.Click += buttonDone_LED_Click;
            // 
            // groupBoxTask_LED
            // 
            groupBoxTask_LED.Controls.Add(textBoxTask_LED);
            groupBoxTask_LED.Location = new Point(3, 52);
            groupBoxTask_LED.Name = "groupBoxTask_LED";
            groupBoxTask_LED.Size = new Size(1036, 73);
            groupBoxTask_LED.TabIndex = 0;
            groupBoxTask_LED.TabStop = false;
            groupBoxTask_LED.Text = "Условие";
            // 
            // textBoxTask_LED
            // 
            textBoxTask_LED.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_LED.Location = new Point(3, 17);
            textBoxTask_LED.Multiline = true;
            textBoxTask_LED.Name = "textBoxTask_LED";
            textBoxTask_LED.ReadOnly = true;
            textBoxTask_LED.Size = new Size(1027, 50);
            textBoxTask_LED.TabIndex = 0;
            textBoxTask_LED.Text = "Дан файл, который может находится в любом месте на диске. Загрузить файл. Вывести слова, в которых встречается l в результирующеюстроку и вывести ее.";
            // 
            // panelVar_LED
            // 
            panelVar_LED.Controls.Add(groupBoxVar_LED);
            panelVar_LED.Dock = DockStyle.Left;
            panelVar_LED.Location = new Point(0, 125);
            panelVar_LED.Name = "panelVar_LED";
            panelVar_LED.Size = new Size(499, 416);
            panelVar_LED.TabIndex = 0;
            // 
            // groupBoxVar_LED
            // 
            groupBoxVar_LED.Controls.Add(textBoxVar_LED);
            groupBoxVar_LED.Location = new Point(12, 6);
            groupBoxVar_LED.Name = "groupBoxVar_LED";
            groupBoxVar_LED.Size = new Size(471, 398);
            groupBoxVar_LED.TabIndex = 1;
            groupBoxVar_LED.TabStop = false;
            groupBoxVar_LED.Text = "Ввод данных";
            // 
            // textBoxVar_LED
            // 
            textBoxVar_LED.Location = new Point(3, 23);
            textBoxVar_LED.Multiline = true;
            textBoxVar_LED.Name = "textBoxVar_LED";
            textBoxVar_LED.ScrollBars = ScrollBars.Vertical;
            textBoxVar_LED.Size = new Size(462, 369);
            textBoxVar_LED.TabIndex = 0;
            // 
            // panelResult_LED
            // 
            panelResult_LED.Controls.Add(groupBoxResult_LED);
            panelResult_LED.Controls.Add(splitter1);
            panelResult_LED.Dock = DockStyle.Right;
            panelResult_LED.Location = new Point(489, 125);
            panelResult_LED.Name = "panelResult_LED";
            panelResult_LED.Size = new Size(553, 416);
            panelResult_LED.TabIndex = 0;
            // 
            // groupBoxResult_LED
            // 
            groupBoxResult_LED.Controls.Add(textBoxResult_LED);
            groupBoxResult_LED.Location = new Point(16, 6);
            groupBoxResult_LED.Name = "groupBoxResult_LED";
            groupBoxResult_LED.Size = new Size(525, 398);
            groupBoxResult_LED.TabIndex = 1;
            groupBoxResult_LED.TabStop = false;
            groupBoxResult_LED.Text = "Вывод данных";
            // 
            // textBoxResult_LED
            // 
            textBoxResult_LED.Location = new Point(3, 23);
            textBoxResult_LED.Multiline = true;
            textBoxResult_LED.Name = "textBoxResult_LED";
            textBoxResult_LED.ReadOnly = true;
            textBoxResult_LED.ScrollBars = ScrollBars.Vertical;
            textBoxResult_LED.Size = new Size(516, 369);
            textBoxResult_LED.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 416);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // openFileDialog_LED
            // 
            openFileDialog_LED.FileName = "openFileDialog1";
            // 
            // toolTip_LED
            // 
            toolTip_LED.ToolTipIcon = ToolTipIcon.Info;
            toolTip_LED.ToolTipTitle = "Подсказка";
            // 
            // FormMain_LED
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1042, 541);
            Controls.Add(panelResult_LED);
            Controls.Add(panelVar_LED);
            Controls.Add(panelTask_LED);
            Name = "FormMain_LED";
            Text = "Спринт 6 | Таск 6 | Вариант 5 | Лавринович Е.Д.";
            panelTask_LED.ResumeLayout(false);
            groupBoxTask_LED.ResumeLayout(false);
            groupBoxTask_LED.PerformLayout();
            panelVar_LED.ResumeLayout(false);
            groupBoxVar_LED.ResumeLayout(false);
            groupBoxVar_LED.PerformLayout();
            panelResult_LED.ResumeLayout(false);
            groupBoxResult_LED.ResumeLayout(false);
            groupBoxResult_LED.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask_LED;
        private GroupBox groupBoxTask_LED;
        private Panel panelVar_LED;
        private Panel panelResult_LED;
        private Splitter splitter1;
        private TextBox textBoxTask_LED;
        private GroupBox groupBoxVar_LED;
        private TextBox textBoxVar_LED;
        private GroupBox groupBoxResult_LED;
        private TextBox textBoxResult_LED;
        private Button buttonOpenFile_LED;
        private Button buttonDone_LED;
        private OpenFileDialog openFileDialog_LED;
        private ToolTip toolTip_LED;
        private Button buttonHelp_LED;
    }
}
