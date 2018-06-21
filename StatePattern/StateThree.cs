using System;

namespace StatePattern
{
    public class StateThree : StateBase
    {
        public StateThree()
        {
            this.StateProperty = StateEnum.State3;
        }

        public override void ShowState()
        {
            Console.WriteLine(this.StateProperty);
        }

        public override void ToggleState(StateContext context)
        {
            context.StateBase = new StateOne();
        }
    }
}
