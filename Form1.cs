using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        
        public Point Currentpoint = new Point();
        public Point oldpoint = new Point();

        public Graphics g;
        public Graphics graph;

        public Pen pen = new Pen(Color.Black, 5);

        Bitmap surface;

        public Form1()
        {
            InitializeComponent();
            g = plCanvas.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            
            surface = new Bitmap(plCanvas.Width, plCanvas.Height);
            graph = Graphics.FromImage(surface);
            plCanvas.BackgroundImage = surface;
            plCanvas.BackgroundImageLayout = ImageLayout.None;

            pen.Width = (float)paintbrushSize.Value;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void canvas_mousedown(object sender, MouseEventArgs e)
        {
            oldpoint = e.Location;
        }

        private void canvas_mousemove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Currentpoint = e.Location;
                g.DrawLine(pen, oldpoint, Currentpoint);
                graph.DrawLine(pen, oldpoint, Currentpoint);
                oldpoint = Currentpoint;
            }
        }
        private Point MouseOffSetPos;
        private Boolean isMouseDown = false;

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseOffSetPos = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point MousePos = Control.MousePosition;
                MousePos.Offset(MouseOffSetPos.X, MouseOffSetPos.Y);
                this.Location = MousePos;
            }
        }

        private void topPanel_mouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
        }
    }
}
