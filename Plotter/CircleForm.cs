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
        public CircleForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CircleShape circleShape = new CircleShape(radius);
            labelInfo.Text = circleShape.Print(circleShape.CalculateArea(), circleShape.CalculatePerimeter());

            pictureBox1.Visible = true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle circle = new Rectangle(0, 0, radius*2, radius*2);
            e.Graphics.FillEllipse(Brushes.Black, circle);
        }
    }
}
