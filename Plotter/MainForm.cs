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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void redirect_Click(object sender, EventArgs e)
        {

        }

        private void shapeMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var label in Controls.OfType<Label>()) label.Hide();
            foreach (var textBox in Controls.OfType<TextBox>()) textBox.Hide();

            switch (shapeMenu.SelectedItem)
            {
                case "Circle":
                    textboxRadius.Visible = true;
                    labelR.Visible = true;
                    break;
                case "Rectangle":
                    textboxEdge1.Visible = true;
                    labelEdge1.Visible = true;
                    textboxEdge2.Visible = true;
                    labelEdge2.Visible = true;
                    break;
                default:
                    break;
            }
        }
    }
}
