using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Битва
{
    class HeavyUnit : AbstractUnit, IHealble
    {

        public override  IUnit MC()
        {
            IUnit A = new HeavyUnit();
            A = (HeavyUnit)this.MemberwiseClone();
            return (IUnit)A;
        }

        public HeavyUnit() { health = 70; type = "HeavyUnit"; cost = 30; maxAttack = 40; }


        public void DoctorHelp() { health = maxHealth; }




    }
}
