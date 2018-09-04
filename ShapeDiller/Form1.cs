using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeDiller
{
    public partial class Form1 : Form
    {
        int mouseX, mouseY;

        public Form1()
        {
            InitializeComponent();
        }

        private void pano_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            pano.Refresh();
        }
        /*
        private void pano_Paint(object sender, PaintEventArgs e)
        {
            //... your other stuff
            Rectangle rect = new Rectangle(mouseX - 100, mouseY - 100, 200, 200);
            e.Graphics.DrawRectangle(whitePen, rect);
        }
        */
    }
}
