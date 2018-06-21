using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace IteratorPattern
{
    public class IteratorEnumerator<T> : IEnumerator<T>
    {
        public T[] _array { get; set; }

        public IteratorEnumerator(T[] array) => _array = array;

        private int _index { get; set; } = -1;

        public T Current => _array[_index];

        object IEnumerator.Current => this._array[_index];

        public bool MoveNext() => this._array.Length > ++_index;

        public void Reset() => _index = -1;

        public void Dispose() => _array = null;
    }
}
