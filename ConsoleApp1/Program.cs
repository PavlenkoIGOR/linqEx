namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>()
{
   1,
   "Сергей ",
   "Андрей ",
   300,
};
            var objects2 = from o in objects
                           where o is string
                           select o;

            foreach (var item in objects2)
            {
                Console.WriteLine( item );
            }

            Console.WriteLine("/*---------------------при помощи метода расширения---------------*/");
            //var collection = objects.Where(o => o is string).OrderBy(o => o);
            //foreach (var stringObject in collection)
            //  Console.WriteLine(stringObject);
            //сокращаем до:
            foreach (var stringObject in objects.Where(o => o is string).OrderBy(o => o))
                Console.WriteLine(stringObject);


            Console.ReadKey();
        }
    }
}