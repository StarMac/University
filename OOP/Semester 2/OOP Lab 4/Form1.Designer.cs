
namespace LAB5
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Create_Button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CircleRadius_TextBox = new System.Windows.Forms.TextBox();
            this.SquareSideLenght_TextBox = new System.Windows.Forms.TextBox();
            this.RhombHorizontalDiagonalLenght_TextBox = new System.Windows.Forms.TextBox();
            this.RhombVerticalDiagonalLenght_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(16, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1013, 601);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Create_Button
            // 
            this.Create_Button.Location = new System.Drawing.Point(877, 15);
            this.Create_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(152, 46);
            this.Create_Button.TabIndex = 1;
            this.Create_Button.Text = "Create a figure";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 35);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CircleRadius_TextBox
            // 
            this.CircleRadius_TextBox.Location = new System.Drawing.Point(275, 35);
            this.CircleRadius_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CircleRadius_TextBox.Name = "CircleRadius_TextBox";
            this.CircleRadius_TextBox.Size = new System.Drawing.Size(132, 22);
            this.CircleRadius_TextBox.TabIndex = 3;
            this.CircleRadius_TextBox.Visible = false;
            this.CircleRadius_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            // 
            // SquareSideLenght_TextBox
            // 
            this.SquareSideLenght_TextBox.Location = new System.Drawing.Point(275, 35);
            this.SquareSideLenght_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SquareSideLenght_TextBox.Name = "SquareSideLenght_TextBox";
            this.SquareSideLenght_TextBox.Size = new System.Drawing.Size(132, 22);
            this.SquareSideLenght_TextBox.TabIndex = 4;
            this.SquareSideLenght_TextBox.Visible = false;
            this.SquareSideLenght_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            // 
            // RhombHorizontalDiagonalLenght_TextBox
            // 
            this.RhombHorizontalDiagonalLenght_TextBox.Location = new System.Drawing.Point(275, 35);
            this.RhombHorizontalDiagonalLenght_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RhombHorizontalDiagonalLenght_TextBox.Name = "RhombHorizontalDiagonalLenght_TextBox";
            this.RhombHorizontalDiagonalLenght_TextBox.Size = new System.Drawing.Size(132, 22);
            this.RhombHorizontalDiagonalLenght_TextBox.TabIndex = 5;
            this.RhombHorizontalDiagonalLenght_TextBox.Visible = false;
            this.RhombHorizontalDiagonalLenght_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            // 
            // RhombVerticalDiagonalLenght_TextBox
            // 
            this.RhombVerticalDiagonalLenght_TextBox.Location = new System.Drawing.Point(604, 35);
            this.RhombVerticalDiagonalLenght_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RhombVerticalDiagonalLenght_TextBox.Name = "RhombVerticalDiagonalLenght_TextBox";
            this.RhombVerticalDiagonalLenght_TextBox.Size = new System.Drawing.Size(132, 22);
            this.RhombVerticalDiagonalLenght_TextBox.TabIndex = 6;
            this.RhombVerticalDiagonalLenght_TextBox.Visible = false;
            this.RhombVerticalDiagonalLenght_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a figure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Circle radius";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Side length of the square";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "The length of the horizontal side of the rhombus ";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "The length of the vertical side of the rhombus ";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 681);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RhombVerticalDiagonalLenght_TextBox);
            this.Controls.Add(this.RhombHorizontalDiagonalLenght_TextBox);
            this.Controls.Add(this.SquareSideLenght_TextBox);
            this.Controls.Add(this.CircleRadius_TextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1061, 728);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "Form1";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox CircleRadius_TextBox;
        private System.Windows.Forms.TextBox SquareSideLenght_TextBox;
        private System.Windows.Forms.TextBox RhombHorizontalDiagonalLenght_TextBox;
        private System.Windows.Forms.TextBox RhombVerticalDiagonalLenght_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

