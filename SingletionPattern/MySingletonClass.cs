using System;
using System.Threading;

namespace SingletionPattern
{
    public sealed class MySingletonClass
    {
        MySingletonClass() { Console.WriteLine("实例化"); }

        static MySingletonClass _Instance;
        static object _Locker = new object();
        public static MySingletonClass GetSingletionClass()
        {
            if (_Instance == null)
            {
                lock (_Locker)
                {
                    if (_Instance == null)
                    {
                        _Instance = new MySingletonClass();
                        Volatile.Write(ref _Instance, new MySingletonClass());
                    }
                }
            }
            return _Instance;
        }
        public void Show()
        {
            Console.WriteLine("hello");
        }
    }
}
