using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIForms
{
    public partial class FrmNew : Form
    {
        public FrmNew()
        {
            InitializeComponent();
        }
        Graphics gr;
        Pen pen1 = new Pen(Brushes.Green);
        Pen pen2 = new Pen(Color.Fuchsia);
        Pen pen3 = new Pen(Brushes.Peru, 3);
        Pen pen4 = new Pen(Color.Plum, 4);
        private void FrmNew_Load(object sender, EventArgs e)
        {
            gr = this.CreateGraphics();
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            gr.DrawLine(pen1,20,50,150,250);
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            //gr.DrawRectangle(pen2, 50, 100, 300, 200);
            Rectangle r1 = new Rectangle(50,100,300,200);
            gr.FillRectangle(Brushes.Yellow, r1);
        }

        private void btnArc_Click(object sender, EventArgs e)
        {
            gr.DrawArc(pen3, 50, 100, 300, 200, 50, 180);
        }

        private void btnPie_Click(object sender, EventArgs e)
        {
            //gr.DrawPie(pen4, 50, 100, 300, 200, 120, 90);
            Rectangle r1 = new Rectangle(50, 100, 300, 200);
            gr.FillPie(Brushes.Aqua, r1, -30, 100);
        }

        private void btnEllips_Click(object sender, EventArgs e)
        {
            Rectangle r1 = new Rectangle(50, 100, 300, 200);
            gr.DrawEllipse(pen2, r1);
        }

        private void btnCurve_Click(object sender, EventArgs e)
        {
            Random rnd= new Random();
            Point[] points = new Point[50];
            Pen[] pens = new Pen[] { pen1, pen2, pen3, pen4};

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(rnd.Next(this.Width),rnd.Next(this.Height));
            }

            gr.DrawCurve(pens[rnd.Next(pens.Length)], points);
        }

       
    }
}
