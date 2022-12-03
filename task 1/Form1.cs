using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {
        enum Poisition { left, right, up, down };
        Poisition obgpoisition;

        private int x;
        private int y;
        public Form1()
        {
            InitializeComponent();
            this.Width = 50;
            this.Height = 50;
            x = 20;
            y = 20;
            obgpoisition = Poisition.right;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
           //en mypen = new Pen(Color.Black);
            Brush mybrush = new SolidBrush(Color.MediumPurple);

            // g.DrawLine(mypen, 10, 10, 300, 300);
            // g.DrawRectangle(mypen, 20,20 , 300,300);
            g.FillRectangle(mybrush, x, y, 100, 100);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (obgpoisition == Poisition.right) 
            { x += 10; }

         else  if (obgpoisition == Poisition.left)
            { x -= 10; }


          else if (obgpoisition == Poisition.up)
            { y -= 10; }

          else if(obgpoisition == Poisition.down)
            { y += 10; }
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 600;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            { obgpoisition = Poisition.right; }

          else if (e.KeyCode == Keys.Left)
            { obgpoisition = Poisition.left; }

         else  if (e.KeyCode == Keys.Up)
            { obgpoisition = Poisition.up; }

         else  if (e.KeyCode == Keys.Down)
            { obgpoisition = Poisition.down; }







        }

    }
}
