using System.Collections.Generic;

namespace Observer
{
    public class MessagePublisher : IObservable
    {
        private List<IObserver> observers;

        public MessagePublisher()
        {
            this.observers = new List<IObserver>();
        }

        /// <summary>
        /// Notify update
        /// </summary>
        public void Notify()
        {
            var news = new List<Message>();
            // for each observer
            foreach (var observer in this.observers)
            {
                // notify update
                observer.Update(news);
            }
        }

        /// <summary>
        /// Subscribe given observer
        /// </summary>
        /// <param name="observer"></param>
        public void Subscribe(IObserver observer)
        {
            // safety null check
            if (observer == null)
            {
                return;
            }

            // add to the collection
            this.observers.Add(observer);
        }

        /// <summary>
        /// Unubscribe given observer
        /// </summary>
        /// <param name="observer"></param>
        public void Unsubscribe(IObserver observer)
        {
            // remove from the collection
            this.observers.Remove(observer);
        }
    }
}
