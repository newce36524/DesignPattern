using System;

namespace BridgePattern.Service
{
    public class TranspondSevice : ISevice
    {
        public string ServerName { get; set; } = "数据转发服务";

        public string Vision { get; set; }
        public void Call()
        {
            Console.WriteLine("数据转发");
        }
    }
}
