namespace CommandPattern
{
    public abstract class BaseCommand : ICommand
    {
        protected BaseCommand(Receiver Receiver)
        {
            _Receiver = Receiver;
        }

        protected Receiver _Receiver { get; set; }
        
        public abstract void Execute();
    }
}
