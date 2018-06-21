using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class StateOne : StateBase
    {
        public StateOne()
        {
            this.StateProperty = StateEnum.State1;
        }

        public override void ShowState()
        {
            Console.WriteLine(this.StateProperty);
        }

        public override void ToggleState(StateContext context)
        {
            context.StateBase = new StateTwo();
        }
    }
}
