using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIWindowsApp
{
    public partial class Form1 : Form
    {
        public Point point1;
        public Point point2;
        public int shape;
        public Form1()
        {
            InitializeComponent();
        }
        private void OnFileOpen(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog(this);

        }

        private void OnFileSaveAs(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.ShowDialog(this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OnFormMouseDown(object sender, MouseEventArgs e)
        {
            this.point1 = new Point(e.X, e.Y);
            //  MessageBox.Show("Mouse Down");

        }
        private void OnFormMouseUp(object sender, MouseEventArgs e)
        {
            this.point2 = new Point(e.X, e.Y);
            // MessageBox.Show("Mouse up");
            Pen thepen = new Pen(Color.IndianRed);
            Graphics g = this.CreateGraphics();
            switch (shape)
            {
                case 1:
                    g.DrawLine(thepen, point1, point2);
                    break;

                case 2:
                    {
                        float width = point2.X - point1.X;
                        float height = point2.Y - point1.Y;
                        g.DrawRectangle(thepen, point1.X, point1.Y, width, height);

                    }
                    break;

            }
        }

        private void OnFormMouseMove(object sender, MouseEventArgs e)
        {

        }
        private void OnShapeLine(object sender, EventArgs e)
        {
            this.shape = 1;
        }
        private void OnShapeRectangle(object sender,EventArgs e) { this.shape = 2; }    
    }


}

