using System;

namespace BridgePattern.Service
{
    public class SourceSevice : ISevice
    {
        public string ServerName { get; set; } = "资源存储服务";

        public string Vision { get; set; }
        public void Call()
        {
            Console.WriteLine("资源存储");
        }
    }
}
