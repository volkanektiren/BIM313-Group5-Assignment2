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
        public string edge1 { get; set; }
        public string edge2 { get; set; }

        public RectangleForm(string edge1, string edge2)
        {
            InitializeComponent();
            this.edge1 = edge1;
            this.edge2 = edge2;
        }
    }
}
