using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class StrategyOne : StrategyBase
    {
        public override void Invoke(State eParam, string sParam)
        {
            Console.WriteLine($"这是策略一执行的方法{eParam}{sParam}");
        }
    }
}
