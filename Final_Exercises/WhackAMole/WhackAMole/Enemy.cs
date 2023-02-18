using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhackAMole
{
    internal class Enemy
    {
        private Random r = new Random();
        public Enemy() { }

        public int LocationX(int full_width, int enemy_width)
        {
            int newX;
            newX = r.Next(0, full_width - enemy_width- 15);
            return (newX);
        }
        public int LocationY(int full_height, int enemy_height)
        {
            int newY;
            newY = r.Next(0, full_height - enemy_height - 50);
            return (newY);
        }
    }
}
