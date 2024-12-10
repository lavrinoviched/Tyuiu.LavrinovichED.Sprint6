namespace Tyuiu.LavrinovichED.Sprint6.Task6.V5
{
    partial class FormAbout_LED
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_LED));
            textBox_LED = new TextBox();
            buttonOk_LED = new Button();
            SuspendLayout();
            // 
            // textBox_LED
            // 
            textBox_LED.Location = new Point(12, 12);
            textBox_LED.Multiline = true;
            textBox_LED.Name = "textBox_LED";
            textBox_LED.ReadOnly = true;
            textBox_LED.Size = new Size(569, 218);
            textBox_LED.TabIndex = 0;
            textBox_LED.Text = resources.GetString("textBox_LED.Text");
            // 
            // buttonOk_LED
            // 
            buttonOk_LED.Location = new Point(487, 242);
            buttonOk_LED.Name = "buttonOk_LED";
            buttonOk_LED.Size = new Size(94, 29);
            buttonOk_LED.TabIndex = 1;
            buttonOk_LED.Text = "Ок";
            buttonOk_LED.UseVisualStyleBackColor = true;
            buttonOk_LED.Click += buttonOk_LED_Click;
            // 
            // FormAbout_LED
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 283);
            Controls.Add(buttonOk_LED);
            Controls.Add(textBox_LED);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(611, 330);
            MinimumSize = new Size(611, 330);
            Name = "FormAbout_LED";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_LED;
        private Button buttonOk_LED;
    }
}