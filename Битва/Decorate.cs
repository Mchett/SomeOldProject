using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Битва
{
    class Decorate : HeavyUnit
    {

        public override IUnit MC()
        {
            IUnit A = new Decorate(((Decorate)this));
            A = (Decorate)this.MemberwiseClone();
            return A;
        }
        public Decorate( Decorate A)
        {
            health = Convert.ToInt16(A.Helth());
            maxAttack = A.maxAttack;
            maxHealth = A.maxHealth;
            cost = A.GetCost();
            SH = A.SH; L = A.L; K = A.K; h = A.h;

        }
         int SH=0,L=0 , K=0,h=0 ;

        public Decorate(HeavyUnit B) {
            health = Convert.ToInt16(B.Helth());
            maxAttack=base.maxAttack;
            maxHealth=base.maxHealth;
            cost=B.GetCost();
            
        }

        public override string Helth() { return Convert.ToString(health); }
        public override string Cost() { return Convert.ToString(cost); }
        public override string MaxAttack() { return Convert.ToString(maxAttack); }

        public bool YouHaveSH()
        {
            if (SH == 0) { SH = 20; return true; }
            return false;
        }
        public bool YouHaveL()
        {
            if (L == 0)
            {
                L = 25;
                return true;
            }
            return false; 
        }
        public bool YouHaveK() {

            if (K == 0){K = 15;  return true; }
            return false;}
        void YouLostSH() { SH = 0; }
        void YouLostL() { L = 0; }
        void YouLostK() { h = 0; K = 0; }

        public override string Type() {
            string type = "HeavyUnit";
            if (K > 0) {
                string k = "|К(" +K.ToString() + ")";
                type =type+k;
            }
            if (SH > 0)
            {
                string sh = "|Ш(" +SH.ToString() + ")";
                type =type+sh;

             }
             if (L > 0)
             {
                 string l = "|Л(" + L.ToString() + ")";
                 type = type + l;
             }

            
            return type; 
        }

        public override void SmbAttackedYou(int harm)
        {
            if (SH > 0)
            {
                SH = SH - harm;
                if (SH < 0)
                {
                    if (L > 0)
                    {
                        L = L + SH;
                        if (L < 0)
                            base.SmbAttackedYou(-L);
                    }
                    else
                        base.SmbAttackedYou(-SH);
                }
                
            }
            else if (L > 0)
            {
                L = L - harm;
                if (L < 0)
                    base.SmbAttackedYou(-L);
            }
            else base.SmbAttackedYou(harm);
            if (SH < 0)
                YouLostSH();
            if (L < 0)
                YouLostL();
        }
        public override int MadeAttack()
        {
            if (K > 0)
            {
                h++;
                int i = base.MadeAttack();
                if (h > 2)
                    YouLostK();
                return i + K;
            }
            else return base.MadeAttack();
        }


    }
}
