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
    public partial class frmOpen : Form
    {
        Bitmap bmp;
        public frmOpen(string fileName)
        {
            InitializeComponent();
            bmp = new Bitmap(fileName);
        }

        private void frmOpen_Load(object sender, EventArgs e)
        {
            pbxImage.Image = bmp;
            pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
