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
        public string radius { get; set; }

        public CircleForm(string radius)
        {
            InitializeComponent();
            this.radius = radius;
        }
    }
}
