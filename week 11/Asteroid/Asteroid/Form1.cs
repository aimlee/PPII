using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


            SolidBrush br = new SolidBrush(Color.Blue);
            Rectangle r = new Rectangle(0, 0, Width-20, Height-40);
            e.Graphics.FillRectangle(br, r);


            Pen p = new Pen(Color.Black, 15);
            e.Graphics.DrawRectangle(p, r);

            //stars
            Rectangle s1 = new Rectangle(40, 50, 30, 30);
            SolidBrush star = new SolidBrush(Color.White);
            e.Graphics.FillEllipse(star, s1);

            Rectangle s2 = new Rectangle(80, 300, 30, 30);            
            e.Graphics.FillEllipse(star, s2);

            Rectangle s3 = new Rectangle(300, 40, 30, 30);            
            e.Graphics.FillEllipse(star, s3);

            Rectangle s4 = new Rectangle(300, 280, 30, 30);
            e.Graphics.FillEllipse(star, s4);

            Rectangle s5 = new Rectangle(450, 60, 30, 30);
            e.Graphics.FillEllipse(star, s5);

            Rectangle s6 = new Rectangle(620, 100, 30, 30);
            e.Graphics.FillEllipse(star, s6);

            Rectangle s7 = new Rectangle(550, 130, 30, 30);
            e.Graphics.FillEllipse(star, s7);

            Rectangle s8 = new Rectangle(620, 300, 30, 30);
            e.Graphics.FillEllipse(star, s8);


            //asteroid
            Point[] a1 =
            {
                new Point(150,150),
                new Point(155,155),
                new Point(160,155),
                new Point(155,160),
                new Point(160,165),
                new Point(155,165),
                new Point(150,170),
                new Point(145,165),
                new Point(140,165),
                new Point(145,160),
                new Point(140,155),
                new Point(145,155)
            };
            SolidBrush Astbrush = new SolidBrush(Color.Red);
            e.Graphics.FillPolygon(Astbrush, a1);

            Point[] a2 =
            {
                new Point(250,230),
                new Point(255,235),
                new Point(260,235),
                new Point(255,240),
                new Point(260,245),
                new Point(255,245),
                new Point(250,250),
                new Point(245,245),
                new Point(240,245),
                new Point(245,240),
                new Point(240,235),
                new Point(245,235)
            };
            
            e.Graphics.FillPolygon(Astbrush, a2);

            Point[] a3 =
            {
                new Point(470,260),
                new Point(475,265),
                new Point(480,265),
                new Point(475,270),
                new Point(480,275),
                new Point(475,275),
                new Point(470,280),
                new Point(465,275),
                new Point(460,275),
                new Point(465,270),
                new Point(460,265),
                new Point(465,265)
            };

            e.Graphics.FillPolygon(Astbrush, a3);

            Point[] a4 =
           {
                new Point(550,80),
                new Point(555,85),
                new Point(560,85),
                new Point(555,90),
                new Point(560,95),
                new Point(555,95),
                new Point(550,100),
                new Point(545,95),
                new Point(540,95),
                new Point(545,90),
                new Point(540,85),
                new Point(545,85)
            };

            e.Graphics.FillPolygon(Astbrush, a4);

            //Spaceship

            Point[] s =
            {
                new Point(360,150),
                new Point(410,180),
                new Point(410,210),
                new Point(360,240),
                new Point(310,210),
                new Point(310,180),
            };
            SolidBrush sbrush = new SolidBrush(Color.Yellow);
            e.Graphics.FillPolygon(sbrush, s);

            //Gun

            Point[] g =
            {
                new Point(360,170),
                new Point(390,195),
                new Point(370,195),
                new Point(370,220),
                new Point(350,220),
                new Point(350,195),
                new Point(330,195),
            };
            SolidBrush gbrush = new SolidBrush(Color.Green);
            e.Graphics.FillPolygon(gbrush, g);

            Point[] b =
           {
                new Point(370,120),
                new Point(372,128),
                new Point(385,130),
                new Point(372,132),
                new Point(370,140),
                new Point(368,132),
                new Point(355,130),
                new Point(368,128),
            };
            SolidBrush bbrush = new SolidBrush(Color.Green);
            e.Graphics.FillPolygon(bbrush, b);
            Pen bpen = new Pen(Color.Black, 1);
            e.Graphics.DrawPolygon(bpen, b);


        }

        
    }
}
