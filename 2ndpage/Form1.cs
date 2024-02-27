using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2ndpage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            public static Image CropCircle2(Image imgSource)
            {
                Image imgTarget = new Bitmap(imgSource.Width, imgSource.Height);
                Graphics g = Graphics.FromImage(imgTarget);
                var path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddEllipse(0, 0, imgTarget.Width, imgTarget.Height);
                g.SetClip(path);
                g.DrawImage(imgSource, 0, 0);

                return imgTarget;
            }
        }
    }
}
