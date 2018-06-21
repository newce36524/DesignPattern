using System;

namespace StrategyPattern
{
    public class StrategyThree : StrategyBase
    {
        public override void Invoke(State eParam, string sParam)
        {
            Console.WriteLine($"这是策略三执行的方法{eParam}{sParam}");
        }
    }
}
