//Сделать выборку тех, которые производят мобильную технику. 

namespace SelectMany_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, string[]>();

            companies.Add("Apple", new[] { "Mobile", "Desktop" });
            companies.Add("Samsung", new[] { "Mobile" });
            companies.Add("IBM", new[] { "Desktop" });

            var mobileMaking = companies.Where(c => c.Value.Contains("Mobile"));
            foreach (var item in mobileMaking)
            {
                Console.WriteLine(item.Key);
            }


            Console.ReadKey();
        }
    }
}