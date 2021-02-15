using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2.Common
{
    public partial class ControlBase<T> : IObservable<T> where T : IState, new()
    {
        private List<IObserver<T>> observers = new List<IObserver<T>>();

        public IDisposable Subscribe(IObserver<T> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }

        internal void Notify(IState state)
        {
            foreach (var observer in observers)
                observer.OnNext((T)state);
        }
    }
}
