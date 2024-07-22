using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.First_Project
{
    internal class Point3D : Point2D ,IComparable , ICloneable
    {
        public int Z { get; set; }
        public Point3D(int _x, int _y,int _Z ) :base(_x,_y)
        {
            Z = _Z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(object? obj)
        {
            Point3D point3D = (Point3D)obj;

            if (this.X<point3D.X)
            {
                return -1;
            }
            else if(this.X > point3D.X)
            {
                return 1;
            }
            else
            {
                if (this.Y < point3D.Y)
                {
                    return -1;
                }
                else if (this.Y > point3D.Y)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public object Clone()
        {
            return new Point3D(this);
            
        }
        public Point3D(Point3D point3D ):base(0,0)
        {
            this.X = point3D.X;
            this.Y = point3D.Y;
            this.Z = point3D.Z;
        }
    }
}
