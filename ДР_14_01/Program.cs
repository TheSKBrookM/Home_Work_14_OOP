using System.Collections.Generic;

namespace ДР_14_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MyList<int> myList = new MyList<int>();
            for (int i = 0; i < 10; i++) 
            {
                myList.Add(i);
            }

            Console.WriteLine($"Array length = {myList.Count}");

            foreach (int item in myList)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}