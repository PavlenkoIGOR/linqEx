//Напишите код, который уберет из списка  все японские автомобили.

namespace ex14_2_9
{
    public class Car
    {
        public string Manufacturer
        {
            get; set;
        }
        public string CountryCode
        {
            get; set;
        }
        public Car(string manufacturer, string countryCode)
        {
            Manufacturer = manufacturer;
            CountryCode = countryCode;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Подготовка данных
            var cars = new List<Car>()
            {
                new Car("Suzuki", "JP"),
                new Car("Toyota", "JP"),
                new Car("Opel", "DE"),
                new Car("Kamaz", "RUS"),
                new Car("Lada", "RUS"),
                new Car("Lada", "RUS"),
                new Car("Honda", "JP"),
            };

            Console.WriteLine("Удалим японские машины из списка");
            var notJapanCars = cars.Where(car => !car.CountryCode.Contains("JP"));
            foreach (var item in notJapanCars)
            {
                Console.WriteLine(item.Manufacturer + ", " + item.CountryCode);
            }

            /*---------------------------или так------------------------*/

            Console.WriteLine("*************************************");
            cars.RemoveAll(car => car.CountryCode.Contains("JP"));

            foreach (var item in cars)
            {
                Console.WriteLine(item.CountryCode + ", " + item.Manufacturer);
            }
            
            

            Console.ReadKey();
        }
    }
}