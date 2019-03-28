using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Битва
{
    interface IAbstractFabric
    {
        IUnit Make();
    }
    class GGUnitFabric : IAbstractFabric
    {
        public IUnit Make()
        {
            return new GG();
        }
    }
    class LightUnitFabric : IAbstractFabric
    {
        public IUnit Make()
        {
            return new LightUnit();
        }
    }
    class HeavyUnitFabric : IAbstractFabric {
        public IUnit Make()
        {
            return new HeavyUnit();
        }
    }
    class ArcherUnitFabric : IAbstractFabric {
        public IUnit Make()
        {
            return new ArcherUnit();
        }
    }
    class WizardUnitFabric : IAbstractFabric {
        public IUnit Make()
        {
            return new Wizard();
        }
    }
    class ClericUnitFabric : IAbstractFabric {
       public IUnit Make()
        {
            return new Cleric();
        }
    }

}
