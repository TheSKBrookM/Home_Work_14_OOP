using ДР_14_01;

namespace ДР_14_03
{
    internal class Program
    {
        static void Main()
        {
            MyList<int> list = new MyList<int>();

            for (int i = 0; i < 8; i++)
                list.Add(i);

            int[] array = list.GetArray();

            foreach (int item in array)
                Console.Write("{0}  ", item);

            // Delay.
            Console.ReadKey();
        }
    }

    static class StaticClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] array = new T[list.Count()];

            int i = 0;

            foreach (T item in list)
            {
                array[i] = item;
                i++;
            }

            return array;
        }
    }
}