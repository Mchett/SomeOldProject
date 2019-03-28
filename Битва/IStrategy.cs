using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Битва
{
    interface IStrategy
    {
        int OneStep(Army A, Army B, System.Windows.Forms.DataGridView DA, System.Windows.Forms.DataGridView DB);
        int PlayGame(Army A, Army B, System.Windows.Forms.DataGridView DA, System.Windows.Forms.DataGridView DB);
        void Pause();
    }


    //один х один
    class StrategyOne : IStrategy {
        bool flag = true;
        public static Random rnd = new Random(DateTime.UtcNow.Millisecond);

        public int rnd1()
        {       

            int i = rnd.Next();
            return i;
        }
        void func(Army A, Army B)
        {
           if (B.SmbAttackedOneSoldier(A.OneSoldierMakeAttack(0), 0))
                A.SmbAttackedOneSoldier(B.OneSoldierMakeAttack(0), 0);
           B.CheckDead();
           A.CheckDead();

            for (int i = 0; i < A.Count(); i++)
            {
                if (A.SADistance(i) > 0)
                {
                    List<IUnit> enemies = new List<IUnit>();
                    List<IUnit> friends = A.NewList(i - A.SADistance(i), i + A.SADistance(i));
                    int k = i - A.SADistance(i);
                    if (k < 0)
                    {
                        k = Math.Abs(k) - 1;
                        enemies = B.NewList(0, k);
                    }
                    if (A.DoSA(i, friends, enemies))
                        i++;

                }
            }
            B.CheckDead();
            for (int i = 0; i < B.Count(); i++)
            {
                if (B.SADistance(i) > 0)
                {
                    List<IUnit> enemies = new List<IUnit>();
                    List<IUnit> friends = B.NewList(i - B.SADistance(i), i + B.SADistance(i));
                    int k = i - B.SADistance(i);
                    if (k < 0)
                    {
                        k = Math.Abs(k) - 1;
                        enemies = A.NewList(0, k);
                    }
                    if (B.DoSA(i, friends, enemies))
                        i++;

                }
            }
            A.CheckDead();
        }

        bool changeenumsList(Army A, Army B) {
            bool b = true;
            for (int i = 0; i < A.Count(); i++)
            {
                if (A.Take(i) is ArcherUnit)
                {
                    List<IUnit> enemies = new List<IUnit>();
                    int k = i - A.SADistance(i);
                    if (k < 0)
                    {
                        b = false;
                        break;
                    }
                }
            }
            return b;
        
        }

        //ничья?
        bool Nobodywin(Army A, Army B) {
            if ((A.Take(0) is GG && B.Take(0) is GG) && (changeenumsList(A, B) && changeenumsList(B, A)))
                return true;
            return false;
        }

        public int OneStep(Army A, Army B, System.Windows.Forms.DataGridView DA, System.Windows.Forms.DataGridView DB)
        {

            if (rnd1() % 2 == 0)  func(A, B);
            else func( B,A);
            A.show(DA);
            B.show(DB);
            if (!(A.Count() > 0 && B.Count()>0))
                return 1;//win
            else if (Nobodywin(A,B))
                return 2;//nobodywin
            else return 3;
        }

       public int PlayGame(Army A, Army B,System.Windows.Forms.DataGridView DA, System.Windows.Forms.DataGridView DB) {
           flag = true;
           while (A.Count() > 0 && B.Count() > 0 && flag)
           {
               int a = OneStep(A, B, DA, DB);
               System.Threading.Thread.Sleep(1000);
               if (a ==1)
                   return 1;
               if (a==2)
                   return 2;
           }
             return 3;
       }



       public void Pause(){flag = false;}
    }


    //два х два
    class StrategyTwo : IStrategy {
        bool flag = true;

        public static Random rnd = new Random(DateTime.UtcNow.Millisecond);

        public int rnd1()
        {

            int i = rnd.Next();
            return i;
        }
        void func(Army A, Army B)
        {
            if (A.Count() >= 2 && B.Count() >= 2)
            {
                if (B.SmbAttackedOneSoldier(A.OneSoldierMakeAttack(1), 1))
                    A.SmbAttackedOneSoldier(B.OneSoldierMakeAttack(1), 1);
                if (B.SmbAttackedOneSoldier(A.OneSoldierMakeAttack(0), 0))
                    A.SmbAttackedOneSoldier(B.OneSoldierMakeAttack(0), 0);
            }
            else if (A.Count() >= 2 && B.Count() < 2)
            {
                if (B.SmbAttackedOneSoldier(A.OneSoldierMakeAttack(1), 0))
                {
                    A.SmbAttackedOneSoldier(B.OneSoldierMakeAttack(0), 1);
                    if ((B.SmbAttackedOneSoldier(A.OneSoldierMakeAttack(0), 0)))
                        A.SmbAttackedOneSoldier(B.OneSoldierMakeAttack(0), 0);
                }

            }
            else if (A.Count() < 2 && B.Count() >= 2) {
                if ((B.SmbAttackedOneSoldier(A.OneSoldierMakeAttack(0), 1)))
                    if (A.SmbAttackedOneSoldier(B.OneSoldierMakeAttack(1), 0))
                       if( (B.SmbAttackedOneSoldier(A.OneSoldierMakeAttack(0), 0)))
                           A.SmbAttackedOneSoldier(B.OneSoldierMakeAttack(0), 0);
            }
            else if (A.Count() < 2 && B.Count() < 2)
            {
                if (B.SmbAttackedOneSoldier(A.OneSoldierMakeAttack(0), 0))
                    A.SmbAttackedOneSoldier(B.OneSoldierMakeAttack(0), 0);
            }

                B.CheckDead();
                A.CheckDead();
            
            
            for (int i = 0; i < A.Count(); i++)
            {
                if (A.SADistance(i) > 0)
                {
                    List<IUnit> enemies = new List<IUnit>();
                    List<IUnit> friends = new List<IUnit>();
                    int n = A.SADistance(i);

                    if (i % 2 == 0)
                    {
                        int j = i - 2 * n + 2;
                        int k = i + 2 * n;
                        friends = A.NewList(k, j);
                        if ((i - 2 * n) > 0)
                        {
                            IList<IUnit> f = A.NewList(i - 2 * n, i - 2 * n);
                            friends.Add(f[0]);
                        }
                        k = Math.Abs(i - 2 * n) - 2;
                        enemies = B.NewList(0, k);
                    }
                    else
                    {
                        int j = i - 2 * n;
                        int k = i + 2 * n - 2;
                        friends = A.NewList(k, j);
                        if ((i + 2 * n) < A.Count())
                        {
                            IList<IUnit> f = A.NewList(i + 2 * n, i + 2 * n);
                            friends.Add(f[0]);
                        }

                        k = Math.Abs(i - 2 * n) - 2;
                        enemies = B.NewList(0, k);
                        if ((k + 2) < B.Count())
                        {
                            IList<IUnit> e = B.NewList(k + 2, k + 2);
                            enemies.Add(e[0]);
                        }


                    }
                    if (A.DoSA(i, friends, enemies))
                        i++;

                }
            }
            B.CheckDead();
            for (int i = 0; i < B.Count(); i++)
            {
                if (B.SADistance(i) > 0)
                {
                    List<IUnit> enemies = new List<IUnit>();
                    List<IUnit> friends = new List<IUnit>();
                    int n = B.SADistance(i);

                    if (i % 2 == 0)
                    {
                        int j = i - 2 * n + 2;
                        int k = i + 2 * n;
                        friends = B.NewList(k, j);
                        if ((i - 2 * n) > 0)
                        {
                            IList<IUnit> f = B.NewList(i - 2 * n, i - 2 * n);
                            friends.Add(f[0]);
                        }
                        k = Math.Abs(i - 2 * n) - 2;
                        enemies = A.NewList(0, k);
                    }
                    else
                    {
                        int j = i - 2 * n;
                        int k = i + 2 * n - 2;
                        friends = B.NewList(k, j);
                        if ((i + 2 * n) < B.Count())
                        {
                            IList<IUnit> f = B.NewList(i + 2 * n, i + 2 * n);
                            friends.Add(f[0]);
                        }

                        k = Math.Abs(i - 2 * n) - 2;
                        enemies = A.NewList(0, k);
                        if ((k + 2) < A.Count())
                        {
                            IList<IUnit> e = A.NewList(k + 2, k + 2);
                            enemies.Add(e[0]);
                        }


                    }
                    if (B.DoSA(i, friends, enemies))
                        i++;

                }
            }
            A.CheckDead();

        }



        bool changeenumsList(Army A, Army B)
        {
            bool b = true;
            for (int i = 0; i < A.Count(); i++)
            {
                if (A.Take(i) is ArcherUnit)
                {
                    List<IUnit> enemies = new List<IUnit>();
                    int n = A.SADistance(i);

                    if (i % 2 == 0)
                    {
                        int j = i - 2 * n + 2;
                        int k = i + 2 * n;
                        k = Math.Abs(i - 2 * n) - 2;
                        enemies = B.NewList(0, k);
                    }
                    else
                    {
                        int j = i - 2 * n;
                        int k = i + 2 * n - 2;
                        k = Math.Abs(i - 2 * n) - 2;
                        enemies = B.NewList(0, k);
                        if ((k + 2) < B.Count())
                        {
                            IList<IUnit> e = B.NewList(k + 2, k + 2);
                            enemies.Add(e[0]);
                        }
                    }
                    if (enemies.Count() > 0)
                    {
                        b = false;
                        break;
                    }
                }

            }
            return b;

        }




        bool Nobodywin(Army A, Army B)
        {
            bool b = false;
            if ((changeenumsList(A, B) && changeenumsList(B, A)))
            {

                if (A.Count() >= 2 && B.Count() >= 2)
                {
                    if (A.Take(0) is GG && A.Take(1) is GG && B.Take(0) is GG && B.Take(1) is GG)
                        b = true;
                }
                else if (A.Count() >= 2 && B.Count() < 2)
                {
                    if (A.Take(0) is GG && A.Take(1) is GG && B.Take(0) is GG)
                        b = true;
                }
                else if (A.Count() < 2 && B.Count() >= 2)
                {
                    if (A.Take(0) is GG && B.Take(0) is GG && B.Take(1) is GG)
                        b = true;
                }
                else if (A.Count() < 2 && B.Count() < 2)
                {
                    if (A.Take(0) is GG && B.Take(0) is GG)
                        b = true;
                }


            }


            return b;
        }

        public int OneStep(Army A, Army B, System.Windows.Forms.DataGridView DA, System.Windows.Forms.DataGridView DB)
        {

            if (rnd1() % 2 == 0) func(A, B);
            else func(B, A);
            A.show(DA);
            B.show(DB);
            if (!(A.Count() > 0 && B.Count() > 0))
                return 1;//win
            else if (Nobodywin(A, B))
                return 2;//nobodywin
            else return 3;
        }

        public int PlayGame(Army A, Army B, System.Windows.Forms.DataGridView DA, System.Windows.Forms.DataGridView DB)
        {
            flag = true;
            while (A.Count() > 0 && B.Count() > 0 && flag)
            {
                int a = OneStep(A, B, DA, DB);
                System.Threading.Thread.Sleep(1000);
                if (a == 1)
                    return 1;
                if (a == 2)
                    return 2;
            }
            return 3;
        }




        public void Pause() { flag = false; }
    }



    //стека х стенка
    class StrategyMany : IStrategy {
        bool flag = true;

        public static Random rnd = new Random(DateTime.UtcNow.Millisecond);

        public int rnd1()
        {

            int i = rnd.Next();
            return i;
        }
        void func(Army A, Army B)
        {
            int min ; 
            if (A.Count() == B.Count())
            {
                for (int j = 0; j < B.Count(); j++)
                {
                    if (B.SmbAttackedOneSoldier(A.OneSoldierMakeAttack(j), j))
                        A.SmbAttackedOneSoldier(B.OneSoldierMakeAttack(j), j);
                }
            }

            else
            {
                if (A.Count() < B.Count())
                    min = A.Count();
                else min = B.Count();
                int i;
                for (i = 0; i < min; i++)
                {
                    if (B.SmbAttackedOneSoldier(A.OneSoldierMakeAttack(i), i))
                        A.SmbAttackedOneSoldier(B.OneSoldierMakeAttack(i), i);
                }
                if (A.Count() > min)
                {
                    if (B.IsHeAlive(i - 1))
                    {
                        if (B.SmbAttackedOneSoldier(A.OneSoldierMakeAttack(i ), i-1))
                            A.SmbAttackedOneSoldier(B.OneSoldierMakeAttack(i-1), i );
                    }
                }
            }
            B.CheckDead();
            A.CheckDead();


            for (int i = 0; i < A.Count(); i++)
            {
                if (A.SADistance(i) > 0)
                {
                    List<IUnit> enemies = new List<IUnit>();
                    List<IUnit> friends = A.NewList(i - A.SADistance(i), i + A.SADistance(i));
                    int k = i - A.SADistance(i) + 1;
                    int j = i + A.SADistance(i) - 1;
                    enemies = B.NewList(k, j);
                    if (A.DoSA(i, friends, enemies))
                        i++;

                }
            }
            B.CheckDead();
            for (int i = 0; i < B.Count(); i++)
            {
                if (B.SADistance(i) > 0)
                {
                    List<IUnit> enemies = new List<IUnit>();
                    List<IUnit> friends = B.NewList(i - B.SADistance(i), i + B.SADistance(i));
                    int k = i - B.SADistance(i) + 1;
                    int j = i + B.SADistance(i) - 1;
                    enemies = A.NewList(k, j);
                    if (B.DoSA(i, friends, enemies))
                        i++;

                }
            }
            A.CheckDead();



        }




        bool changeenumsList(Army A, Army B)
        {
            bool b = true;
            for (int i = 0; i < A.Count(); i++)
            {
                if (A.Take(i) is ArcherUnit)
                {
                    List<IUnit> enemies = new List<IUnit>();
                    int k = i - A.SADistance(i) + 1;
                    int j = i + A.SADistance(i) - 1;
                    enemies = B.NewList(k, j);
                    if (enemies.Count() > 0)
                    {
                        b = false;
                        break;
                    }
                }

            }
            return b;

        }

        bool Nobodywin(Army A, Army B)
        {
            bool b = false;
            if ((changeenumsList(A, B) && changeenumsList(B, A)))
            {
                int min; 

                if (A.Count() == B.Count())
                {
                    bool c = true;
                    for (int j = 0; j < B.Count(); j++)
                    {
                        if (!(A.Take(j) is GG && B.Take(j) is GG))
                        {
                            c = false;
                            break;
                        }
                    }
                    b = c;
                }

                else
                {
                    if (A.Count() < B.Count())
                        min = A.Count();
                    else min = B.Count();
                    int i;
                    
                        bool c = true;
                        for (int j = 0; j < B.Count(); j++)
                        {
                            if (!(A.Take(j) is GG && B.Take(j) is GG))
                            {
                                c = false;
                                break;
                            }
                        }

                        if (A.Count() > min)
                        {
                            if (!(A.Take(min) is GG))
                            {
                                c = false;
                            }
                        }
                        else
                        {
                            if (!(B.Take(min) is GG))
                            {
                                c = false;
                            }
                        }
                        b = c;
                }
            }
            return b;
        }

        public int OneStep(Army A, Army B, System.Windows.Forms.DataGridView DA, System.Windows.Forms.DataGridView DB)
        {

            if (rnd1() % 2 == 0) func(A, B);
            else func(B, A);
            A.show(DA);
            B.show(DB);
            if (!(A.Count() > 0 && B.Count() > 0))
                return 1;//win
            else if (Nobodywin(A, B))
                return 2;//nobodywin
            else return 3;
        }

        public int PlayGame(Army A, Army B, System.Windows.Forms.DataGridView DA, System.Windows.Forms.DataGridView DB)
        {
            flag = true;
            while (A.Count() > 0 && B.Count() > 0 && flag)
            {
                int a = OneStep(A, B, DA, DB);
                System.Threading.Thread.Sleep(1000);
                if (a == 1)
                    return 1;
                if (a == 2)
                    return 2;
            }
            return 3;
        }
        public void Pause() { flag = false; }
    
    }
}
