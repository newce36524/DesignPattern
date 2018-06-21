using System;

namespace StrategyPattern
{
    public class StrategyContext
    {
        public void Invoke(State eParam, string sParam, StrategyBase strategyBase)
        {
            //可以在执行前 做额外的逻辑
            strategyBase.Invoke(eParam, sParam);
        }
    }
}
