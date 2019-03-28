using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Битва
{
    class FileObserver : IObserver
    {
        public FileObserver()
        {
            var file = new StreamWriter("Log_битва.txt", false);
            file.Close();
        }
        public void Update(string msg)
        {
            using (var file = new StreamWriter("Log_битва.txt", true))
            {
                file.WriteLine(msg);
            }
        }
    }
    class ObserverClone : IObserver
    {
        public void Update(string msg)
        {
            System.Media.SystemSounds.Beep.Play();
        }
    }
    class ObserverDeath : IObserver
    {

        System.Windows.Forms.DataGridView A;
        System.Windows.Forms.DataGridView B;
        public ObserverDeath(System.Windows.Forms.DataGridView A1, System.Windows.Forms.DataGridView B1)
        {
            A = A1; B = B1;
        }
        public void Update(string msg)
        {
            string[] words = msg.Split(new char[] {' '});
            int i = Convert.ToInt16(words[1]);
            if (words[0].Equals("Красные"))
            {
                B.Invoke(new Action(() => B.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.DarkRed));
                B.Invoke(new Action(() => B.Show()));
                System.Threading.Thread.Sleep(1000);
            }
            else {
                A.Invoke(new Action(() => A.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.DarkRed));
                A.Invoke(new Action(() => A.Show()));
                System.Threading.Thread.Sleep(1000);
            }

        }
    }

}
