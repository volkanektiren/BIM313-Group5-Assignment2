using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plotter
{
    public partial class RectangleForm : Form
    {
        public static int edge1 { get; set; }
        public static int edge2 { get; set; }

        RectangleShape rectangleShape;
        Rectangle rectangle;
        bool isMouseDown = false;
        Point locationXY;
        Point locationX1Y1;

        public RectangleForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            rectangleShape = new RectangleShape(edge1, edge2);
            locationXY = new Point(0, 0);
            locationX1Y1 = new Point(edge1, edge2);
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (rectangle != null && rectangleShape != null)
            {
                e.Graphics.DrawRectangle(Pens.Black, getRectangle());
                labelInfo.Text = rectangleShape.Print(rectangleShape.CalculateArea(), rectangleShape.CalculatePerimeter());
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            locationXY = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown) locationX1Y1 = e.Location;
            Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                locationX1Y1 = e.Location;
                isMouseDown = false;
                rectangleShape = new RectangleShape(Math.Abs(locationXY.X - locationX1Y1.X), Math.Abs(locationXY.Y - locationX1Y1.Y));
            }
        }

        private Rectangle getRectangle()
        {
            rectangle = new Rectangle();
            rectangle.X = Math.Min(locationXY.X, locationX1Y1.X);
            rectangle.Y = Math.Min(locationXY.Y, locationX1Y1.Y);
            rectangle.Width = Math.Abs(locationXY.X - locationX1Y1.X);
            rectangle.Height = Math.Abs(locationXY.Y - locationX1Y1.Y);

            return rectangle;
        }
    }
}
