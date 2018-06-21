using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class Caretaker<T>
    {
        static readonly Dictionary<string, T> dictionary = new Dictionary<string, T>();

        public static void SaveArea(string key, T area)
        {
            dictionary.Add(key, area);
        }

        public static T ResolveArea(string key)
        {
            return dictionary[key];
        }
    }
}
