using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            //this.button1.Paint += Form1_Paint;
        }
   
        private double[] angles = { 0, 0, 0, 0, 0, 0, 0, 0 };

        private void timer1_Tick(object sender, EventArgs e)
        {
            button2.Location = NewPoint(75, 70, 0.19, 0);
            button3.Location = NewPoint(120, 110, 0.103, 1);
            button4.Location = NewPoint(170, 150, 0.105, 2);
            button5.Location = NewPoint(200, 175, 0.01, 3);
            button6.Location = NewPoint(250, 200, 0.016, 4);
            button7.Location = NewPoint(320, 240, 0.0065, 5);
            button8.Location = NewPoint(420, 260, 0.0021, 6);
            button9.Location = NewPoint(510, 315, 0.0010, 7);
            button9.Location = NewPoint(510, 315, 0.0010, 7);

        }
        Point NewPoint(double radiusX, double radiusY, double _angle, int i)
        {
            double centerX = button1.Left + button1.Width / 2.0;
            double centerY = button1.Top + button1.Height / 2.0;

            double x = centerX + radiusX * Math.Sin(angles[i]);
            double y = centerY + radiusY * Math.Cos(angles[i]);

            Point MyPoint = new Point((int)x - button1.Width / 2, (int)y - button1.Height / 2);
            angles[i] += _angle;
            return MyPoint;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(button.ForeColor, 1);
            graphics.DrawEllipse(pen, 0, 0, button.Width - 1, button.Height - 1);
            Brush brush = new SolidBrush(button.ForeColor);
            graphics.FillEllipse(brush, 0, 0, button.Width - 1, button.Height - 1);
        }

        
    }
}