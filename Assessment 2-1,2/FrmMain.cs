//*****************************************************************************
// Programmer: Ye Liu
// Date: 22 October 2021
// Software: Microsoft Visual Studio 2019 Community Edition 
// Platform: Microsoft Windows 10 Professional 64­bit
// Purpose: Draw a 2D graphics
// Adapted from https://www.youtube.com/watch?v=PRpYDTegGyo&t=39s
//****************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 500;
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);

            // draw the house wall and brush it
            g.DrawRectangle(myPen, 100, 100, 150, 150);
            Rectangle rectangle1 = new Rectangle(100, 100, 150, 150);
            e.Graphics.FillRectangle(Brushes.White, rectangle1);

            // draw the windows and brush them
            g.DrawRectangle(myPen, 125, 115, 35, 35);
            g.DrawRectangle(myPen, 185, 115, 35, 35);
            e.Graphics.FillRectangle(Brushes.Blue, 125, 115, 35, 35);
            e.Graphics.FillRectangle(Brushes.Blue, 185, 115, 35, 35);

            // draw the door and brush it
            g.DrawRectangle(myPen, 160, 215, 35, 35);
            Rectangle rectangle3 = new Rectangle(160, 215, 35, 35);
            e.Graphics.FillRectangle(Brushes.Red, rectangle3);

            // draw the roof and brush it
            g.DrawLine(myPen, 100, 100, 170, 10);
            g.DrawLine(myPen, 170, 10, 250, 100);

           Point[] UP = new Point[] { new Point(100, 100), new Point(170, 10), new Point(250, 100) };
              SolidBrush brush = new SolidBrush(Color.FromArgb(253, 198, 19));
              e.Graphics.FillPolygon(brush, UP);
              brush.Dispose();



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmDragdrop myDragdrop = new frmDragdrop();
            myDragdrop.ShowDialog();
        }
    } }

