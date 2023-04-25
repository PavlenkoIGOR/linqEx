
//Выберите всех студентов моложе 27, сгенерируйте из них анкеты (модель класса расположена ниже).

namespace ex14_2_3
{
    class Student
    {
        public string Name;
        public int Age;
        public List<string> Languages;
    }

    public class Application
    {
        public string Name
        {
            get; set;
        }
        public int YearOfBirth
        {
            get; set;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Наш список студентов
            List<Student> students = new List<Student>
            {
                new Student { Name = "Андрей", Age = 23, Languages = new List<string> { "английский", "немецкий" } },
                new Student { Name = "Сергей", Age = 27, Languages = new List<string> { "английский", "французский" } },
                new Student { Name = "Дмитрий", Age = 29, Languages = new List<string> { "английский", "испанский" } },
                new Student { Name = "Василий", Age = 24, Languages = new List<string> { "испанский", "немецкий" } }
            };

            var appStud = students.Where(s => s.Age < 27).Select(s => new Application()
            {
                Name = s.Name,
                YearOfBirth = DateTime.Now.Year - s.Age
            });

            foreach (var newStud in appStud)
            {
                Console.WriteLine($"{newStud.Name}, {newStud.YearOfBirth} года рождения");
            }
            Console.ReadKey();
        }
    }
}