using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practical8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btninc_Click(object sender, EventArgs e)
        {
            float currentsize = lblfont.Font.Size;
            lblfont.Font = new Font("Ravie", currentsize + 5);
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            float currentsize = lblfont.Font.Size;
            lblfont.Font = new Font("Ravie", currentsize - 5);
        }
    }
}
