using System;

namespace SingletionPattern
{
    public sealed class MySingletonClass2
    {
        MySingletonClass2() { Console.WriteLine("实例化"); }

        static MySingletonClass2 _Instance = new MySingletonClass2();

        public static MySingletonClass2 GetSingletionClass()
        {
            return _Instance;
        }
        public void Show()
        {
            Console.WriteLine("hello");
        }
    }
}
