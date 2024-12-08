namespace Tyuiu.LavrinovichED.Sprint6.Task2.V14
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_LED = new GroupBox();
            pictureBoxTask_LED = new PictureBox();
            labelTask_LED = new Label();
            groupBoxVar_LED = new GroupBox();
            labelStop_LED = new Label();
            textBoxStop_LED = new TextBox();
            textBoxStart_LED = new TextBox();
            labelStart_LED = new Label();
            buttonHelp_LED = new Button();
            buttonDone_LED = new Button();
            dataGridViewResult_LED = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            chartResult_LED = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxResult_LED = new GroupBox();
            labelResult_LED = new Label();
            groupBoxTask_LED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_LED).BeginInit();
            groupBoxVar_LED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_LED).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_LED).BeginInit();
            groupBoxResult_LED.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_LED
            // 
            groupBoxTask_LED.Controls.Add(pictureBoxTask_LED);
            groupBoxTask_LED.Controls.Add(labelTask_LED);
            groupBoxTask_LED.Location = new Point(12, 3);
            groupBoxTask_LED.Name = "groupBoxTask_LED";
            groupBoxTask_LED.Size = new Size(589, 253);
            groupBoxTask_LED.TabIndex = 0;
            groupBoxTask_LED.TabStop = false;
            groupBoxTask_LED.Text = "Условие";
            // 
            // pictureBoxTask_LED
            // 
            pictureBoxTask_LED.Image = (Image)resources.GetObject("pictureBoxTask_LED.Image");
            pictureBoxTask_LED.Location = new Point(153, 96);
            pictureBoxTask_LED.Name = "pictureBoxTask_LED";
            pictureBoxTask_LED.Size = new Size(299, 46);
            pictureBoxTask_LED.TabIndex = 2;
            pictureBoxTask_LED.TabStop = false;
            // 
            // labelTask_LED
            // 
            labelTask_LED.AutoSize = true;
            labelTask_LED.Location = new Point(6, 23);
            labelTask_LED.Name = "labelTask_LED";
            labelTask_LED.Size = new Size(417, 40);
            labelTask_LED.TabIndex = 1;
            labelTask_LED.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в таблицу и построить график функции.";
            // 
            // groupBoxVar_LED
            // 
            groupBoxVar_LED.Controls.Add(labelStop_LED);
            groupBoxVar_LED.Controls.Add(textBoxStop_LED);
            groupBoxVar_LED.Controls.Add(textBoxStart_LED);
            groupBoxVar_LED.Controls.Add(labelStart_LED);
            groupBoxVar_LED.Location = new Point(12, 255);
            groupBoxVar_LED.Name = "groupBoxVar_LED";
            groupBoxVar_LED.Size = new Size(339, 94);
            groupBoxVar_LED.TabIndex = 3;
            groupBoxVar_LED.TabStop = false;
            groupBoxVar_LED.Text = "Ввод данных";
            // 
            // labelStop_LED
            // 
            labelStop_LED.AutoSize = true;
            labelStop_LED.Location = new Point(190, 23);
            labelStop_LED.Name = "labelStop_LED";
            labelStop_LED.Size = new Size(94, 20);
            labelStop_LED.TabIndex = 5;
            labelStop_LED.Text = "Конец шага:";
            // 
            // textBoxStop_LED
            // 
            textBoxStop_LED.Location = new Point(190, 46);
            textBoxStop_LED.Name = "textBoxStop_LED";
            textBoxStop_LED.Size = new Size(125, 27);
            textBoxStop_LED.TabIndex = 4;
            textBoxStop_LED.Text = "5";
            textBoxStop_LED.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxStart_LED
            // 
            textBoxStart_LED.Location = new Point(21, 46);
            textBoxStart_LED.Name = "textBoxStart_LED";
            textBoxStart_LED.Size = new Size(125, 27);
            textBoxStart_LED.TabIndex = 1;
            textBoxStart_LED.Text = "-5";
            textBoxStart_LED.TextAlign = HorizontalAlignment.Center;
            // 
            // labelStart_LED
            // 
            labelStart_LED.AutoSize = true;
            labelStart_LED.Location = new Point(21, 23);
            labelStart_LED.Name = "labelStart_LED";
            labelStart_LED.Size = new Size(88, 20);
            labelStart_LED.TabIndex = 0;
            labelStart_LED.Text = "Старт шага:";
            // 
            // buttonHelp_LED
            // 
            buttonHelp_LED.BackColor = Color.PaleTurquoise;
            buttonHelp_LED.Location = new Point(370, 278);
            buttonHelp_LED.Name = "buttonHelp_LED";
            buttonHelp_LED.Size = new Size(94, 57);
            buttonHelp_LED.TabIndex = 6;
            buttonHelp_LED.Text = "Справка";
            buttonHelp_LED.UseVisualStyleBackColor = false;
            buttonHelp_LED.Click += buttonHelp_LED_Click;
            // 
            // buttonDone_LED
            // 
            buttonDone_LED.BackColor = Color.PaleGreen;
            buttonDone_LED.Location = new Point(470, 278);
            buttonDone_LED.Name = "buttonDone_LED";
            buttonDone_LED.Size = new Size(131, 57);
            buttonDone_LED.TabIndex = 7;
            buttonDone_LED.Text = "Выполнить ";
            buttonDone_LED.UseVisualStyleBackColor = false;
            buttonDone_LED.Click += buttonDone_LED_Click;
            buttonDone_LED.MouseDown += buttonDone_LED_MouseDown;
            buttonDone_LED.MouseEnter += buttonDone_LED_MouseEnter;
            buttonDone_LED.MouseLeave += buttonDone_LED_MouseLeave;
            // 
            // dataGridViewResult_LED
            // 
            dataGridViewResult_LED.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_LED.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewResult_LED.Location = new Point(15, 46);
            dataGridViewResult_LED.Name = "dataGridViewResult_LED";
            dataGridViewResult_LED.RowHeadersVisible = false;
            dataGridViewResult_LED.RowHeadersWidth = 51;
            dataGridViewResult_LED.Size = new Size(117, 294);
            dataGridViewResult_LED.TabIndex = 3;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "f(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // chartResult_LED
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_LED.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult_LED.Legends.Add(legend1);
            chartResult_LED.Location = new Point(138, 46);
            chartResult_LED.Name = "chartResult_LED";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_LED.Series.Add(series1);
            chartResult_LED.Size = new Size(401, 294);
            chartResult_LED.TabIndex = 8;
            chartResult_LED.Text = "График функции";
            // 
            // groupBoxResult_LED
            // 
            groupBoxResult_LED.Controls.Add(labelResult_LED);
            groupBoxResult_LED.Controls.Add(chartResult_LED);
            groupBoxResult_LED.Controls.Add(dataGridViewResult_LED);
            groupBoxResult_LED.Location = new Point(607, 3);
            groupBoxResult_LED.Name = "groupBoxResult_LED";
            groupBoxResult_LED.Size = new Size(539, 346);
            groupBoxResult_LED.TabIndex = 9;
            groupBoxResult_LED.TabStop = false;
            groupBoxResult_LED.Text = "Вывод данных";
            // 
            // labelResult_LED
            // 
            labelResult_LED.AutoSize = true;
            labelResult_LED.Location = new Point(15, 23);
            labelResult_LED.Name = "labelResult_LED";
            labelResult_LED.Size = new Size(75, 20);
            labelResult_LED.TabIndex = 0;
            labelResult_LED.Text = "Результат";
            // 
            // FormMain_LED
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 361);
            Controls.Add(groupBoxResult_LED);
            Controls.Add(buttonDone_LED);
            Controls.Add(buttonHelp_LED);
            Controls.Add(groupBoxVar_LED);
            Controls.Add(groupBoxTask_LED);
            Name = "FormMain_LED";
            Text = "Спринт 6 | Таск 2 | Вариант 14 | Лавринович Е.Д.";
            groupBoxTask_LED.ResumeLayout(false);
            groupBoxTask_LED.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_LED).EndInit();
            groupBoxVar_LED.ResumeLayout(false);
            groupBoxVar_LED.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_LED).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_LED).EndInit();
            groupBoxResult_LED.ResumeLayout(false);
            groupBoxResult_LED.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_LED;
        private Label labelTask_LED;
        private PictureBox pictureBoxTask_LED;
        private GroupBox groupBoxVar_LED;
        private TextBox textBoxStart_LED;
        private Label labelStart_LED;
        private Label labelStop_LED;
        private TextBox textBoxStop_LED;
        private Button buttonHelp_LED;
        private Button buttonDone_LED;
        private DataGridView dataGridViewResult_LED;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_LED;
        private GroupBox groupBoxResult_LED;
        private Label labelResult_LED;
    }
}
