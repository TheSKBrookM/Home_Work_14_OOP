using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДР_14_02
{

    internal class MyDictionary<TKey, TValue> : IEnumerable<object>, IEnumerator<object>
    {
        private readonly TKey[] key;
        private readonly TValue[] value;
        private readonly int lenght;

        private int position = -1;

        public int Lenght { get { return lenght; } }

        public MyDictionary(int n)
        {
            key = new TKey[n];
            value = new TValue[n];
            lenght = n;
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                {
                    return key[index] + " - " + value[index];
                }
                return "Out of Array Length.";
            }
        }

        public void Add(int i, TKey k, TValue v)
        {
            key[i] = k;
            value[i] = v;
        }

        public object Current
        {
            get { return key[position] + " " + value[position]; }
        }

        object IEnumerator.Current
        {
            get { return key[position] + " " + value[position]; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public IEnumerator<object> GetEnumerator()
        {
            return this;
        }

        bool IEnumerator.MoveNext()
        {
            if (position < key.Length - 1)
            {
                position++;
                return true;
            }
            
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            Reset();
        }
    }
}
