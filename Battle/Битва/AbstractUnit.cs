using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Битва
{
    class AbstractUnit:IUnit
    {
        public virtual IUnit MC() { return new AbstractUnit(); }
        protected int maxHealth;
       protected  string type = "Type";
       protected int health ;
       protected  int cost;
       protected int maxAttack;
        public virtual string Type() { return type; }
        public virtual string Helth() { return Convert.ToString(health); }
        public virtual string Cost() { return Convert.ToString(cost); }
        public virtual string MaxAttack() { return Convert.ToString(maxAttack); }

        public static Random rnd = new Random(DateTime.UtcNow.Millisecond);


        public int rnd1()
        {
            int i = rnd.Next(1, maxAttack);
            return i;
        }
        public virtual void SmbAttackedYou(int harm)
        {
            health = health - harm;
            if (health < 0)
                health = 0;
        }
        public virtual int GetCost() { return cost; }
        public virtual int MadeAttack() { return rnd1(); }
        public virtual bool AreYouAlive() { return (health > 0); }

    }
}
