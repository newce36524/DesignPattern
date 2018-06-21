using System;
using System.Collections.Generic;
using System.Text;

namespace ObservePattern
{
    public class ObserveEvent
    {
        public event Action ObserveEventSource;

        public void RaiseEvent()
        {
            ObserveEventSource?.Invoke();
        }
    }
}
