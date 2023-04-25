namespace ex14_2_4
{
    class Student
    {
        public string Name;
        public int Age;
        public List<string> Languages;
    }
    class Coarse
    {
        public string Name;
        public DateTime StartDate;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Список студентов
            var students = new List<Student>
            {
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Иван", Age=22, Languages = new List<string> {"китайский", "немецкий" }},
                new Student {Name="Фома", Age=30, Languages = new List<string> {"арабский", "итальянский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }}
            };

            // Список курсов
            var coarses = new List<Coarse>
            {
                new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
                new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
            };

            var studentsWithCoarses = from stud in students
                                      where stud.Age < 29 // берем всех студентов младше 29
                                      where stud.Languages.Contains("английский") // ищем тех, у кого в списке языков есть английский
                                      let birthYear = DateTime.Now.Year - stud.Age // Вычисляем год рождения
                                      from coarse in coarses
                                      where coarse.Name.Contains("C#") // теперь выбираем только курс по C#
                                      select new // выборка в новую сущность
                                      {
                                          Name = stud.Name,
                                          BirthYear = birthYear,
                                          CoarseName = coarse.Name
                                      };

            foreach (var item in studentsWithCoarses)
            {
                Console.WriteLine(item.Name + ", " + item.CoarseName);
            }

            Console.ReadKey();
        }
    }
}