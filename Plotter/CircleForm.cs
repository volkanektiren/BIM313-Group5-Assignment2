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
    public partial class CircleForm : Form
    {
        public static int radius { get; set; }
        CircleShape circleShape;
        Rectangle circle;
        bool isMouseDown = false;
        Point locationXY;
        Point locationX1Y1;
        public CircleForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            circleShape = new CircleShape(radius);
            locationXY = new Point(0, 0);
            locationX1Y1 = new Point(radius*2, radius*2);
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (circle != null && circleShape != null)
            {
                e.Graphics.DrawEllipse(Pens.BlueViolet, getCircle());
                labelInfo.Text = circleShape.Print(circleShape.CalculateArea(), circleShape.CalculatePerimeter());
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown) locationX1Y1 = e.Location;
            Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            locationXY = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                locationX1Y1 = e.Location;
                isMouseDown = false;
                circleShape = new CircleShape(Math.Abs(locationXY.X - locationX1Y1.X)/2);
            }
        }

        private Rectangle getCircle()
        {
            circle = new Rectangle();
            circle.X = Math.Min(locationXY.X, locationX1Y1.X);
            circle.Y = Math.Min(locationXY.Y, locationX1Y1.Y);
            circle.Width = Math.Abs(locationXY.X - locationX1Y1.X);
            circle.Height = Math.Abs(locationXY.Y - locationX1Y1.Y);

            return circle;
        }
    }
}
