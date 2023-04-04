namespace ДР_14_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new MyDictionary<string, string>(5)
            {
                { 0, "стiл", "table" },
                { 1, "яблуко", "apple" },
                { 2, "олiвець", "pencil" },
                { 3, "сонце", "sun" },
                { 4, "блокнот", "notepad" }
            };

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Другий запис в словнику:");
            Console.WriteLine(dictionary[1]);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Розмiр словника:");
            Console.WriteLine($"{dictionary.Lenght} слiв");

            Console.ReadKey();
        }
    }
}