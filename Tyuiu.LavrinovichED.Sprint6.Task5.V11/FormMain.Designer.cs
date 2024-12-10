namespace Tyuiu.LavrinovichED.Sprint6.Task5.V11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_LED = new GroupBox();
            textBoxTask_LED = new TextBox();
            buttonDone_LED = new Button();
            buttonFile_LED = new Button();
            buttonHelp_LED = new Button();
            groupBoxVar_LED = new GroupBox();
            dataGridViewResult_LED = new DataGridView();
            chartResult_LED = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_LED.SuspendLayout();
            groupBoxVar_LED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_LED).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_LED).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_LED
            // 
            groupBoxTask_LED.Controls.Add(textBoxTask_LED);
            groupBoxTask_LED.Location = new Point(12, 12);
            groupBoxTask_LED.Name = "groupBoxTask_LED";
            groupBoxTask_LED.Size = new Size(556, 112);
            groupBoxTask_LED.TabIndex = 0;
            groupBoxTask_LED.TabStop = false;
            groupBoxTask_LED.Text = "Условие";
            // 
            // textBoxTask_LED
            // 
            textBoxTask_LED.Location = new Point(12, 26);
            textBoxTask_LED.Multiline = true;
            textBoxTask_LED.Name = "textBoxTask_LED";
            textBoxTask_LED.ReadOnly = true;
            textBoxTask_LED.Size = new Size(541, 72);
            textBoxTask_LED.TabIndex = 1;
            textBoxTask_LED.Text = "Прочитать данные из файла InPutFileTask5V11.txt. Вывести все\r\nчисла кратные 5. Построить диаграмму по этим значениям. У \r\nвещественных значений округлить до трех знаков после запятой";
            // 
            // buttonDone_LED
            // 
            buttonDone_LED.BackColor = Color.PaleGreen;
            buttonDone_LED.Location = new Point(574, 38);
            buttonDone_LED.Name = "buttonDone_LED";
            buttonDone_LED.Size = new Size(108, 72);
            buttonDone_LED.TabIndex = 1;
            buttonDone_LED.Text = "Выполнить";
            buttonDone_LED.UseVisualStyleBackColor = false;
            buttonDone_LED.Click += buttonDone_LED_Click;
            // 
            // buttonFile_LED
            // 
            buttonFile_LED.BackColor = Color.CornflowerBlue;
            buttonFile_LED.Location = new Point(688, 38);
            buttonFile_LED.Name = "buttonFile_LED";
            buttonFile_LED.Size = new Size(108, 72);
            buttonFile_LED.TabIndex = 2;
            buttonFile_LED.Text = "Открыть файл";
            buttonFile_LED.UseVisualStyleBackColor = false;
            buttonFile_LED.Click += buttonFile_LED_Click;
            // 
            // buttonHelp_LED
            // 
            buttonHelp_LED.BackColor = Color.PaleTurquoise;
            buttonHelp_LED.Location = new Point(802, 38);
            buttonHelp_LED.Name = "buttonHelp_LED";
            buttonHelp_LED.Size = new Size(108, 72);
            buttonHelp_LED.TabIndex = 3;
            buttonHelp_LED.Text = "Справка";
            buttonHelp_LED.UseVisualStyleBackColor = false;
            buttonHelp_LED.Click += buttonHelp_LED_Click;
            // 
            // groupBoxVar_LED
            // 
            groupBoxVar_LED.Controls.Add(dataGridViewResult_LED);
            groupBoxVar_LED.Location = new Point(12, 130);
            groupBoxVar_LED.Name = "groupBoxVar_LED";
            groupBoxVar_LED.Size = new Size(250, 404);
            groupBoxVar_LED.TabIndex = 4;
            groupBoxVar_LED.TabStop = false;
            groupBoxVar_LED.Text = "Вывод данных";
            // 
            // dataGridViewResult_LED
            // 
            dataGridViewResult_LED.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_LED.Location = new Point(3, 23);
            dataGridViewResult_LED.Name = "dataGridViewResult_LED";
            dataGridViewResult_LED.RowHeadersWidth = 51;
            dataGridViewResult_LED.ScrollBars = ScrollBars.Vertical;
            dataGridViewResult_LED.Size = new Size(241, 375);
            dataGridViewResult_LED.TabIndex = 0;
            // 
            // chartResult_LED
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_LED.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult_LED.Legends.Add(legend1);
            chartResult_LED.Location = new Point(268, 130);
            chartResult_LED.Name = "chartResult_LED";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_LED.Series.Add(series1);
            chartResult_LED.Size = new Size(642, 398);
            chartResult_LED.TabIndex = 1;
            chartResult_LED.Text = "chart1";
            // 
            // FormMain_LED
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 546);
            Controls.Add(chartResult_LED);
            Controls.Add(groupBoxVar_LED);
            Controls.Add(buttonHelp_LED);
            Controls.Add(buttonFile_LED);
            Controls.Add(buttonDone_LED);
            Controls.Add(groupBoxTask_LED);
            Name = "FormMain_LED";
            Text = "Спринт 6 | Таск 5 | Вариант 11 | Лавринович Е.Д.";
            groupBoxTask_LED.ResumeLayout(false);
            groupBoxTask_LED.PerformLayout();
            groupBoxVar_LED.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_LED).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_LED).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_LED;
        private TextBox textBoxTask_LED;
        private Button buttonDone_LED;
        private Button buttonFile_LED;
        private Button buttonHelp_LED;
        private GroupBox groupBoxVar_LED;
        private DataGridView dataGridViewResult_LED;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_LED;
    }
}
