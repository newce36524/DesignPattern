using System;

namespace BridgePattern.Service
{
    public class DownloadSevice : ISevice
    {
        public string ServerName { get; set; } = "数据下载服务";

        public string Vision { get; set; }
        public void Call()
        {
            Console.WriteLine("数据上传");
        }
    }
}
