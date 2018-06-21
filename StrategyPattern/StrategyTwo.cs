using System;

namespace StrategyPattern
{
    public class StrategyTwo : StrategyBase
    {
        public override void Invoke(State eParam, string sParam)
        {
            Console.WriteLine($"这是策略二执行的方法{eParam}{sParam}");
        }
    }
}
