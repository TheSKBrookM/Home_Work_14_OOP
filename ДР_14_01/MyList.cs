using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДР_14_01
{
    class MyList<T>
    {
        private T[] array = null;
        private int position = -1;

        public MyList() { array = new T[0]; }

        public int Count { get { return array.Length; } }

        public T this[int index] { get { return array[index]; } }

        public void Add(T element)
        {
            T[] array = new T[this.array.Length + 1];
            this.array.CopyTo(array, 0);
            array[this.array.Length] = element;
            this.array = array;
        }

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            while (true)
            {
                if (position < array.Length - 1)
                {
                    position++;
                    yield return array[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }

    }
}
