using System;

namespace StatePattern
{
    public abstract class StateBase
    {
        public StateEnum StateProperty { get; set; }
        protected StateContext _stateContext { get; set; }
        public abstract void ShowState();
        public abstract void ToggleState(StateContext context);
    }

    public enum StateEnum
    {
        State1 = 0,
        State2 = 1,
        State3 = 2
    }
}
