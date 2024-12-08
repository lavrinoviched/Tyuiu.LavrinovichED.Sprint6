namespace Tyuiu.LavrinovichEd.Sprint6.Task3.V28
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
            groupBoxTask_LED = new GroupBox();
            dataGridViewVar_LED = new DataGridView();
            labelTask_LED = new Label();
            groupBoxResult_LED = new GroupBox();
            dataGridViewResult_LED = new DataGridView();
            buttonDone_LED = new Button();
            buttonHelp_LED = new Button();
            labelResult_LED = new Label();
            groupBoxTask_LED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVar_LED).BeginInit();
            groupBoxResult_LED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_LED).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_LED
            // 
            groupBoxTask_LED.Controls.Add(dataGridViewVar_LED);
            groupBoxTask_LED.Controls.Add(labelTask_LED);
            groupBoxTask_LED.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxTask_LED.Location = new Point(12, 12);
            groupBoxTask_LED.Name = "groupBoxTask_LED";
            groupBoxTask_LED.Size = new Size(663, 320);
            groupBoxTask_LED.TabIndex = 0;
            groupBoxTask_LED.TabStop = false;
            groupBoxTask_LED.Text = "Условие";
            // 
            // dataGridViewVar_LED
            // 
            dataGridViewVar_LED.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVar_LED.Location = new Point(374, 38);
            dataGridViewVar_LED.Name = "dataGridViewVar_LED";
            dataGridViewVar_LED.RowHeadersVisible = false;
            dataGridViewVar_LED.RowHeadersWidth = 51;
            dataGridViewVar_LED.Size = new Size(283, 224);
            dataGridViewVar_LED.TabIndex = 1;
            // 
            // labelTask_LED
            // 
            labelTask_LED.AutoSize = true;
            labelTask_LED.Location = new Point(14, 38);
            labelTask_LED.Name = "labelTask_LED";
            labelTask_LED.Size = new Size(343, 260);
            labelTask_LED.TabIndex = 0;
            labelTask_LED.Text = "Дана матрица 5 на 5\r\n\r\n-9   8   9  16 -18\r\n\r\n -13 -11 -20 -15   9\r\n\r\n  18  13 -12 -15 -11\r\n\r\n  10  -2  19  -4 -10\r\n\r\n   6 -20  -4  13 -14\r\n\r\nзаменить четные числа в четвертой строке на 0";
            // 
            // groupBoxResult_LED
            // 
            groupBoxResult_LED.Controls.Add(dataGridViewResult_LED);
            groupBoxResult_LED.Controls.Add(buttonDone_LED);
            groupBoxResult_LED.Controls.Add(buttonHelp_LED);
            groupBoxResult_LED.Controls.Add(labelResult_LED);
            groupBoxResult_LED.Location = new Point(681, 12);
            groupBoxResult_LED.Name = "groupBoxResult_LED";
            groupBoxResult_LED.Size = new Size(250, 320);
            groupBoxResult_LED.TabIndex = 1;
            groupBoxResult_LED.TabStop = false;
            groupBoxResult_LED.Text = "Вывод данных";
            // 
            // dataGridViewResult_LED
            // 
            dataGridViewResult_LED.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_LED.Location = new Point(15, 61);
            dataGridViewResult_LED.Name = "dataGridViewResult_LED";
            dataGridViewResult_LED.RowHeadersVisible = false;
            dataGridViewResult_LED.RowHeadersWidth = 51;
            dataGridViewResult_LED.Size = new Size(229, 188);
            dataGridViewResult_LED.TabIndex = 2;
            // 
            // buttonDone_LED
            // 
            buttonDone_LED.Location = new Point(110, 281);
            buttonDone_LED.Name = "buttonDone_LED";
            buttonDone_LED.Size = new Size(134, 33);
            buttonDone_LED.TabIndex = 2;
            buttonDone_LED.Text = "Выполнить";
            buttonDone_LED.UseVisualStyleBackColor = true;
            buttonDone_LED.Click += buttonDone_LED_Click;
            // 
            // buttonHelp_LED
            // 
            buttonHelp_LED.Location = new Point(15, 281);
            buttonHelp_LED.Name = "buttonHelp_LED";
            buttonHelp_LED.Size = new Size(56, 33);
            buttonHelp_LED.TabIndex = 2;
            buttonHelp_LED.Text = "?";
            buttonHelp_LED.UseVisualStyleBackColor = true;
            buttonHelp_LED.Click += buttonHelp_LED_Click;
            // 
            // labelResult_LED
            // 
            labelResult_LED.AutoSize = true;
            labelResult_LED.Location = new Point(15, 38);
            labelResult_LED.Name = "labelResult_LED";
            labelResult_LED.Size = new Size(75, 20);
            labelResult_LED.TabIndex = 1;
            labelResult_LED.Text = "Результат";
            // 
            // FormMain_LED
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 338);
            Controls.Add(groupBoxResult_LED);
            Controls.Add(groupBoxTask_LED);
            MaximizeBox = false;
            Name = "FormMain_LED";
            Text = "Спринт 6 | Таск 3 | Вариант 28 | Лавринович Е.Д.";
            Load += FormMain_LED_Load;
            groupBoxTask_LED.ResumeLayout(false);
            groupBoxTask_LED.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVar_LED).EndInit();
            groupBoxResult_LED.ResumeLayout(false);
            groupBoxResult_LED.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_LED).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_LED;
        private Label labelTask_LED;
        private GroupBox groupBoxResult_LED;
        private Button buttonDone_LED;
        private Button buttonHelp_LED;
        private Label labelResult_LED;
        private TextBox textBoxResult_LED;
        private DataGridView dataGridViewVar_LED;
        private DataGridView dataGridViewResult_LED;
    }
}
