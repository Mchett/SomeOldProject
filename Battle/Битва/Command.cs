using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Битва
{
    class Command
    {
        System.Windows.Forms.Button UNDO;
        System.Windows.Forms.Button REDO;
        public Command(System.Windows.Forms.Button UnDo, System.Windows.Forms.Button ReDo, Army A, Army B)
        {
            List<IUnit> A1 = A.Clon();
            List<IUnit> B1 = B.Clon();
            Tuple<List<IUnit>, List<IUnit>> pare = new Tuple<List<IUnit>, List<IUnit>>(A1, B1);
            between.Add(pare);
            UNDO=UnDo;
            REDO=ReDo;
        
        }
        public int Execute(Army A, Army B, IStrategy S, System.Windows.Forms.DataGridView AD, System.Windows.Forms.DataGridView BD, int i)
        {
            int k;
            if (i == 1)
            {
                {
                    k = S.OneStep(A, B, AD, BD);
                    this.NewUndo(A, B);
                }
            }
            else
            {
                k = S.PlayGame(A, B, AD, BD);
                this.NewUndo(A, B);
            }
            return k;
        
        }

        public void NewUndo(Army A, Army B)
        {


                undo.Add(between[0]);
                between.Remove(between[0]);
                List<IUnit> A1 = A.Clon();
                List<IUnit> B1 = B.Clon();
                Tuple<List<IUnit>, List<IUnit>> pare = new Tuple<List<IUnit>, List<IUnit>>(A1, B1);
                between.Add(pare);
            
        }
        public Tuple<List<IUnit>, List<IUnit>> Undo()
        {
            redo.Add(between[0]);
            if (redo.Count() > 0)
                REDO.Enabled = true;
            between[0] = undo.Last();
            undo.Remove(undo.Last());
            if (undo.Count() == 0)
                UNDO.Enabled = false;
            return between[0];
        }
        public Tuple<List<IUnit>, List<IUnit>> Redo()
        {

            undo.Add(between[0]);
            if (undo.Count() > 0)
                UNDO.Enabled = true;
            between[0] = redo.Last();
            redo.Remove(redo.Last());
            if (redo.Count() == 0)
                REDO.Enabled = false;
            return between[0];
        }
        public void delr() { redo.Clear(); }
        public void delu() { undo.Clear(); }
        public void delb() { between.Clear(); }



        List<Tuple<List<IUnit>, List<IUnit>>> undo = new List<Tuple<List<IUnit>, List<IUnit>>>();
        List<Tuple<List<IUnit>, List<IUnit>>> redo = new List<Tuple<List<IUnit>, List<IUnit>>>();
        List<Tuple<List<IUnit>, List<IUnit>>> between = new List<Tuple<List<IUnit>, List<IUnit>>>();


    }
}
