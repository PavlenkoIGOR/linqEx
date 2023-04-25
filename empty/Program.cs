//Сделать выборку всех чисел в новую коллекцию, расположив их в ней по возрастанию.

namespace empty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numsList = new List<int[]>()
            {
                new[] {2, 3, 7, 1},
                new[] {45, 17, 88, 0},
                new[] {23, 32, 44, -6}
            };

            var numsList2 = from n in numsList
                            from n2 in n
                            orderby n2
                            select n2;

            foreach (var nt in numsList2)
                Console.Write(nt + " ");
            Console.WriteLine("\n");


            /*-----------------------------или так---------------------------*/
            var orderedNums = numsList
                .SelectMany(s => s) // выбираем элементы
                .OrderBy(s => s); // сортируем

            foreach (var item in orderedNums)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}