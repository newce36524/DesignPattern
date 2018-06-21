using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    public class Iterator<T> : IEnumerable<T>
    {
        public Iterator(T[] array)
        {
            Array = array;
        }

        public T[] Array { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
           return new IteratorEnumerator<T>(Array);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in Array)
            {
                Console.WriteLine("获取元素前");
                yield return item;
                Console.WriteLine("获取元素后");
            }
        }
    }
}
