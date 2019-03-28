using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсач
{
    public partial class Form1 : Form
    {
        static Bitmap InputBitmap;
        MYCLASS myClass;
        Point koef;
        int width = 0;
        int height = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            if (OpenImageDialog.ShowDialog() == DialogResult.OK)
            {               
                PathTextBox.Text = OpenImageDialog.FileName;
                InputBitmap = new Bitmap(PathTextBox.Text);
                OriginalImageBox.Image = InputBitmap;
                width = InputBitmap.Size.Width;
                height = InputBitmap.Size.Height;
                PB2.Value = 0;


            }
            ResizeButton.Enabled = true;
            restoreb.Enabled = false;
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            restoreb.Enabled = true;
            myClass = new MYCLASS();
            Bitmap NewBitmap = new Bitmap(width, height);
            int count = 10000; // Нужно задать количество точек, сколько останется на фото для последующего восстановления
            Color color = new Color();
            color = Color.FromArgb(255, 255, 255);
            Random rand = new Random();
            for (int k = 0; k < count; k++)
            {
                int i = rand.Next(width);
                int j = rand.Next(height);
                NewBitmap.SetPixel(i, j, InputBitmap.GetPixel(i, j));
                if (!InputBitmap.GetPixel(i, j).Equals(color))
                    myClass.AddPoint(new Point(i, j, InputBitmap.GetPixel(i, j)));
            }

            OriginalImageBox.Image = NewBitmap;

            //int[] x = { 20, 20, 60, 60, 80, 50 };
            //int[] y = { 20, 60, 20, 60, 40, 40 };
            //int count = x.Count();
            //Random rand = new Random();
            //for (int k = 0; k < count; k++)
            //{
            //    NewBitmap.SetPixel(x[k], y[k], Color.FromArgb(0, 0, 0));
            //    myClass.AddPoint(new Point(x[k], y[k], Color.FromArgb(0, 0, 0)));
            //}
            //OriginalImageBox.Image = NewBitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    koef = new Point(OriginalImageBox.Size.Width / width, OriginalImageBox.Size.Height / height);
            restoreb.Enabled = false;

            koef = new Point(1, 1);
            Bitmap NewBitmap = new Bitmap(OriginalImageBox.Image);

            myClass.StartTriangulate(OriginalImageBox, koef);
  //          myClass.drawTriangles(OriginalImageBox, koef);

           // myClass.PaintTriangles(OriginalImageBox, koef, width, height);
            int q = width * height;
            PB2.Maximum = q;
            PB2.Step = 1;
            PB2.Value = 0;
            int i = 0, j = 0, z, fl = 0; ;
            for (i = 0; i < width; i++)
            {
               for (j = 0; j < height; j++)
               {
                   Bar();
                   fl = 0;
                   Point p = new Point(i, j);
                   for (z = 0; z < myClass.TList.Count(); z++)
                   {
                       if (myClass.TList[z].DotIn(p))
                       {
                          p.color = myClass.TList[z].PaintDot(OriginalImageBox, z,p);
                           fl = 1;
                           break;
                       }                 
                   }
                   if (fl == 0)
                       p.color = Color.FromArgb(0, 0, 0);
                   NewBitmap.SetPixel((int)p.x, (int)p.y, p.color);
                   OriginalImageBox.Image = NewBitmap;


               }

            }
            PB2.Value = 0;

        }
        public void Bar()
        {
            PB2.Value += 1;
        }
        private void SavePathButton_Click(object sender, EventArgs e)
        {
            if (SaveImageDialog.ShowDialog() == DialogResult.OK)
            {
                SavePathBox.Text = SaveImageDialog.FileName;
                OriginalImageBox.Image.Save(SavePathBox.Text);
            }
        }

     
    }
}
