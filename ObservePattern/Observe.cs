using System;
using System.Collections.Generic;

namespace ObservePattern
{
    public class Observe
    {
        public List<Action> ObserveList { get; set; } = new List<Action>();

        public void AddObserveItem(Action observe)
        {
            this.ObserveList.Add(observe);
        }

        public void RemoveObserveItem(Action observe)
        {
            this.ObserveList.Remove(observe);
        }

        public void ObserveAction()
        {
            foreach (var observe in this.ObserveList)
            {
                observe?.Invoke();
            }
        }
    }
}
