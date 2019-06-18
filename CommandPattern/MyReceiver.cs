using System;

namespace CommandPattern
{
    public class MyReceiver : Receiver
    {
        public override void Do()
        {
            Console.WriteLine("hello");
        }
    }
}
