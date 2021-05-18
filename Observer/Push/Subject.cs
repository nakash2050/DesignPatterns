using System.Collections.Generic;

namespace Observer.Push
{
    // 1. Subject
    public class Subject
    {
        private readonly List<IObserver> _observers = new();
        
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        protected void NotifyObservers(int value)
        {
            foreach (var observer in _observers)
            {
                observer.Update(value);
            }
        }
    }
}