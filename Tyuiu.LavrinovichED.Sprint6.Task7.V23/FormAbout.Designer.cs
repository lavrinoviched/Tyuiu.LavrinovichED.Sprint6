namespace Tyuiu.LavrinovichED.Sprint6.Task7.V23
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
            button_LED = new Button();
            SuspendLayout();
            // 
            // textBox_LED
            // 
            textBox_LED.Location = new Point(161, 37);
            textBox_LED.Multiline = true;
            textBox_LED.Name = "textBox_LED";
            textBox_LED.ReadOnly = true;
            textBox_LED.Size = new Size(448, 240);
            textBox_LED.TabIndex = 0;
            textBox_LED.Text = resources.GetString("textBox_LED.Text");
            // 
            // button_LED
            // 
            button_LED.Location = new Point(694, 409);
            button_LED.Name = "button_LED";
            button_LED.Size = new Size(94, 29);
            button_LED.TabIndex = 1;
            button_LED.Text = "OK";
            button_LED.UseVisualStyleBackColor = true;
            button_LED.Click += button_LED_Click;
            // 
            // FormAbout_LED
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_LED);
            Controls.Add(textBox_LED);
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "FormAbout_LED";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_LED;
        private Button button_LED;
    }
}