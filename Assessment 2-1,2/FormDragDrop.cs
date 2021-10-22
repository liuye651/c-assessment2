//*****************************************************************************
// Programmer: Ye Liu
// Date: 22 October 2021
// Software: Microsoft Visual Studio 2019 Community Edition 
// Platform: Microsoft Windows 10 Professional 64­bit
// Purpose: Drag and drop image to the picturebox
// Adapted from https://1bestcsharp.blogspot.com/2015/03/c-how-to-drag-and-drop-image-from.html
//****************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_2
{
    public partial class frmDragdrop : Form
    {
        public frmDragdrop()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDragdrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void frmDragdrop_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image img = Image.FromFile(pic);
                pictureBox1.Image = img;
               // var dragImage = new Bitmap((Bitmap)pictureBox1.Image, pictureBox1.Size);
            }
        }

       
    }
}
