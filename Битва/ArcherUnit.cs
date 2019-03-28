using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Битва
{
    class ArcherUnit : AbstractUnit, IHealble, ISA, IClonnabl
    {


        public ArcherUnit() {
             type = "ArcherUnit";
             maxHealth = 40;
            health = 40;
            cost = 25;
            maxAttack = 5;
        }
       
            int distance = 5;
            int power = 20;
            public int GetDistance() { return distance; }

            public string Distance() { return Convert.ToString(distance); }

         public override  IUnit  MC()
            {
                IUnit A = new ArcherUnit();
                A = (ArcherUnit)this.MemberwiseClone();
                return (IUnit)A;
            }

            public IUnit MakeClone()
            {
                IUnit A = new ArcherUnit();
                A=(ArcherUnit)this.MemberwiseClone();
                return (IUnit)A;
            }


            public void DoctorHelp() { health = maxHealth; }
            public static Random rnd = new Random(DateTime.UtcNow.Millisecond);

            public bool DoSA(List<IUnit> friends, List<IUnit> enemies, Army A)
            {
                if (enemies.Count() == 0)
                    return false;
                int i = rnd.Next(0, enemies.Count() );
                int j = rnd.Next(1, power + 1);
                enemies[i].SmbAttackedYou(j);
                return false;
            }

        
        
        } 
    }

