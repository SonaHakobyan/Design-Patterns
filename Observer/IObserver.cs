using System.Collections.Generic;

namespace Observer
{
    public interface IObserver
    {
        void Update(List<Message> message);
    }
}
