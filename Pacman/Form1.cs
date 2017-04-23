using Pacman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        Graphics g,k, l, w;
        Image PacPic = Image.FromFile("unnamed.png");
        Image pac = Image.FromFile("pac.png");
        Image sala = Image.FromFile("block.jpg");
        int x1 = 50, y1 = 50, x2 = 400, y2 = 50;
        int x3 = 0, y3 = 0;
        int fWidth, fHeight;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            k = this.CreateGraphics();
            l = this.CreateGraphics();
            w = this.CreateGraphics();
            fWidth = this.Width;
            fHeight = this.Height;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                y1 += 50;

                     if (y1 >= 600)
                     {
                         y1 = 600 - 50;

                 }
               else  if ( x1 >=100 && x1<= 450 )
                 {
                     if (y1 == 450)
                     {
                         y1 = 400;

                     }

                 }
               else if (x1 >=200 && x1<=250)
                 {
                     if (y1 == 150)
                     {
                         y1 = 100;
                     }

                 }

             } 
                
            
            else if (e.KeyCode == Keys.Up)
            {
                y1 -= 50;
                if (y1 <= 50)
                {
                    y1 = 50;
                }
                else if (x1 >= 100 && x1 <= 450)
                {
                    if (y1 == 450)
                    {
                        y1 = 500;
                    }
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                x1 -= 50;
                if (x1 <= 0)
                {
                    x1 = 50;
                }
                else if (y1 >= 100 && y1 <= 450)
                {
                    if (x1 == 150)
                    {
                        x1 = 200;
                    }
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                x1 += 50;


                if (x1 >= 850)
                {
                    x1 = 800;
                }
                else if (y1 >= 100 && y1 <= 450)
                {
                    if (x1 == 150)
                    {
                        x1 = 100;
                    }
                }
                else if (y1 >= 100 && y1 <= 350)
                {
                    if (x1 == 550)
                    {
                        x1 = 500;
                    }
                }

            }
            if (e.KeyCode == Keys.S)
            {
                y2 += 50;
                if (y2 >= 600)
                {
                    y2 = 600 - 50;
                }
            }
            else if (e.KeyCode == Keys.W)
            {
                y2 -= 50;
                if (y2 <= 50)
                {
                    y2 = 50;
                }
            }
            else if (e.KeyCode == Keys.A)
            {
                x2 -= 50;
                if (x2 <= 0)
                {
                    x2 = 50;
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                x2 += 50;
                if (x2 >= 850)
                {
                    x2 = 800;
                }
            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawImage(PacPic, x1, y1);
            k.DrawImage(pac, x2, y2,50 ,50);
            while(x3<=fWidth-100)
            {
                l.DrawImage(sala, x3, y3, 50, 50);
                x3 += 50;
            }
            while(y3<=fHeight-100)
            {
                l.DrawImage(sala, x3, y3, 50, 50);
                y3 += 50;
            }
            while(x3 >0)
            {
                l.DrawImage(sala, x3, y3, 50, 50);
                x3 -= 50;
            }
            while(y3 >= 50)
            {
                l.DrawImage(sala, x3, y3, 50, 50);
                y3 -= 50;
            }
            int y4 = 100;
            int x4 = 150;
            while (y4 <= 400)
            {
                l.DrawImage(sala, x4, y4, 50, 50);
                y4 += 50;
                

            }
            int y5 = 450;
            int x5 = 100;
            while (x5 <= 450)
            {
                l.DrawImage(sala, x5, y5, 50, 50);
                x5 += 50;
            }
            int y6 = 100;
            int x6 =500;
            while (y6 <= 250)
            {
                l.DrawImage(sala, x6, y6, 50, 50);
                y6 += 50;


            }
            int y7 = 300;
            int x7 = 500;
            while (x7 <= 700)
            {
                l.DrawImage(sala, x7, y7, 50, 50);
                x7 += 50;


            }

        }
    }
}
