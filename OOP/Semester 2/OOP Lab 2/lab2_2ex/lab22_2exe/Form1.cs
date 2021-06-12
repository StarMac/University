using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab22_2exe
{
    public partial class Form1 : Form
    {
        private delegate void MyDelegate();

        private bool TransparencySwitched = true;
        private bool BackColorSwitched = true;
        private readonly Color DefaultColor = DefaultBackColor;

        private readonly MyDelegate HelloDelegate;
        private readonly MyDelegate TransparencySwitchedDelegate;
        private readonly MyDelegate BackColorSwitchedDelegate;
        private MyDelegate EmptyFormDelegate;
        public Form1()
        {
            InitializeComponent();

            HelloDelegate = () => { MessageBox.Show("hello World"); };
            TransparencySwitchedDelegate = () =>
            {
                Opacity = TransparencySwitched ? .5 : 1;
                TransparencySwitched = !TransparencySwitched;
            };
            BackColorSwitchedDelegate = () =>
            {
                BackColor = BackColorSwitched ? System.Drawing.Color.Yellow : DefaultColor;
                BackColorSwitched = !BackColorSwitched;
            };
        }
        private void CheckStateMethod()
        {
            if (checkBox1.Checked)
            {
                TransparencySwitchedDelegate();
            }
            if (checkBox2.Checked)
            {
                BackColorSwitchedDelegate();
            }
            if (checkBox3.Checked)
            {
                HelloDelegate();
            }
        }

        private void Transparency_Click(object sender, EventArgs e)
        {
            TransparencySwitchedDelegate();
        }

        private void Color_Click(object sender, EventArgs e)
        {
            BackColorSwitchedDelegate();
        }

        private void hello_World_Click(object sender, EventArgs e)
        {
            HelloDelegate();
        }

        private void Super_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
            EmptyFormDelegate = CheckStateMethod;
            EmptyFormDelegate();
        }
    }
}
