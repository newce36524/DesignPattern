using System;
using System.Collections.Generic;
using System.Text;

namespace ObservePattern.ObserveEventHandles
{
    public class ComputerEventHandle
    {
        public void Calc(int a, int b)
        {
            Console.WriteLine($"计算 a + b = {a + b}");
        }
    }
}
