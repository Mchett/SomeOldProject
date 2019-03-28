using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Битва
{
    
        interface IUnit
        {
            IUnit MC();
              string Type() ;
              string Helth();
              string Cost() ;
              string MaxAttack();
            void SmbAttackedYou(int harm);
            int GetCost();
            int MadeAttack();
            bool AreYouAlive();


        }
        interface IClonnabl {
            IUnit MakeClone();
        
        }
        interface IHealble {
            void DoctorHelp();
        }
        interface ISA
        {
            int GetDistance();
            string Distance();
            bool DoSA(List<IUnit> friends, List<IUnit> enemies, Army A);
        }


}
