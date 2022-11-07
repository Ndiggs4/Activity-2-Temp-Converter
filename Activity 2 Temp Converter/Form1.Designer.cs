namespace Activity_2_Temp_Converter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fahrenheight = new System.Windows.Forms.TextBox();
            this.textBox_celsius = new System.Windows.Forms.TextBox();
            this.button_celsius = new System.Windows.Forms.Button();
            this.button_fahrenheight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrenheight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celsius";
            // 
            // textBox_fahrenheight
            // 
            this.textBox_fahrenheight.Location = new System.Drawing.Point(181, 50);
            this.textBox_fahrenheight.Name = "textBox_fahrenheight";
            this.textBox_fahrenheight.Size = new System.Drawing.Size(125, 25);
            this.textBox_fahrenheight.TabIndex = 3;
            this.textBox_fahrenheight.TextChanged += new System.EventHandler(this.textBoxferhenheight_TextChanged);
            // 
            // textBox_celsius
            // 
            this.textBox_celsius.Location = new System.Drawing.Point(828, 50);
            this.textBox_celsius.Name = "textBox_celsius";
            this.textBox_celsius.Size = new System.Drawing.Size(125, 25);
            this.textBox_celsius.TabIndex = 4;
            // 
            // button_celsius
            // 
            this.button_celsius.Location = new System.Drawing.Point(844, 115);
            this.button_celsius.Name = "button_celsius";
            this.button_celsius.Size = new System.Drawing.Size(94, 29);
            this.button_celsius.TabIndex = 7;
            this.button_celsius.Text = "Convert";
            this.button_celsius.UseVisualStyleBackColor = true;
            this.button_celsius.Click += new System.EventHandler(this.button_celsius_Click);
            // 
            // button_fahrenheight
            // 
            this.button_fahrenheight.Location = new System.Drawing.Point(108, 127);
            this.button_fahrenheight.Name = "button_fahrenheight";
            this.button_fahrenheight.Size = new System.Drawing.Size(94, 29);
            this.button_fahrenheight.TabIndex = 8;
            this.button_fahrenheight.Text = "Convert";
            this.button_fahrenheight.UseVisualStyleBackColor = true;
            this.button_fahrenheight.Click += new System.EventHandler(this.button_fahrenheight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1000, 405);
            this.Controls.Add(this.button_fahrenheight);
            this.Controls.Add(this.button_celsius);
            this.Controls.Add(this.textBox_celsius);
            this.Controls.Add(this.textBox_fahrenheight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Temp Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_fahrenheight;
        private TextBox textBox_celsius;
        private Button button_celsius;
        private Button button_fahrenheight;
    }
}