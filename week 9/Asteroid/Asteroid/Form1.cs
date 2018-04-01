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
            
          
                timer1.Start();

        }
public static int Score = 0, time = 5, z = 200;
        bool game = true;
        public void gameover(Label l)
        {
            if (l.Location.X + l.Width > button1.Location.X && l.Location.X <= button1.Location.X + button1.Width && l.Location.Y + l.Height > button1.Location.Y && l.Location.Y <= button1.Location.Y + button1.Height)
            {
                game = false;

                label2.Location = new System.Drawing.Point(190, -50);
                shar.Location = new System.Drawing.Point(124, 21);
                label5.Location = new System.Drawing.Point(400, -90);
                z = 200;

            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
          Scr.Text = "Score: 0";
            Score = 0;
                label4.Visible = false;
                timer1.Start();
            button2.Visible = false;

                game = true;
            }

        private void button1_Click(object sender, KeyEventArgs e)
        {
            if (button1.Location.X > Width-100)
                    {
                button1.Location = new Point(Width-100, button1.Location.Y);
                    }
            if (button1.Location.X < 0)
            {
                button1.Location = new Point(0+15, button1.Location.Y);
            }
            if (game == true)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:

                        button1.Location = new Point(button1.Location.X - 20, button1.Location.Y);

                        break;
                    case Keys.D:
                        button1.Location = new Point(button1.Location.X + 20, button1.Location.Y);
                        break;
                }
                gameover(shar);
                gameover(label2);
                gameover(label5);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            Point g = label5.Location;
            Point p = shar.Location;
            Point r = label2.Location;

            p.Y = p.Y + 10;

            r.Y = r.Y + 10;

            g.Y = g.Y + 10;

                timer1.Interval= z;
            if(g.Y > Height - 10)
            {
                if (z > 10)
                {
                    z = z - 10;
                }
                else
                    z = 1;
                
            }
            if (g.Y > Height)
            {
                Score++;
                g.Y = 0;
                g.X = new Random().Next(0, Width - 32);
                Scr.Text = "Score" + ":" + " " + Score.ToString();

            }

            if (r.Y > Height)
            {
                
                r.Y = 0;
                r.X = new Random().Next(0, Width - 32);
                
            }

            if (p.Y+10 > Height)
            {
                
                p.Y = 0;
                p.X = new Random().Next(0, Width - 32);
                
            }
            shar.Location = p;
            label2.Location = r;
            label5.Location = g;
            gameover(shar);
            gameover(label2);
            gameover(label5);
            if (game == false)
            {
                timer1.Stop();
                label4.Visible = true;

                button2.Visible = true;
            }
        }

       

        
    }
}