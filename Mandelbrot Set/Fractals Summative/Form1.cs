using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Fractals_Summative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap mandelBrotBitmap = new Bitmap(800, 600);
        int maxNum = 2;

        private void mandelBrotPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(mandelBrotBitmap, 0, 0);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Graphics mandelBrotGraphics = Graphics.FromImage(mandelBrotBitmap);
            Complex z = new Complex(0, 0);
            Complex c = new Complex(0, 0);
            int height = mandelBrotBitmap.Height;
            int width = mandelBrotBitmap.Width;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    z = 0;
                    int i = 0;
                    c = new Complex((4.0d / width) * x - 2.5d, (-3.0d / height) * y + 1.5d);

                    do
                    {
                        z = Complex.Add(Complex.Pow(z, 2), c);
                        i++;
                    } while (i <= 100 && Complex.Abs(z) < maxNum);

                    if (i - 1 == 100)
                        mandelBrotBitmap.SetPixel(x, y, Color.Black);
                    else if (i - 1 != 100)
                        mandelBrotBitmap.SetPixel(x, y, Color.Blue);
                }
            }
            mandelBrotPictureBox.Refresh();
        }
    }
}
