using System.Collections.Generic;

namespace DsApp.Observers
{
    // Generička klasa za Subject (izdavača)
    public abstract class Subject<T>
    {
        private readonly List<IObserver<T>> observers = new List<IObserver<T>>();

        public void Attach(IObserver<T> observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver<T> observer)
        {
            observers.Remove(observer);
        }

        protected void Notify(T data)
        {
            foreach (var observer in observers)
            {
                observer.Update(data);
            }
        }
    }
}