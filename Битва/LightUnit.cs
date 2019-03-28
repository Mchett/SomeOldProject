using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Битва
{
    class LightUnit : AbstractUnit, IHealble, ISA, IClonnabl
    {

        int distance = 1;
        int [] arr={1,1,1};
        public string Distance() { return Convert.ToString(distance); }

        public LightUnit() {
           type = "LightUnit";
           maxHealth = 50;
           health = 50;
           cost = 15;
           maxAttack = 20;
 
        }
        public IUnit MakeClone()
        {
            IUnit A = new LightUnit();
            A = (LightUnit)this.MemberwiseClone();
            return A;
        }

        public int GetDistance() { return distance; }


        public void DoctorHelp() { health = maxHealth; }

        public bool DoSA(List<IUnit> friends, List<IUnit> enemies, Army A)
        {
            if (friends.Count() <= 1) return false;
            for (int i = 0; i < friends.Count(); i++)
            {
                if (friends[i] is HeavyUnit || friends[i] is Decorate)
                {
                    IUnit B;
                    if (friends[i] is Decorate )
                        B = friends[i];
                    else B = new Decorate((HeavyUnit)(friends[i])); 
                        if (arr[0]==1){
                            if (((Decorate)B).YouHaveSH())
                            {
                                arr[0] = 0;
                                A.Change(friends[i], B);
                            }

                            }
                        else if (arr[1] == 1) {
                            if (((Decorate)B).YouHaveK())
                            {
                                arr[1] = 0;
                                A.Change(friends[i], B);
                            }
                        }
                        else if (arr[2] == 1) {
                            if (((Decorate)B).YouHaveL())
                            {
                                arr[2] = 0;
                                A.Change(friends[i], B);
                            }
                        
                        }
                    break;
                }
            }
            return false;

        }

        public override IUnit MC()
        {
            IUnit A = new LightUnit();
            A = (LightUnit)this.MemberwiseClone();
            return A;
        }

    }
}
