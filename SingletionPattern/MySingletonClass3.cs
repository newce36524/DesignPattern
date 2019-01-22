using System;

namespace SingletionPattern
{
    public sealed class MySingletonClass3
    {
        static MySingletonClass3 _Instance;
        MySingletonClass3() { Console.WriteLine("实例化"); }
        static MySingletonClass3()
        {
            _Instance = new MySingletonClass3();
        }
        public static MySingletonClass3 GetSingletionClass()
        {
            return _Instance;
        }
        public void Show()
        {
            Console.WriteLine("hello");
        }
    }
}
