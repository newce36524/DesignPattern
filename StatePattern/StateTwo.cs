using System;

namespace StatePattern
{
    public class StateTwo : StateBase
    {
        public StateTwo()
        {
            this.StateProperty = StateEnum.State2;
        }
        public override void ShowState()
        {
            Console.WriteLine(this.StateProperty);
        }

        public override void ToggleState(StateContext context)
        {
            context.StateBase = new StateThree();
        }
    }
}
