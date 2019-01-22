namespace BridgePattern.Server
{
    public class CommomServer : BaseServer
    {
        public override void Call()
        {
            System.Console.WriteLine($"服务端部署了{this.Service.ServerName}:版本号为：{this.Service.Vision}");
            this.Service.Call();
        }
    }   
}
