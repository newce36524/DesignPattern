using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class StrategyBase
    {
        public abstract void Invoke(State eParam,string sParam);
    }
}
