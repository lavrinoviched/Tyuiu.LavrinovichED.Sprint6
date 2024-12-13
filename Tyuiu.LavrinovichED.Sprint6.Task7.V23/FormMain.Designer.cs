namespace Tyuiu.LavrinovichED.Sprint6.Task7.V23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_LED));
            panelClick_LED = new Panel();
            groupBoxTask_LED = new GroupBox();
            textBoxTask_LED = new TextBox();
            splitterTask_LED = new Splitter();
            panelTask_LED = new Panel();
            buttonHels_LED = new Button();
            buttonPush_LED = new Button();
            buttonDone_LED = new Button();
            buttonFile_LED = new Button();
            splitterClick_LED = new Splitter();
            panelVar_LED = new Panel();
            groupBoxVar_LED = new GroupBox();
            dataGridViewVar_LED = new DataGridView();
            panelResilt_LED = new Panel();
            splitterVAarResult_LED = new Splitter();
            openFileDialog_LED = new OpenFileDialog();
            toolTip_LED = new ToolTip(components);
            groupBoxResult_LED = new GroupBox();
            dataGridViewResult_LED = new DataGridView();
            saveFileDialog_LED = new SaveFileDialog();
            panelClick_LED.SuspendLayout();
            groupBoxTask_LED.SuspendLayout();
            panelTask_LED.SuspendLayout();
            panelVar_LED.SuspendLayout();
            groupBoxVar_LED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVar_LED).BeginInit();
            groupBoxResult_LED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_LED).BeginInit();
            SuspendLayout();
            // 
            // panelClick_LED
            // 
            panelClick_LED.Controls.Add(groupBoxTask_LED);
            panelClick_LED.Controls.Add(splitterTask_LED);
            panelClick_LED.Controls.Add(panelTask_LED);
            panelClick_LED.Dock = DockStyle.Top;
            panelClick_LED.Location = new Point(0, 0);
            panelClick_LED.Name = "panelClick_LED";
            panelClick_LED.Size = new Size(1039, 128);
            panelClick_LED.TabIndex = 0;
            // 
            // groupBoxTask_LED
            // 
            groupBoxTask_LED.Controls.Add(textBoxTask_LED);
            groupBoxTask_LED.Dock = DockStyle.Top;
            groupBoxTask_LED.Location = new Point(0, 53);
            groupBoxTask_LED.Name = "groupBoxTask_LED";
            groupBoxTask_LED.Size = new Size(1039, 63);
            groupBoxTask_LED.TabIndex = 2;
            groupBoxTask_LED.TabStop = false;
            groupBoxTask_LED.Text = "Условие:";
            // 
            // textBoxTask_LED
            // 
            textBoxTask_LED.Location = new Point(9, 16);
            textBoxTask_LED.Multiline = true;
            textBoxTask_LED.Name = "textBoxTask_LED";
            textBoxTask_LED.ReadOnly = true;
            textBoxTask_LED.Size = new Size(1021, 47);
            textBoxTask_LED.TabIndex = 0;
            textBoxTask_LED.Text = "Дан файл, в котором хранится матрица целочисленных значений. Загрузить файл в таблицу. Изменить в последнем столбце значения меньше 2 на 2";
            // 
            // splitterTask_LED
            // 
            splitterTask_LED.Dock = DockStyle.Bottom;
            splitterTask_LED.Location = new Point(0, 124);
            splitterTask_LED.Name = "splitterTask_LED";
            splitterTask_LED.Size = new Size(1039, 4);
            splitterTask_LED.TabIndex = 1;
            splitterTask_LED.TabStop = false;
            // 
            // panelTask_LED
            // 
            panelTask_LED.Controls.Add(buttonHels_LED);
            panelTask_LED.Controls.Add(buttonPush_LED);
            panelTask_LED.Controls.Add(buttonDone_LED);
            panelTask_LED.Controls.Add(buttonFile_LED);
            panelTask_LED.Controls.Add(splitterClick_LED);
            panelTask_LED.Dock = DockStyle.Top;
            panelTask_LED.Location = new Point(0, 0);
            panelTask_LED.Name = "panelTask_LED";
            panelTask_LED.Size = new Size(1039, 53);
            panelTask_LED.TabIndex = 0;
            // 
            // buttonHels_LED
            // 
            buttonHels_LED.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHels_LED.FlatStyle = FlatStyle.Flat;
            buttonHels_LED.Image = (Image)resources.GetObject("buttonHels_LED.Image");
            buttonHels_LED.Location = new Point(933, 0);
            buttonHels_LED.Name = "buttonHels_LED";
            buttonHels_LED.Size = new Size(94, 50);
            buttonHels_LED.TabIndex = 5;
            toolTip_LED.SetToolTip(buttonHels_LED, "О приложении");
            buttonHels_LED.UseVisualStyleBackColor = true;
            buttonHels_LED.Click += buttonHels_LED_Click;
            buttonHels_LED.MouseEnter += buttonHelp_LED_MouseEnter;
            // 
            // buttonPush_LED
            // 
            buttonPush_LED.Enabled = false;
            buttonPush_LED.FlatStyle = FlatStyle.Flat;
            buttonPush_LED.Image = (Image)resources.GetObject("buttonPush_LED.Image");
            buttonPush_LED.Location = new Point(212, 3);
            buttonPush_LED.Name = "buttonPush_LED";
            buttonPush_LED.Size = new Size(94, 47);
            buttonPush_LED.TabIndex = 4;
            toolTip_LED.SetToolTip(buttonPush_LED, "Сохранить");
            buttonPush_LED.UseVisualStyleBackColor = true;
            buttonPush_LED.Click += buttonPush_LED_Click;
            buttonPush_LED.MouseEnter += buttonPush_LED_MouseEnter;
            // 
            // buttonDone_LED
            // 
            buttonDone_LED.Enabled = false;
            buttonDone_LED.FlatStyle = FlatStyle.Flat;
            buttonDone_LED.Image = (Image)resources.GetObject("buttonDone_LED.Image");
            buttonDone_LED.Location = new Point(112, 3);
            buttonDone_LED.Name = "buttonDone_LED";
            buttonDone_LED.Size = new Size(94, 47);
            buttonDone_LED.TabIndex = 3;
            toolTip_LED.SetToolTip(buttonDone_LED, "Выполнить");
            buttonDone_LED.UseVisualStyleBackColor = true;
            buttonDone_LED.Click += buttonDone_LED_Click;
            buttonDone_LED.MouseEnter += buttonDone_LED_MouseEnter;
            // 
            // buttonFile_LED
            // 
            buttonFile_LED.FlatStyle = FlatStyle.Flat;
            buttonFile_LED.Image = (Image)resources.GetObject("buttonFile_LED.Image");
            buttonFile_LED.Location = new Point(12, 3);
            buttonFile_LED.Name = "buttonFile_LED";
            buttonFile_LED.Size = new Size(94, 47);
            buttonFile_LED.TabIndex = 2;
            toolTip_LED.SetToolTip(buttonFile_LED, "Открыть файл");
            buttonFile_LED.UseVisualStyleBackColor = true;
            buttonFile_LED.Click += buttonFile_LED_Click;
            buttonFile_LED.MouseEnter += buttonFile_LED_MouseEnter;
            // 
            // splitterClick_LED
            // 
            splitterClick_LED.Dock = DockStyle.Bottom;
            splitterClick_LED.Location = new Point(0, 49);
            splitterClick_LED.Name = "splitterClick_LED";
            splitterClick_LED.Size = new Size(1039, 4);
            splitterClick_LED.TabIndex = 0;
            splitterClick_LED.TabStop = false;
            // 
            // panelVar_LED
            // 
            panelVar_LED.Controls.Add(groupBoxVar_LED);
            panelVar_LED.Controls.Add(panelResilt_LED);
            panelVar_LED.Controls.Add(splitterVAarResult_LED);
            panelVar_LED.Dock = DockStyle.Left;
            panelVar_LED.Location = new Point(0, 128);
            panelVar_LED.Name = "panelVar_LED";
            panelVar_LED.Size = new Size(513, 355);
            panelVar_LED.TabIndex = 1;
            // 
            // groupBoxVar_LED
            // 
            groupBoxVar_LED.Controls.Add(dataGridViewVar_LED);
            groupBoxVar_LED.Dock = DockStyle.Left;
            groupBoxVar_LED.Location = new Point(0, 0);
            groupBoxVar_LED.Name = "groupBoxVar_LED";
            groupBoxVar_LED.Size = new Size(497, 355);
            groupBoxVar_LED.TabIndex = 6;
            groupBoxVar_LED.TabStop = false;
            groupBoxVar_LED.Text = "Ввод данных";
            // 
            // dataGridViewVar_LED
            // 
            dataGridViewVar_LED.ColumnHeadersHeight = 30;
            dataGridViewVar_LED.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewVar_LED.Dock = DockStyle.Left;
            dataGridViewVar_LED.Location = new Point(3, 23);
            dataGridViewVar_LED.Name = "dataGridViewVar_LED";
            dataGridViewVar_LED.RowHeadersVisible = false;
            dataGridViewVar_LED.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewVar_LED.Size = new Size(494, 329);
            dataGridViewVar_LED.TabIndex = 0;
            // 
            // panelResilt_LED
            // 
            panelResilt_LED.Location = new Point(511, 0);
            panelResilt_LED.Name = "panelResilt_LED";
            panelResilt_LED.Size = new Size(528, 314);
            panelResilt_LED.TabIndex = 1;
            // 
            // splitterVAarResult_LED
            // 
            splitterVAarResult_LED.Dock = DockStyle.Right;
            splitterVAarResult_LED.Location = new Point(509, 0);
            splitterVAarResult_LED.Name = "splitterVAarResult_LED";
            splitterVAarResult_LED.Size = new Size(4, 355);
            splitterVAarResult_LED.TabIndex = 0;
            splitterVAarResult_LED.TabStop = false;
            // 
            // openFileDialog_LED
            // 
            openFileDialog_LED.FileName = "Откройте файл";
            // 
            // toolTip_LED
            // 
            toolTip_LED.IsBalloon = true;
            toolTip_LED.ToolTipTitle = "Подсказка";
            // 
            // groupBoxResult_LED
            // 
            groupBoxResult_LED.Controls.Add(dataGridViewResult_LED);
            groupBoxResult_LED.Dock = DockStyle.Right;
            groupBoxResult_LED.Location = new Point(522, 128);
            groupBoxResult_LED.Name = "groupBoxResult_LED";
            groupBoxResult_LED.Size = new Size(517, 355);
            groupBoxResult_LED.TabIndex = 1;
            groupBoxResult_LED.TabStop = false;
            groupBoxResult_LED.Text = "Вывод данных";
            // 
            // dataGridViewResult_LED
            // 
            dataGridViewResult_LED.ColumnHeadersHeight = 30;
            dataGridViewResult_LED.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewResult_LED.Dock = DockStyle.Right;
            dataGridViewResult_LED.Location = new Point(6, 23);
            dataGridViewResult_LED.Name = "dataGridViewResult_LED";
            dataGridViewResult_LED.RowHeadersVisible = false;
            dataGridViewResult_LED.RowHeadersWidth = 51;
            dataGridViewResult_LED.Size = new Size(508, 329);
            dataGridViewResult_LED.TabIndex = 0;
            // 
            // FormMain_LED
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 483);
            Controls.Add(groupBoxResult_LED);
            Controls.Add(panelVar_LED);
            Controls.Add(panelClick_LED);
            Name = "FormMain_LED";
            Text = "Спринт 6 | Таск 7 | Вариант 23 | Лавринович Е.Д.";
            panelClick_LED.ResumeLayout(false);
            groupBoxTask_LED.ResumeLayout(false);
            groupBoxTask_LED.PerformLayout();
            panelTask_LED.ResumeLayout(false);
            panelVar_LED.ResumeLayout(false);
            groupBoxVar_LED.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVar_LED).EndInit();
            groupBoxResult_LED.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_LED).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelClick_LED;
        private Panel panelTask_LED;
        private Splitter splitterClick_LED;
        private Panel panelVar_LED;
        private Splitter splitterTask_LED;
        private Panel panelResilt_LED;
        private Splitter splitterVAarResult_LED;
        private GroupBox groupBoxTask_LED;
        private TextBox textBoxTask_LED;
        private Button buttonHels_LED;
        private Button buttonPush_LED;
        private Button buttonDone_LED;
        private Button buttonFile_LED;
        private OpenFileDialog openFileDialog_LED;
        private ToolTip toolTip_LED;
        private GroupBox groupBoxVar_LED;
        private DataGridView dataGridViewVar_LED;
        private GroupBox groupBoxResult_LED;
        private DataGridView dataGridViewResult_LED;
        private SaveFileDialog saveFileDialog_LED;
    }
}
