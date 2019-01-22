using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Service
{
    public interface ISevice
    {
        string ServerName { get; set; }
        string Vision { get; set; }

        /// <summary>
        /// 调用服务
        /// </summary>
        void Call();
    }
}
