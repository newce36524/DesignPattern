using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class StateContext
    {
        public StateBase StateBase { get; set; }
        public void NextState()
        {
            StateBase.ToggleState(this);
        }

        public void ShowState()
        {
            StateBase.ShowState();
        }
    }
}
