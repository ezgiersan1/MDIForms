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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNew frm= new FrmNew();
            frm.MdiParent = this;
            frm.Text = "Yeni form";
            frm.Width = 600;
            frm.Height = 500;
            frm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Bir Resim seçiniz:";
            ofd.Filter = "jpg Dosya Türü|*.jpg|png Dosya Türü|*.png|böp Dosya Türü|*.bmp";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                frmOpen frm = new frmOpen(ofd.FileName);
                frm.MdiParent = this;
                frm.Text= ofd.FileName;
                frm.Width = 600;
                frm.Height = 500;
                frm.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizantalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void arrangeİconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
