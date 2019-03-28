using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace курсач
{
    class Triangle
    {
        Point p1, p2, p3;
        public Line l1, l2, l3;
        System.Drawing.Color color;
        public Triangle(Point q1, Point q2, Point q3)
        {
            p1 = q1;
            p2 = q2;
            p3 = q3;
            l1 = new Line(p1, p2);
            l2 = new Line(p3, p2);
            l3 = new Line(p1, p3);
        
        }

        private float fff(Line l, Point p)
        {
            return (l.a.x - p.x) * (l.b.y - l.a.y) - (l.b.x - l.a.x) * (l.a.y - p.y);
        }

        public bool DotIn(Point q)
        {
            //double a, b, c;
            //a = fff(l1, q);
            //b = fff(l2, q);
            //c = fff(l3, q);
            int a = (int)((p1.x - q.x) * (p2.y - p1.y) - (p2.x - p1.x) * (p1.y - q.y));
            int b = (int)((p2.x - q.x) * (p3.y - p2.y) - (p3.x - p2.x) * (p2.y - q.y));
            int c = (int)((p3.x - q.x) * (p1.y - p3.y) - (p1.x - p3.x) * (p3.y - q.y));
            return ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0));
        }
        public void draw(System.Windows.Forms.Control control, Point k)
        {
            l1.draw(control, k);
            l2.draw(control, k);
            l3.draw(control, k);
        }

        public Color PaintDot(System.Windows.Forms.Control control, int k, Point p)
        {
            double A = ((p2.x * p3.y) - (p2.y * p3.x)) - ((p1.x * p3.y) - (p3.x * p1.y)) + ((p1.x * p2.y) - (p1.y * p2.x));
            double m11 = p2.y - p3.y;
            double m12 = -(p2.x - p3.x);
            double m13 = (p2.x * p3.y) - (p2.y * p3.x);
            double m21 = -(p1.y - p3.y);
            double m22 = p1.x - p3.x;
            double m23 = -(p1.x * p3.y - p1.y * p3.x);
            double m31 = p1.y - p2.y;
            double m32 = -(p1.x - p2.x);
            double m33 = (p1.x * p2.y - p1.y * p2.x);
            List<double> A1 = new List<double>();
            List<double> A2 = new List<double>();
            List<double> A3 = new List<double>();
            A1.Add(m11 / A);
            A1.Add(m12 / A);
            A1.Add(m13 / A);
            A2.Add(m21 / A);
            A2.Add(m22 / A);
            A2.Add(m23 / A);
            A3.Add(m31 / A);
            A3.Add(m32 / A);
            A3.Add(m33 / A);
            double B1 = Spro(A1[0], A1[1], A1[2], p.x, p.y, 1);
            double B2 = Spro(A2[0], A2[1], A2[2], p.x, p.y, 1);
            double B3 = Spro(A3[0], A3[1], A3[2], p.x, p.y, 1);
            double r = Spro(p1.color.R, p2.color.R, p3.color.R, B1, B2, B3);
            double g = Spro(p1.color.G, p2.color.G, p3.color.G, B1, B2, B3);
            double b = Spro(p1.color.B, p2.color.B, p3.color.B, B1, B2, B3);
            Color mycolor = new Color();
            mycolor = Color.FromArgb((int)Math.Abs(r), (int)Math.Abs(g), (int)Math.Abs(b));
            return mycolor;
        }
        public double Spro(double a1,double a2, double a3, double b1,double b2, double b3)
        {
            return (a1 * b1 + a2 * b2 + a3 * b3);
        }
    }
}
