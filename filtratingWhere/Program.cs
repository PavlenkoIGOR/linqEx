namespace filtratingWhere
{
    // Создадим модель класс для города
    public class City
    {
        public City(string name, long population)
        {
            Name = name;
            Population = population;
        }

        public string Name
        {
            get; set;
        }
        public long Population
        {
            get;
            set;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Добавим Россию с её городами
            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));

            //Выберем города-10миллионники:

            var milionCities = from city in russianCities
                               where city.Population >= 2000000 
                               select city;

            foreach (var item in milionCities)
            {
                Console.WriteLine(item.Name + item.Population);
            }
            Console.ReadKey();
        }
    }
}