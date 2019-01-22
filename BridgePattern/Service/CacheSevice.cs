using System;

namespace BridgePattern.Service
{
    public class CacheSevice : ISevice
    {
        public string ServerName { get; set; } = "数据缓存服务";
        public string Vision { get; set; }
        public void Call()
        {
            Console.WriteLine("数据缓存");
        }
    }
}
