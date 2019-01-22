using System;
using BridgePattern.Service;

namespace BridgePattern.Server
{
    public abstract class BaseServer
    {
        public ISevice Service { get; set; }

        public abstract void Call();
    }
}
