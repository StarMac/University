using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4ComputerGraphics
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float a1 = Convert.ToInt32(textBox1.Text);
                float a2 = Convert.ToInt32(textBox2.Text);
                float a3 = Convert.ToInt32(textBox3.Text);
                float a4 = Convert.ToInt32(textBox4.Text);

                float b1 = Convert.ToInt32(textBox5.Text);
                float b2 = Convert.ToInt32(textBox6.Text);
                float b3 = Convert.ToInt32(textBox7.Text);
                float b4 = Convert.ToInt32(textBox8.Text);

                float c1 = Convert.ToInt32(textBox9.Text);
                float c2 = Convert.ToInt32(textBox10.Text);
                float c3 = Convert.ToInt32(textBox11.Text);
                float c4 = Convert.ToInt32(textBox12.Text);

                float d1 = Convert.ToInt32(textBox13.Text);
                float d2 = Convert.ToInt32(textBox14.Text);
                float d3 = Convert.ToInt32(textBox15.Text);
                float d4 = Convert.ToInt32(textBox16.Text);

                float x = Convert.ToInt32(textBox17.Text);
                float y = Convert.ToInt32(textBox18.Text);
                float z = Convert.ToInt32(textBox19.Text);
                float n = Convert.ToInt32(textBox20.Text);


                textBox21.Text = Convert.ToString(a1 * x + a2 * y + a3 * z + a4 * n);
                textBox22.Text = Convert.ToString(b1 * x + b2 * y + b3 * z + b4 * n);
                textBox23.Text = Convert.ToString(c1 * x + c2 * y + c3 * z + c4 * n);
                textBox24.Text = Convert.ToString(d1 * x + d2 * y + d3 * z + d4 * n);
            }
            catch
            {
                MessageBox.Show("Fill in all fields!");
            }
        }
    }
}
