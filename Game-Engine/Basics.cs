using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
//3D Point Structure
{
    public struct Point3d
    {
        public int X;
        public int Y;
        public int Z;
        public Point3d(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3d(string x, string y, string z)
        {
            X = Convert.ToInt32(x);
            Y = Convert.ToInt32(y);
            Z = Convert.ToInt32(z);
        }
    }

//Point using decimals
    public struct DecimalPoint
    {
        decimal X;
        public decimal Y;
        public DecimalPoint(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }
    }

    public struct Size3d
    {
        public int width;
        public int height;
        public int depth;
    }

}
