using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ktpm_draw
{
    public partial class Form1 : Form {
        public IShape shape { get; set; }
        public Form1(IShape shape)
        {
            InitializeComponent();
            Global.graphic = CreateGraphics();
            this.shape = shape;
        }

        private void Draw_Click(object sender, EventArgs e) {
            if (shape.valid())
                shape.draw();
            else {
                MessageBox.Show(@"Data is invalid");
            }
        }
    }
}
