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
            //把自身的属性交给别的类来修改
            StateBase.ToggleState(this);
        }

        public void ShowState()
        {
            StateBase.ShowState();
        }
    }
}
