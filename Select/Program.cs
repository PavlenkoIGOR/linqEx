

namespace Select
{
    class Student
    {
        public string Name;
        public int Age;
        public List<string> Languages;
    }
    class Application
    {
        public string FirstName;
        public int YearOfBirth;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Подготовим данные
            List<Student> students = new List<Student>
            {
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            var names = from s in students select s.Name; //В данном случае мы спроецировали сущности класса Student в
                                                          //новый тип — в строки, сохранив туда значения свойства Name.
            // Выведем результат
            foreach (var name in names)
                Console.WriteLine(name);


            /*--------------------------------------------или так------------------------------------------*/
            Console.WriteLine("--------------------------------------------или так---------------------------------------------");
            var studentApplications1 = from s in students
                                          // создадим анонимный тип для представления анкеты
                                      select new
                                      {
                                          FirstName = s.Name,
                                          YearOfBirth = DateTime.Now.Year - s.Age,
                                          AnotherData = "какой-то новый параметр"   //но этот параметр будет повторятся с каждой итерацией в foreach
                                      };

            foreach (var name in studentApplications1)
                //Console.WriteLine($"{name}"); // для сравнения
                Console.WriteLine(name.FirstName + " " + name.YearOfBirth + " " + name.AnotherData);
            /*--------------------------------------------или так------------------------------------------*/
            Console.WriteLine("--------------------------------------------проекция в анонимный тип---------------------------------------------");
            // проекция в анонимный тип
            var studentApplications = from s in students
                                          // спроецируем в новую сущеность анкеты (другой тип)
                                      select new Application
                                      {
                                          FirstName = s.Name,
                                          YearOfBirth = DateTime.Now.Year - s.Age
                                      };
            // Выведем результат
            foreach (var application in studentApplications)
                Console.WriteLine($"{application.FirstName}, {application.YearOfBirth}");


            //
            // проекция в анонимный тип
            Console.WriteLine("--------------------------------проекция в анонимный тип при помощи расширения-----------------------------------");
            var applications = students.Select(u => new
            {
                FirstName = u.Name,
                YearOfBirth = DateTime.Now.Year - u.Age
            });
            foreach (var application in applications)
                Console.WriteLine($"{application.FirstName}, {application.YearOfBirth}");

            ///или так при помощи методов расширения
            ///// проекция в другой тип
            Console.WriteLine("---------------------------------проекция в другой тип при помощи расширения-------------------------------------");
            var applications1 = students.Select(u => new Application
            {
                FirstName = u.Name,
                YearOfBirth = DateTime.Now.Year - u.Age
            });
            // Выведем результат
            foreach (var application in applications1)
                Console.WriteLine($"{application.FirstName}, {application.YearOfBirth}");
            Console.ReadKey();
        }
    }
}