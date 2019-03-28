using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace курсач
{
    class MYCLASS
    {
        List<Line> DeadLList = new List<Line>();
        List<Line> LiveLList = new List<Line>();
      public  List<Triangle> TList = new List<Triangle>();
        List<Point> PList = new List<Point>();

        void UpdateLLists(Line l)
        {
            if (LiveLList.Contains(l))
            {
                DeadLList.Add(l);
                LiveLList.Remove(l);
            }
            else
            {
                if (!DeadLList.Contains(l))
                    LiveLList.Add(l);
            }
        }

        void UpdateLLists(Triangle t)
        {
            UpdateLLists(t.l1);
            UpdateLLists(t.l2);
            UpdateLLists(t.l3);
        }

      /* static private void FindNewTriangle(Line l)
       {
           int index = FindPoint(l);
           if (index == -1)
           {
               DeadLList.Add(l);
               LiveLList.Remove(l);
               break;
           }
           else
           {
               Triangle tr = new Triangle(l.a, l.b, PList[index]);
               TList.Add(tr);
               UpdateLLists(tr);
               break;
           }

       }*/

        public int FindPoint(Line l)
        {
            int i = -1;
            double t, bestt = 1;
            bool flag = true;
            Line f = new Line(new Point(l.a), new Point(l.b));
            f.rot();
            foreach (var p in PList)
            {
                if (l.FromDot(p) > 0)
                {
                    Line g = new Line(l.b, p);
                    g.rot();
                    t = f.intersect(g);
                    if (flag || t < bestt)
                    {
                        flag = false;
                        i = PList.IndexOf(p);
                        bestt = t;
                    }
                }
            }
            return i;
        }

        public void AddPoint(Point p)
        {
            PList.Add(p);
        }
        public void StartTriangulate(System.Windows.Forms.Control control, Point k)
        {
                        Line l;
            List<Point> TempList = new List<Point>(PList);
            TempList.Sort((Point p1, Point p2) => p1.x.CompareTo(p2.x));
            Point d1 = TempList[1];
            Point d2 = TempList[0];
            if (d2.y<d1.y)
                l = new Line(d1, d2);
            else
                l = new Line(d2, d1);

            LiveLList.Add(l);
            while (LiveLList.Count() > 0)
            {
                l = LiveLList.First();
                int index = FindPoint(l);
                if (index == -1)
                {
                    DeadLList.Add(l);
                    LiveLList.Remove(l);
                }
                else
                {
                    Triangle tr = new Triangle(l.a, l.b, PList[index]);
                     TList.Add(tr);
                    tr.draw(control, k);
                    UpdateLLists(tr);
                }
            }
        }
        public void drawTriangles(System.Windows.Forms.Control control, Point k)
        {
            foreach (var tr in TList)
                tr.draw(control, k);
        }
        public void PaintTriangles(System.Windows.Forms.Control control, Point k, int width, int height)
        {
            int i = 0, j = 0, z, fl = 0; ;
            for (i = 0; i < width; i++)
            {
               for (j = 0; j < height; j++)
               {
                   fl = 0;
                   Point p = new Point(i, j);
                   for (z = 0; z < TList.Count(); z++)
                   {
                       if (TList[z].DotIn(p))
                       {
                          p.color = TList[z].PaintDot(control, z,p);
                           fl = 1;
                           break;
                       }                 
                   }
                   if (fl == 0)
                       p.color = Color.FromArgb(0, 0, 0);
               }

            }

        }
    }
}
