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

        public RectangleForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            RectangleShape circleShape = new RectangleShape(edge1, edge2);
            labelInfo.Text = circleShape.Print(circleShape.CalculateArea(), circleShape.CalculatePerimeter());

            pictureBox1.Visible = true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(0, 0, edge1, edge2);
            e.Graphics.FillRectangle(Brushes.Blue, rectangle);
        }
    }
}
