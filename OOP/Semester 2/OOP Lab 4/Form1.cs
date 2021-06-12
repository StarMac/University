using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5
{
    public partial class Form1 : Form
    {
        public enum FigureType
        {
            Circle,
            Square,
            Rhomb
        }

        FigureType figure { get; set; }

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add(FigureType.Circle);
            comboBox1.Items.Add(FigureType.Square);
            comboBox1.Items.Add(FigureType.Rhomb);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;

            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;

            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            figure = (FigureType)comboBox1.SelectedItem;
            Figure selectedFigure;

            switch (figure)
            {
                case FigureType.Circle:
                    selectedFigure = new Circle();
                    FigureCircle(selectedFigure);
                    break;

                case FigureType.Square:
                    selectedFigure = new Square();
                    FigureSquare(selectedFigure);
                    break;

                case FigureType.Rhomb:
                    selectedFigure = new Rhomb();
                    FigureRhomb(selectedFigure);
                    break;
            }

        }

        private void FigureCircle(Figure selectedFigure)
        {
            try
            {
                double radius = Convert.ToDouble(CircleRadius_TextBox.Text);

                selectedFigure = new Circle(20, 200, radius);

                Task task = new Task(() =>
                {
                    while (true)
                    {
                        if (selectedFigure.x >= 800)
                        {

                            break;
                        }

                        selectedFigure.MoveRight(pictureBox1);
                        Thread.Sleep(100);
                        Invoke(new MethodInvoker(delegate { pictureBox1.Refresh(); }));
                    }
                });
                task.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("You didn't enter values");
            }
            catch (ObjectDisposedException) { }
            
        }

        private void FigureSquare(Figure selectedFigure)
        {
            try
            {
                double sideLength = Convert.ToDouble(SquareSideLenght_TextBox.Text);

                selectedFigure = new Square(20, 200, (int)sideLength);

                Task task2 = new Task(() =>
                {
                    while (true)
                    {
                        if (selectedFigure.x >= 800)
                        {
                            break;
                        }

                        selectedFigure.MoveRight(pictureBox1);
                        Thread.Sleep(100);
                        Invoke(new MethodInvoker(delegate { pictureBox1.Refresh(); }));
                    }
                });
                task2.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("You didn't enter values");
            }
            catch (ObjectDisposedException) { }
        }

        private void FigureRhomb(Figure selectedFigure)
        {
            try
            {
                double horizontal = Convert.ToDouble(RhombHorizontalDiagonalLenght_TextBox.Text);
                double vertical = Convert.ToDouble(RhombVerticalDiagonalLenght_TextBox.Text);

                selectedFigure = new Rhomb(20, 200, horizontal, vertical);

                Task task3 = new Task(() =>
                {
                    while (true)
                    {
                        if (selectedFigure.x >= 800)
                        {
                            break;
                        }

                        selectedFigure.MoveRight(pictureBox1);
                        Thread.Sleep(100);
                        Invoke(new MethodInvoker(delegate { pictureBox1.Refresh(); }));
                    }
                });
                task3.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("You didn't enter values");
            }
            catch (ObjectDisposedException) { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CircleRadius_TextBox.Visible = true;
                label2.Visible = true;

                SquareSideLenght_TextBox.Visible = false;
                label3.Visible = false;
                RhombHorizontalDiagonalLenght_TextBox.Visible = false;
                RhombVerticalDiagonalLenght_TextBox.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                SquareSideLenght_TextBox.Visible = true;
                label3.Visible = true;

                CircleRadius_TextBox.Visible = false;
                label2.Visible = false;
                RhombHorizontalDiagonalLenght_TextBox.Visible = false;
                RhombVerticalDiagonalLenght_TextBox.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                RhombHorizontalDiagonalLenght_TextBox.Visible = true;
                RhombVerticalDiagonalLenght_TextBox.Visible = true;
                label4.Visible = true;
                label5.Visible = true;

                CircleRadius_TextBox.Visible = false;
                label2.Visible = false;
                SquareSideLenght_TextBox.Visible = false;
                label3.Visible = false;
            }
        }
        private void TextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8)) { e.Handled = true; }
        }
    }
}
