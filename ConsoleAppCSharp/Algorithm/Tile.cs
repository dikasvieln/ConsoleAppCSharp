using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCSharp.Algorithm
{
    class Tile
    {
        public int Y { get; set; }
        public int X { get; set; }
        public int Cost { get; set; }
        public int Distance { get; set; }
        public int CostDistance => Cost + Distance;
        public Tile Parent { get; set; }

        public void SetDistance(int targetX, int targetY)
        {
            Distance = Math.Abs(targetX - X) + Math.Abs(targetY - Y);
        }

    }
}
