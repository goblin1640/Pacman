/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class Pacman
    {
        public int score = 0;
        public [] Body;
        private int x = 150, y = 150, width = 10, height = 10;

        public Pacman()
        {
            Body = new Pacman[1];
            Body[0] = new Pacman(x, y, width, height);

        }
        public void Draw()
        {
            for (int i = Body.Length - 1; i > 0; i--)
                Body[i] = Body[i - 1];

        }
        public void Draw(Graphics graphics)
        {
            graphics.FillRectangles(Brushes.Yellow, Body);

        }
        public void Move(int direction)
        {
            Draw();
            switch (direction)
            {
                case 0:
                    Body[0].X += 10;
                    break;
                case 1:
                    Body[0].Y += 10;
                    break;
                case 2:
                    Body[0].X -= 10;
                    break;
                case 3:
                    Body[0].Y -= 10;
                    break;

            }

        }
        
    }
}
*/