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

        private void shapeMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var label in Controls.OfType<Label>()) label.Hide();
            foreach (var textBox in Controls.OfType<TextBox>()) textBox.Hide();

            switch (shapeMenu.SelectedItem)
            {
                case "Circle":
                    textboxRadius.Show();
                    labelR.Show();
                    break;
                case "Rectangle":
                    textboxEdge1.Show();
                    labelEdge1.Show();
                    textboxEdge2.Show();
                    labelEdge2.Show();
                    break;
                default:
                    break;
            }
        }

        private void redirect_Click(object sender, EventArgs e)
        {
            switch (shapeMenu.SelectedItem)
            {
                case "Circle":
                    CircleForm circleFormDialog = new CircleForm();
                    CircleForm.radius = Convert.ToInt32(textboxRadius.Text);
                    circleFormDialog.ShowDialog();
                    break;
                case "Rectangle":
                    RectangleForm rectangleFormDialog = new RectangleForm();
                    RectangleForm.edge1 = Convert.ToInt32(textboxEdge1.Text);
                    RectangleForm.edge2 = Convert.ToInt32(textboxEdge2.Text);
                    rectangleFormDialog.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void textbox_Length_KeyPress(object sender, KeyPressEventArgs e)
        {
            var senderTextBox = sender as TextBox;

            if ((char.IsNumber(e.KeyChar)) || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == '0' && senderTextBox.Text == "") e.Handled = true;
            }
            else e.Handled = true;
        }
    }
}
