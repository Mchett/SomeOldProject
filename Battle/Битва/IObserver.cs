using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Битва
{
    interface IObserver
    {
         void Update(string msg);

    }

    interface IObservable
    {
        void AddObserverF(IObserver o);
        void RemoveObserverF(IObserver o);
        void NotifyObserverF(string msg);
        void AddObserverD(IObserver o);
        void RemoveObserverD(IObserver o);
        void NotifyObserverD(string msg);
        void AddObserverC(IObserver o);
        void RemoveObserverC(IObserver o);
        void NotifyObserverC(string msg);
    }
}
