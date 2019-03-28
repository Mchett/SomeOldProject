using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace курсач
{
    class Point
    {
        public float x, y;
        public Color color = new Color();

        public Point(Point p)
        {
            color = Color.FromArgb(255, p.color);
            x = p.x;
            y = p.y;
        }

        public Point(float a, float b, Color c)
        {
            color = c;
            x = a;
            y = b;
        }
        public Point(float a, float b)
        {
            color = Color.Black;
            x = a;
            y = b;
        }
        public double Distance(Point q)
        {
            return Math.Sqrt((q.x - x) * (q.x - x) + (q.y - y) * (q.y - y));
        }
        public double DistanceOnX(Point q)
        {
            return x - q.x;
        }
        public double DistanceOnY(Point q)
        {
            return y - q.y;
        }
        public static bool operator ==(Point a, Point b)
        {
            return ((a.x == b.x) && (a.y == b.y));

        }
        public static Point operator -(Point a, Point b)
        {
            return new Point(a.x - b.x, a.y - b.y);

        }
        public static double operator *(Point p, Point q)
        {
            return (p.x * q.x + p.y * q.y);
        }
        public static Point operator +(Point a, Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }
        public static Point operator *(float k, Point b)
        {
            return new Point(k*b.x, k*b.y);
        }

        public static bool operator !=(Point a, Point b)
        {
            return !(a == b);
        }
        public override int GetHashCode()
        {
            return x.GetHashCode() + y.GetHashCode();
        }
        public override bool Equals(object otherPoint)
        {
            if (!(otherPoint is Point))
                return false;
            return this == (Point)otherPoint;
        }
    }
}
