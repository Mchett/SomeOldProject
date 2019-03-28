using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecialUnits;

namespace Битва
{
    class GG : GulyayGorod, IUnit
    {
        string type;
        public GG() : base(120, 0, 25)
        {
             type = "GulyayGorod";
        }
        public string Type() { return type; }
        public string Helth() { return Convert.ToString(base.GetCurrentHealth()); }
        public string Cost() { return Convert.ToString(base.GetCost()); }
        public string MaxAttack() { return Convert.ToString(GetStrength()); }
        public void SmbAttackedYou(int harm) { if(!IsDead)TakeDamage(harm); }
        public int GetCost() { return base.GetCost(); }
        public int MadeAttack()
        {

            return GetStrength();
        }
        public bool AreYouAlive() { return !IsDead; }

        public IUnit MC()
        {
            IUnit A = new GG();
            A = (GG)this.MemberwiseClone();
            return A;
        }
    }
}
