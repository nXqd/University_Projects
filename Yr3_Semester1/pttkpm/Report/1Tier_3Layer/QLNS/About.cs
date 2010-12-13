using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
