using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lab4ComputerGraphics
{
    public partial class Form1 : Form
    {
        private Vector4[] figure;

        float size = 100f;
        Vector4 position = new Vector4(0, 0, 0, 0);

        float yaw = 0f;
        float x = 0f;
        float y0 = 0f;

        int tbPitch1 = 0;
        int tbRoll1 = 0;
        private TrackBar tbSize;

        private int k = 1;

        private float angleX, angleY, angleZ;
        private float speed = 2;

        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            tbSize = new TrackBar { Parent = this, Maximum = 270, Left = 0, Value = 100 };

            tbSize.ValueChanged += tb_ValueChanged;

            tb_ValueChanged(null, EventArgs.Empty);

            panel2.Controls.Add(tbSize);

        }

        public void tb_ValueChanged(object sender, EventArgs e)
        {
            size = tbSize.Value;


            if (k == 1)
            {
                figure = CreateCube(size, position, yaw, x, y0);
            }

            if (k == 2)
            {
                figure = CreateTriangularPyramid(size, position, yaw, x, y0);
            }

            Invalidate();
        }

        private Vector4[] CreateCube(float scale, Vector4 position, float yaw, float pitch, float roll)
        {
            //координати вершин куба
            figure = new Vector4[8];
            figure[0] = new Vector4(1, 1, 1, 1);
            figure[1] = new Vector4(-1, 1, 1, 1);
            figure[2] = new Vector4(-1, -1, 1, 1);
            figure[3] = new Vector4(1, -1, 1, 1);
            figure[4] = new Vector4(1, 1, -1, 1);
            figure[5] = new Vector4(-1, 1, -1, 1);
            figure[6] = new Vector4(-1, -1, -1, 1);
            figure[7] = new Vector4(1, -1, -1, 1);

            //матриця розтягнення (стискання)
            var scaleM = Matrix4x4.CreateScale(scale / 2);
            //матриця повороту
            var rotateM = Matrix4x4.CreateFromYawPitchRoll(yaw, pitch, roll);
            //матриця паралельного переносу
            var translateM = Matrix4x4.CreateTranslation(position);
            //результирующая матрица
            var m = translateM * rotateM * scaleM;

            //множемо вектори на матрицю
            for (int i = 0; i < figure.Length; i++)
            {
                figure[i] = m * figure[i];
            }

            return figure;
        }

        private Vector4[] CreateTriangularPyramid(float scale, Vector4 position, float yaw, float pitch, float roll)
        {
            //координати вершин трикутної піраміди
            figure = new Vector4[8];
            figure[0] = new Vector4(0, 0, 1, 1);
            figure[1] = new Vector4(0, 0, 1, 1);
            figure[2] = new Vector4(0, -1, -1, 1);
            figure[3] = new Vector4(1, 1, -1, 1);
            figure[4] = new Vector4(1, 1, -1, 1);
            figure[5] = new Vector4(-1, 1, -1, 1);
            figure[6] = new Vector4(0, -1, -1, 1);
            figure[7] = new Vector4(1, 1, -1, 1);

            //матриця розтягнення (стискання)
            var scaleM = Matrix4x4.CreateScale(scale / 2);
            //матриця повороту
            var rotateM = Matrix4x4.CreateFromYawPitchRoll(yaw, pitch, roll);
            //матриця паралельного переносу
            var translateM = Matrix4x4.CreateTranslation(position);
            //результирующая матрица
            var m = translateM * rotateM * scaleM;

            //множемо вектори на матрицю
            for (int i = 0; i < figure.Length; i++)
            {
                figure[i] = m * figure[i];
            }

            return figure;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //створюємо матрицю проекції на площину XY
            var paneXY = new Matrix4x4() { V00 = 1f, V11 = 1f, V33 = 1f };

            //малюємо
            DrawFigure(e.Graphics, new PointF(300, 250), paneXY);
        }



        public void DrawFigure(Graphics gr, PointF startPoint, Matrix4x4 projectionMatrix)
        {
            //проекція
            var p = new Vector4[figure.Length];
            for (int i = 0; i < figure.Length; i++)
            {
                p[i] = projectionMatrix * figure[i];
            }

            //створюємо шлях
            GraphicsPath path = new GraphicsPath();
            AddLine(path, p[0], p[1], p[2], p[3], p[0], p[4], p[5], p[6], p[7], p[4]);
            AddLine(path, p[5], p[1]);
            AddLine(path, p[2], p[6]);
            AddLine(path, p[6], p[7]);
            AddLine(path, p[7], p[3]);
            //здвигаємо
            gr.ResetTransform();
            gr.TranslateTransform(startPoint.X, startPoint.Y);
            //малюємо                      
            gr.DrawPath(Pens.Black, path);
            //gr.FillPath(Brushes.Black, path);
        }


        public void AddLine(GraphicsPath path, params Vector4[] points)
        {
            foreach (var p in points)
            {
                path.AddLines(new PointF[] { new PointF(p.X, p.Y) });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float x0 = 0;
                float y = 0;
                float z = 0;

                if (checkBox1.Checked == true)
                {
                    size = tbSize.Value;
                    x0 = (float)(x0 * Math.PI / 180);
                    y0 = (float)(y * Math.PI / 180);
                    float z0 = (float)(z * Math.PI / 180);
                    figure = CreateCube(size, position, x0, y0, z0);


                    Invalidate();

                    k = 1;
                }

                if (checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    MessageBox.Show("Select a figure!");
                }

            }
            catch
            {
                MessageBox.Show("Enter the coordinates!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float x0 = Convert.ToInt32(textBox1.Text);
                float y = Convert.ToInt32(textBox2.Text);
                float z = Convert.ToInt32(textBox3.Text);

                if (checkBox2.Checked == true)
                {
                    size = tbSize.Value;
                    x0 = (float)(x0 * Math.PI / 180);
                    y0 = (float)(y * Math.PI / 180);
                    float z0 = (float)(z * Math.PI / 180);
                    figure = CreateTriangularPyramid(size, position, x0, y0, z0);
                    Invalidate();

                    k = 2;
                }

                if (checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    MessageBox.Show("Select a figure!");
                }
            }
            catch
            {
                MessageBox.Show("Enter the coordinates!");
            }

            Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                k = 1;
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                k = 2;
                checkBox1.Checked = false;
            }
        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (checkBox3.Checked == true)
                {
                    angleX += speed;

                    float x0 = 0;

                    size = tbSize.Value;
                    x0 = (float)(x0 + angleX * Math.PI / 180);
                    float z0 = 0;
                    figure = CreateCube(size, position, x0, y0, z0);

                    Invalidate();
                }

                if (checkBox4.Checked == true)
                {
                    angleY += speed;

                    float x0 = 0;
                    float y = 0;

                    size = tbSize.Value;
                    y0 = (float)(y + angleY * Math.PI / 180);
                    float z0 = 0;
                    figure = CreateCube(size, position, x0, y0, z0);

                    Invalidate();
                }

                if (checkBox5.Checked == true)
                {
                    angleZ += speed;

                    float x0 = 0;
                    float z = 0;

                    float z0 = (float)(z + angleZ * Math.PI / 180);
                    figure = CreateCube(size, position, x0, y0, z0);

                    Invalidate();
                }

                if (checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true)
                {
                    angleX += speed;
                    angleY += speed;
                    angleZ += speed;

                    float x0 = 0;
                    float y = 0;
                    float z = 0;

                    size = tbSize.Value;
                    x0 = (float)(x0 + angleX * Math.PI / 180);
                    y0 = (float)(y + angleY * Math.PI / 180);
                    float z0 = (float)(z + angleZ * Math.PI / 180);
                    figure = CreateCube(size, position, x0, y0, z0);

                    Invalidate();
                }

                if (checkBox3.Checked == true && checkBox4.Checked == true)
                {
                    angleX += speed;
                    angleY += speed;

                    float x0 = 0;
                    float y = 0;

                    size = tbSize.Value;
                    x0 = (float)(x0 + angleX * Math.PI / 180);
                    y0 = (float)(y + angleY * Math.PI / 180);
                    float z0 = 0;
                    figure = CreateCube(size, position, x0, y0, z0);

                    Invalidate();
                }

                if (checkBox4.Checked == true && checkBox5.Checked == true)
                {
                    angleY += speed;
                    angleZ += speed;

                    float x0 = 0;
                    float y = 0;
                    float z = 0;

                    size = tbSize.Value;
                    y0 = (float)(y + angleY * Math.PI / 180);
                    float z0 = (float)(z + angleZ * Math.PI / 180);
                    figure = CreateCube(size, position, x0, y0, z0);

                    Invalidate();
                }


                if (checkBox3.Checked == true && checkBox5.Checked == true)
                {
                    angleX += speed;
                    angleZ += speed;

                    float x0 = 0;
                    float z = 0;

                    size = tbSize.Value;
                    x0 = (float)(x0 + angleX * Math.PI / 180);
                    float z0 = (float)(z + angleZ * Math.PI / 180);
                    figure = CreateCube(size, position, x0, y0, z0);

                    Invalidate();
                }

            }
            catch
            {
                timer1.Stop();
                MessageBox.Show("Fill in all fields!");
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            size = tbSize.Value;
            if (tbPitch1 < 180) tbPitch1 += 3;
            x = (float)(tbPitch1 * Math.PI / 180);

            if (k == 1)
            {
                figure = CreateCube(size, position, yaw, x, y0);
            }

            if (k == 2)
            {
                figure = CreateTriangularPyramid(size, position, yaw, x, y0);
            }

            Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tbPitch1 > -180) tbPitch1 -= 3;
            x = (float)(tbPitch1 * Math.PI / 180);


            if (k == 1)
            {
                figure = CreateCube(size, position, yaw, x, y0);
            }

            if (k == 2)
            {
                figure = CreateTriangularPyramid(size, position, yaw, x, y0);
            }

            Invalidate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            size = tbSize.Value;
            if (tbRoll1 < 180) tbRoll1 += 3;
            y0 = (float)(tbRoll1 * Math.PI / 180);


            if (k == 1)
            {
                figure = CreateCube(size, position, yaw, x, y0);
            }

            if (k == 2)
            {
                figure = CreateTriangularPyramid(size, position, yaw, x, y0);
            }

            Invalidate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            size = tbSize.Value;
            if (tbRoll1 > -180) tbRoll1 -= 3;
            y0 = (float)(tbRoll1 * Math.PI / 180);


            if (k == 1)
            {
                figure = CreateCube(size, position, yaw, x, y0);
            }

            if (k == 2)
            {
                figure = CreateTriangularPyramid(size, position, yaw, x, y0);
            }

            Invalidate();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}

