using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Битва
{
    class Cleric : AbstractUnit,  ISA
    {
        public override IUnit MC()
        {
            IUnit A = new Cleric();
            A = (Cleric)this.MemberwiseClone();
            return (IUnit)A;
        }
        public Cleric() {
            type = "Cleric";
            maxHealth = 50;
            health = 50;
            cost = 20;
            maxAttack = 10;
        }
     
        int distance = 1;
        public int GetDistance() { return distance; }

        public string Distance() { return Convert.ToString(distance); }
        public static Random rnd = new Random(DateTime.UtcNow.Millisecond);

        public bool DoSA(List<IUnit> friends, List<IUnit> enemies, Army A)
        {
            int i = rnd.Next(0, friends.Count());
            if (friends.Count()>0)
            if (friends[i] is IHealble)
                ((IHealble)friends[i]).DoctorHelp();
            return false;
        }
    }
}
