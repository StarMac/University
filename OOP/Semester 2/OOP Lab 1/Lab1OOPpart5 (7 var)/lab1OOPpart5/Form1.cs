﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace lab1OOPpart5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                label1.Visible = !label1.Visible;
                label2.Visible = !label2.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = !label2.Visible;
            label3.Visible = !label3.Visible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = !label1.Visible;
            label4.Visible = !label4.Visible;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Visible = !label2.Visible;
            label4.Visible = !label4.Visible;
        }
    }
}
