namespace Tyuiu.LavrinovichED.Sprint6.Task1.V9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_LED));
            groupBoxTask_LED = new GroupBox();
            labelTask_LED = new Label();
            pictureBoxTask_LED = new PictureBox();
            groupBoxVar_LED = new GroupBox();
            groupBoxStop_LED = new GroupBox();
            textBoxStop_LED = new TextBox();
            groupBoxStart_LED = new GroupBox();
            textBoxStart_LED = new TextBox();
            buttonHelp_LED = new Button();
            buttonDone_LED = new Button();
            groupBoxDone_LED = new GroupBox();
            labelResult_LED = new Label();
            textBoxResult_LED = new TextBox();
            groupBoxTask_LED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_LED).BeginInit();
            groupBoxVar_LED.SuspendLayout();
            groupBoxStop_LED.SuspendLayout();
            groupBoxStart_LED.SuspendLayout();
            groupBoxDone_LED.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_LED
            // 
            groupBoxTask_LED.Controls.Add(labelTask_LED);
            groupBoxTask_LED.Controls.Add(pictureBoxTask_LED);
            groupBoxTask_LED.Location = new Point(12, 12);
            groupBoxTask_LED.Name = "groupBoxTask_LED";
            groupBoxTask_LED.Size = new Size(652, 320);
            groupBoxTask_LED.TabIndex = 0;
            groupBoxTask_LED.TabStop = false;
            groupBoxTask_LED.Text = "Условие:";
            // 
            // labelTask_LED
            // 
            labelTask_LED.AutoSize = true;
            labelTask_LED.Location = new Point(9, 23);
            labelTask_LED.Name = "labelTask_LED";
            labelTask_LED.Size = new Size(443, 40);
            labelTask_LED.TabIndex = 0;
            labelTask_LED.Text = "Произвести табулирование функции на заданном диапазоне.\r\nРезультат выевсти в виде таблицы";
            // 
            // pictureBoxTask_LED
            // 
            pictureBoxTask_LED.ErrorImage = null;
            pictureBoxTask_LED.Image = (Image)resources.GetObject("pictureBoxTask_LED.Image");
            pictureBoxTask_LED.Location = new Point(167, 131);
            pictureBoxTask_LED.Name = "pictureBoxTask_LED";
            pictureBoxTask_LED.Size = new Size(312, 55);
            pictureBoxTask_LED.TabIndex = 1;
            pictureBoxTask_LED.TabStop = false;
            // 
            // groupBoxVar_LED
            // 
            groupBoxVar_LED.Controls.Add(groupBoxStop_LED);
            groupBoxVar_LED.Controls.Add(groupBoxStart_LED);
            groupBoxVar_LED.Location = new Point(12, 338);
            groupBoxVar_LED.Name = "groupBoxVar_LED";
            groupBoxVar_LED.Size = new Size(375, 98);
            groupBoxVar_LED.TabIndex = 2;
            groupBoxVar_LED.TabStop = false;
            groupBoxVar_LED.Text = "Ввод данных";
            // 
            // groupBoxStop_LED
            // 
            groupBoxStop_LED.Controls.Add(textBoxStop_LED);
            groupBoxStop_LED.Location = new Point(188, 26);
            groupBoxStop_LED.Name = "groupBoxStop_LED";
            groupBoxStop_LED.Size = new Size(178, 55);
            groupBoxStop_LED.TabIndex = 3;
            groupBoxStop_LED.TabStop = false;
            groupBoxStop_LED.Text = "Конец шага:";
            // 
            // textBoxStop_LED
            // 
            textBoxStop_LED.Location = new Point(6, 22);
            textBoxStop_LED.Name = "textBoxStop_LED";
            textBoxStop_LED.Size = new Size(164, 27);
            textBoxStop_LED.TabIndex = 3;
            textBoxStop_LED.Text = "5";
            // 
            // groupBoxStart_LED
            // 
            groupBoxStart_LED.Controls.Add(textBoxStart_LED);
            groupBoxStart_LED.Location = new Point(6, 26);
            groupBoxStart_LED.Name = "groupBoxStart_LED";
            groupBoxStart_LED.Size = new Size(176, 55);
            groupBoxStart_LED.TabIndex = 2;
            groupBoxStart_LED.TabStop = false;
            groupBoxStart_LED.Text = "Старт шага:";
            // 
            // textBoxStart_LED
            // 
            textBoxStart_LED.Location = new Point(3, 23);
            textBoxStart_LED.Name = "textBoxStart_LED";
            textBoxStart_LED.Size = new Size(167, 27);
            textBoxStart_LED.TabIndex = 0;
            textBoxStart_LED.Text = "-5";
            // 
            // buttonHelp_LED
            // 
            buttonHelp_LED.BackColor = Color.SkyBlue;
            buttonHelp_LED.ForeColor = SystemColors.ControlText;
            buttonHelp_LED.Location = new Point(456, 372);
            buttonHelp_LED.Name = "buttonHelp_LED";
            buttonHelp_LED.Size = new Size(94, 55);
            buttonHelp_LED.TabIndex = 4;
            buttonHelp_LED.Text = "Справка";
            buttonHelp_LED.UseVisualStyleBackColor = false;
            buttonHelp_LED.Click += buttonHelp_LED_Click;
            // 
            // buttonDone_LED
            // 
            buttonDone_LED.BackColor = Color.LimeGreen;
            buttonDone_LED.Location = new Point(556, 372);
            buttonDone_LED.Name = "buttonDone_LED";
            buttonDone_LED.Size = new Size(108, 55);
            buttonDone_LED.TabIndex = 5;
            buttonDone_LED.Text = "Выполнить";
            buttonDone_LED.UseVisualStyleBackColor = false;
            buttonDone_LED.Click += buttonDone_LED_Click;
            // 
            // groupBoxDone_LED
            // 
            groupBoxDone_LED.Controls.Add(labelResult_LED);
            groupBoxDone_LED.Controls.Add(textBoxResult_LED);
            groupBoxDone_LED.Location = new Point(670, 12);
            groupBoxDone_LED.Name = "groupBoxDone_LED";
            groupBoxDone_LED.Size = new Size(323, 424);
            groupBoxDone_LED.TabIndex = 6;
            groupBoxDone_LED.TabStop = false;
            groupBoxDone_LED.Text = "Вывод данных";
            // 
            // labelResult_LED
            // 
            labelResult_LED.AutoSize = true;
            labelResult_LED.Location = new Point(6, 23);
            labelResult_LED.Name = "labelResult_LED";
            labelResult_LED.Size = new Size(78, 20);
            labelResult_LED.TabIndex = 1;
            labelResult_LED.Text = "Результат:";
            // 
            // textBoxResult_LED
            // 
            textBoxResult_LED.BackColor = SystemColors.Control;
            textBoxResult_LED.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_LED.Location = new Point(6, 46);
            textBoxResult_LED.Multiline = true;
            textBoxResult_LED.Name = "textBoxResult_LED";
            textBoxResult_LED.ReadOnly = true;
            textBoxResult_LED.ScrollBars = ScrollBars.Vertical;
            textBoxResult_LED.Size = new Size(311, 361);
            textBoxResult_LED.TabIndex = 0;
            textBoxResult_LED.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // FormMain_LED
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 459);
            Controls.Add(groupBoxDone_LED);
            Controls.Add(buttonDone_LED);
            Controls.Add(buttonHelp_LED);
            Controls.Add(groupBoxVar_LED);
            Controls.Add(groupBoxTask_LED);
            Name = "FormMain_LED";
            Text = "Спринт 6 | Таск 1 | Вариант 9 | Лавринович Е.Д.";
            groupBoxTask_LED.ResumeLayout(false);
            groupBoxTask_LED.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_LED).EndInit();
            groupBoxVar_LED.ResumeLayout(false);
            groupBoxStop_LED.ResumeLayout(false);
            groupBoxStop_LED.PerformLayout();
            groupBoxStart_LED.ResumeLayout(false);
            groupBoxStart_LED.PerformLayout();
            groupBoxDone_LED.ResumeLayout(false);
            groupBoxDone_LED.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_LED;
        private TextBox textBoxTask_LED;
        private PictureBox pictureBoxTask_LED;
        private GroupBox groupBoxVar_LED;
        private GroupBox groupBoxStop_LED;
        private TextBox textBoxStop_LED;
        private GroupBox groupBoxStart_LED;
        private TextBox textBoxStart_LED;
        private Button buttonHelp_LED;
        private Button buttonDone_LED;
        private GroupBox groupBoxDone_LED;
        private Label labelTask_LED;
        private Label labelResult_LED;
        private TextBox textBoxResult_LED;
    }
}
