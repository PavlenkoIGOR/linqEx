//Сделайте выборку в анонимный тип с одновременной сортировкой слов по длине. Результат выведите в консоль.

namespace ex14_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

            var animals = words.Select(x => new
            {                                       //здесь задаются параметры, которые занесутся в новый тип, по которым далее можно работать
                Name = x,                           // к примеру
                Length = x.Length                   //параметр Length - без него не отсортировать (в OrderBy)
            }).OrderBy(x => x.Length);

            foreach (var item in animals)
            {
                Console.WriteLine(item.Name + " " + item.Length + " символов");
            }
            Console.ReadKey();
        }
    }
}