using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1OOPpart4
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Зібрав стільця під номером " + count.ToString();
            label.Font = new Font("Arial", 10, FontStyle.Bold);
            label.Location = new Point(10, 50 * count);
            label.Size = new Size(800, 20);
            this.Controls.Add(label);
            count++;
        }
    }
}
