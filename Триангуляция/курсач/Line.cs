using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсач
{
    class Line
    {
        public Point a, b;
        public Line(Point c, Point d)
        {
            a = c;
            b = d;
        }
        public bool Comparer(Line line)
        {
            if (line.a == a && line.b == b)
                return true;
            return false;
        }

        public double intersect(Line e)
        {
            Point c = e.a;
            Point d = e.b;
            Point n = new Point((d - c).y, (c - d).x);
            double denom = n * (b - a);
            if (denom != 0)
            {
                return -(n * (a - c)) / denom;
            }
            return 0;
        }

        public void rot()
        {
            Point m = (float)0.5 * (a + b);
            Point v = a - b;
            Point n = new Point(v.y, -v.x);
            a = m - (float)0.5 * n;
            b = m + (float)0.5 * n;
        }

        public float FromDot(Point p)
        {
            Point z1 = b - a;
            Point z2 = p - a;
            return z1.x * z2.y - z1.y * z2.x;
        }

        public void draw(System.Windows.Forms.Control control, Point k)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics = control.CreateGraphics();
            formGraphics.DrawLine(myPen, k.x*a.x, k.y*a.y, k.x*b.x, k.y*b.y);
            myPen.Dispose();
            formGraphics.Dispose();
        }

        public bool DotsOnOneSide(Point p1, Point p2)
        {
            return (FromDot(p1) * FromDot(p2) >= 0);
        }

        public bool CrossLine(Line l1)
        {
            return ((!DotsOnOneSide(l1.a, l1.b)) && (!l1.DotsOnOneSide(a, b)));
        }
        public bool LinesHasCommonDots(Line l1)
        {
            return ((a == l1.a) || (b == l1.b) || (a == l1.b) || (b == l1.a));
        }
        public double Dest(Point q)
        {
            return Math.Abs((q.x - a.x) * (b.y - a.y) - (q.y - a.y) * (b.x - a.x)) / Math.Sqrt((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y));
        }
        public bool DotOnLine(Point q)
        {
            return Dest(q) == 0;
        }        
        public override bool Equals(object otherLine)
        {
            if (!(otherLine is Line))
                return false;
            return (a == ((Line)otherLine).a && b == ((Line)otherLine).b) || (b == ((Line)otherLine).a && a == ((Line)otherLine).b);
        }
    }
}
