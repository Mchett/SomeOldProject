using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Битва
{
    class Army:IObservable
    {
        string Name;
        List<IUnit> Arm = new List<IUnit>();
        public static Random rnd = new Random(DateTime.UtcNow.Millisecond);

        public int rnd1()
        {

            int i = rnd.Next(0, 6);
            return i;
        }
        public List<IUnit> Clon()
        {
            List<IUnit> A= new List<IUnit>();
            for (int i = 0; i < Arm.Count(); i++)
                A.Add(((IUnit)Arm[i]).MC());
            return A;
        }
        public void setArm( List<IUnit> newList)
        {
            Arm.Clear();
            for (int i = 0; i < newList.Count(); i++)
                Arm.Add(((IUnit)newList[i]).MC());
        }
        public Army(int cost, string name)
        {
             LightUnitFabric LU = new LightUnitFabric();
            HeavyUnitFabric HU = new HeavyUnitFabric();
            ArcherUnitFabric AU = new ArcherUnitFabric() ;
            WizardUnitFabric WU = new WizardUnitFabric() ;
            ClericUnitFabric CU = new ClericUnitFabric();
            GGUnitFabric Gg = new GGUnitFabric();

            IAbstractFabric[] fab = { LU, HU, AU, WU, CU , Gg};
            Name = name;
            while (cost - 15 >= 0) {
                int i = rnd1();
                IUnit a =fab[i].Make();
                if (a.GetCost() <= cost)
                {
                    Arm.Add(a);
                   /* if (a is GG)
                        cost = 0;
                    else*/
                    cost -= a.GetCost();
                }
            }

        }
        public bool SoldiersAreStill()
        {
            return (Arm.Count() > 0);
        }
        public int OneSoldierMakeAttack(int i) {

            int harm = Arm[i].MadeAttack();
            string msg = Arm[i].Type() + " из армии \"" + Name + "\" на позиции " + i.ToString() + " совершил атаку с уроном " + harm.ToString() + ".";
            NotifyObserverF(msg);

            return harm;
        }
        public bool SmbAttackedOneSoldier(int harm, int i)
        {
            Arm[i].SmbAttackedYou(harm);

            string msg = Arm[i].Type() + " из армии \"" + Name + "\" на позиции " + i.ToString() + " ударили с уроном "+ harm.ToString()+".";
            NotifyObserverF(msg);


            if (!(Arm[i].AreYouAlive()))
            {
                return false;
            }
            return true;
        }
        public int Count() { return Arm.Count(); }
       
        public void show(System.Windows.Forms.DataGridView A)
        {
            int i = 1;
            A.Invoke(new Action(() => A.Rows.Clear()));
            foreach (IUnit p in Arm)
            {

                if (p is ISA)
                     A.Invoke(new Action(() => A.Rows.Add(i,p.Type(), p.Helth(), p.MaxAttack(), ((ISA)p).Distance())));
                else
                    A.Invoke(new Action(() => A.Rows.Add(i,p.Type(), p.Helth(), p.MaxAttack(), "")));
                i++;
            }


        }
        public IUnit Take(int i) {
            return Arm[i];
        }
        public int SADistance(int i) {
            if (Arm[i] is ISA)
                return ((ISA)Arm[i]).GetDistance();
            else return 0;
        }
        public void CheckDead() {
            for (int i =0; i<Arm.Count(); i++)
            {
                if (!Arm[i].AreYouAlive())
                {
                    string msg = Arm[i].Type() + " из армии \"" + Name + "\" с позиции " +i.ToString()+ " умер.";
                    NotifyObserverF(msg);
                    msg = Name + " " + i.ToString();
                    NotifyObserverD(msg);

                    Arm.Remove(Arm[i]);
                    i--;
                }
            }
        
        }
        public bool IsHeAlive(int i) {
            return Arm[i].AreYouAlive();
        }
        public bool DoSA(int i, List<IUnit> friends, List<IUnit> enemies)
        {

            return ((ISA)Arm[i]).DoSA(friends, enemies, this);
                
        }
        public void Change(IUnit B, IUnit A)
        {


            int i = Arm.IndexOf(B);

            string msg = Arm[i].Type() + " из армии \"" + Name + "\" с позиции " + i.ToString() + " декорирован.";
            NotifyObserverF(msg);

            Arm[i] = A;
        }

        public void ADD(IUnit B, IUnit A)
        {
            int i = Arm.IndexOf(B);

            string msg = Arm[i].Type() + " из армии \"" + Name + "\" с позиции " + i.ToString() + " клонирован.";
            NotifyObserverC(msg);

            Arm.Insert(i+1, A);
        }

        public List<IUnit> NewList(int i, int j)
        {
            List<IUnit> a = new List<IUnit>();
            int k = 0;
            if (j >= Arm.Count())
                j = Arm.Count()-1;
            if (i < 0)
                i = 0;
            for (k = j; k >= i; k--)
                a.Add(Arm[k]);
            return a;

        }







        List<IObserver> OF = new List<IObserver>();
        List<IObserver> OD = new List<IObserver>();
        List<IObserver> OC = new List<IObserver>();

      public  void AddObserverF(IObserver o) {OF.Add(o);}
      public void RemoveObserverF(IObserver o) { OF.Remove(o); }
      public void NotifyObserverF(string msg) { foreach (IObserver p in OF) p.Update(msg); }
      public void AddObserverD(IObserver o) { OD.Add(o); }
      public void RemoveObserverD(IObserver o) { OD.Remove(o); }
      public void NotifyObserverD(string msg) { foreach (IObserver p in OD) p.Update(msg); }
      public void AddObserverC(IObserver o) { OC.Add(o); }
      public void RemoveObserverC(IObserver o) { OC.Remove(o); }
      public void NotifyObserverC(string msg) { NotifyObserverF(msg); foreach (IObserver p in OC) p.Update(msg); }







    }
}
