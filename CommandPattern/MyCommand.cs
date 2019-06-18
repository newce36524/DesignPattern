namespace CommandPattern
{
    public class MyCommand : BaseCommand
    {
        public MyCommand() : base(new MyReceiver())//一般情况下，对上层隐藏具体的接收者
        {
        }

        public override void Execute()
        {
            base._Receiver.Do();
        }
    }
}
