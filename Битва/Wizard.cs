using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Битва
{
    class Wizard : AbstractUnit, ISA
    {

        public override IUnit MC()
        {
            IUnit A = new Wizard();
            A = (Wizard)this.MemberwiseClone();
            return (IUnit)A;
        }

        public Wizard()
        {
            type = "Wizard";
        health =40;
        cost = 30;
        maxAttack = 10;
       }
        int power = 5;
        int distance = 4;
        public int GetDistance() { return distance; }

        public string Distance() { return Convert.ToString(distance); }
        public static Random rnd = new Random(DateTime.UtcNow.Millisecond);

        public bool DoSA(List<IUnit> friends, List<IUnit> enemies, Army A)
        {
            if (power > 0) {
                if (friends.Count() > 0) {
                    int i = rnd.Next(0, friends.Count);
                    if (friends[i] is IClonnabl)
                    {
                        IUnit Z = ((IClonnabl)friends[i]).MakeClone();
                        A.ADD(friends[i], Z);
                        power--;
                        return true;
                    }
            
                }
     
            }
            return false;

        
        
        
        }
    }
}
