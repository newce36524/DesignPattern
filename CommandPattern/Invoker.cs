namespace CommandPattern
{
    public class Invoker
    {
        public ICommand Command { get; set; }
        public void SetCommand(ICommand command)
        {
            this.Command = command;
        }

        public void Action()
        {
            this.Command.Execute();
        }
    }
}
