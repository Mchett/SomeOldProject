using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсач
{
    static class Program
    {
        
      /*  static void main()
        {
            Point a = new Point(0, 0);
            Point b = new Point(0, 1);
            Point c = new Point(0, 0);
            Point d = new Point(1, 1);
            Line l1 = new Line(a, d);

            System.Console.WriteLine(l1.DotsOnOneSide(c, b));
            System.Console.Read();
        }*/
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread] 
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //main();
        }
    }
}
