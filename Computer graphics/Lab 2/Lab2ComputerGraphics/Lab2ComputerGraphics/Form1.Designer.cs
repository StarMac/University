
namespace Lab2ComputerGraphics
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_Radius = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.textBox_Radius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Bresenhem = new System.Windows.Forms.TextBox();
            this.textBox_My = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(19, 101);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1013, 576);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(860, 23);
            this.Start.Margin = new System.Windows.Forms.Padding(4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(169, 50);
            this.Start.TabIndex = 1;
            this.Start.Text = "Draw";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(16, 19);
            this.label_X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(17, 17);
            this.label_X.TabIndex = 3;
            this.label_X.Text = "X";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(16, 54);
            this.label_Y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(17, 17);
            this.label_Y.TabIndex = 4;
            this.label_Y.Text = "Y";
            // 
            // label_Radius
            // 
            this.label_Radius.AutoSize = true;
            this.label_Radius.Location = new System.Drawing.Point(198, 18);
            this.label_Radius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Radius.Name = "label_Radius";
            this.label_Radius.Size = new System.Drawing.Size(52, 17);
            this.label_Radius.TabIndex = 5;
            this.label_Radius.Text = "Radius";
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(43, 15);
            this.textBox_X.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(132, 22);
            this.textBox_X.TabIndex = 6;
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(43, 51);
            this.textBox_Y.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(132, 22);
            this.textBox_Y.TabIndex = 7;
            // 
            // textBox_Radius
            // 
            this.textBox_Radius.Location = new System.Drawing.Point(260, 14);
            this.textBox_Radius.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Radius.Name = "textBox_Radius";
            this.textBox_Radius.Size = new System.Drawing.Size(132, 22);
            this.textBox_Radius.TabIndex = 8;
            this.textBox_Radius.TextChanged += new System.EventHandler(this.textBox_Radius_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(485, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "The Bresenham Algorithm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(485, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "My algorithm";
            // 
            // textBox_Bresenhem
            // 
            this.textBox_Bresenhem.Enabled = false;
            this.textBox_Bresenhem.Location = new System.Drawing.Point(665, 15);
            this.textBox_Bresenhem.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Bresenhem.Name = "textBox_Bresenhem";
            this.textBox_Bresenhem.Size = new System.Drawing.Size(68, 22);
            this.textBox_Bresenhem.TabIndex = 11;
            // 
            // textBox_My
            // 
            this.textBox_My.Enabled = false;
            this.textBox_My.Location = new System.Drawing.Point(665, 60);
            this.textBox_My.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_My.Name = "textBox_My";
            this.textBox_My.Size = new System.Drawing.Size(68, 22);
            this.textBox_My.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(742, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_My);
            this.Controls.Add(this.textBox_Bresenhem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Radius);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.label_Radius);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Raster graphics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_Radius;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.TextBox textBox_Radius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Bresenhem;
        private System.Windows.Forms.TextBox textBox_My;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

