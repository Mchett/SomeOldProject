using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Битва
{
    class BattleField : IObservable
    {

        List<IObserver> OF = new List<IObserver>();
        List<IObserver> OD = new List<IObserver>();
        List<IObserver> OC = new List<IObserver>();

        public void AddObserverF(IObserver o) { OF.Add(o); Arm1.AddObserverF(o); Arm2.AddObserverF(o); }
        public void RemoveObserverF(IObserver o) { OF.Remove(o); Arm1.RemoveObserverF(o); Arm2.RemoveObserverF(o); }
        public void NotifyObserverF(string msg) { foreach (IObserver p in OF) p.Update(msg); }
        public void AddObserverD(IObserver o) { Arm1.AddObserverD(o); Arm2.AddObserverD(o); }
        public void RemoveObserverD(IObserver o) { Arm1.RemoveObserverD(o); Arm2.RemoveObserverD(o); }
        public void NotifyObserverD(string msg) { }
        public void AddObserverC(IObserver o) { Arm1.AddObserverC(o); Arm2.AddObserverC(o); }
        public void RemoveObserverC(IObserver o) { Arm1.RemoveObserverC(o); Arm2.RemoveObserverC(o); }
        public void NotifyObserverC(string msg) { }












        Command Com;
        public void CreateCom(System.Windows.Forms.Button UnDo, System.Windows.Forms.Button ReDo) {
                Com = new Command(UnDo, ReDo, Arm1, Arm2);
        
        }
        public void Undo() {
            Tuple<List<IUnit>, List<IUnit>> pare = Com.Undo();
            Arm1.setArm(pare.Item1);
            Arm2.setArm(pare.Item2);
        }
        public void Redo() {
            Tuple<List<IUnit>, List<IUnit>> pare = Com.Redo();
            Arm1.setArm(pare.Item1);
            Arm2.setArm(pare.Item2);
        }
        public void DelR()    {Com.delr();  }
        public void DelU()    { Com.delu();}
        public void DelB() { Com.delb(); }



        Army Arm1;
        Army Arm2;
        IStrategy Strategy ;
       public void ChangeStrategy(int i)
       {
           switch (i) { 
               case 1: Strategy = new StrategyOne();
                   break;
               case 2: Strategy = new StrategyTwo();
                   break;
               case 3: Strategy = new StrategyMany();
                   break;

           
           
           }
       
       
       }
        private BattleField() {
            Strategy = new StrategyOne();
        }
        //singletone
        static BattleField Battle = null;

        public static BattleField getBat() {
            if (Battle == null)
            {
                Battle = new BattleField();

            }
            return Battle;
        
        }
        public void CreateArmy(int cost)
        {
            Arm1 = new Army( cost, "Белые");
            Arm2 = new Army(cost, "Красные");
        }
        public string WhoWin() {
            if (Arm1.Count() == 0)
                return "Красные";
            return "Белые";
        
        
        }

        public void ShowArmy(System.Windows.Forms.DataGridView A, System.Windows.Forms.DataGridView B)
        {
            Arm1.show(A);
            Arm2.show(B);

        
        }
        public static Random rnd = new Random(DateTime.UtcNow.Millisecond);

        static bool rand()
        {

            return (rnd.Next() % 2 == 0);

        }
        public void Pause()
        {
            Strategy.Pause();

        }
        public int DoMany(System.Windows.Forms.DataGridView A, System.Windows.Forms.DataGridView B) {
          
           int i = Com.Execute(Arm1, Arm2, Strategy, A,B, 10);
            return i;
        }
        public int DoOne(System.Windows.Forms.DataGridView A, System.Windows.Forms.DataGridView B)
        {

            int i = Com.Execute(Arm1, Arm2, Strategy, A, B, 1);

            
            return i;
        
        }

    }
}
