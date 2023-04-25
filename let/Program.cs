namespace let
{
    class Student
    {
        public string Name;
        public int Age;
        public List<string> Languages;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Наш список студентов
            List<Student> students = new List<Student>
            {
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };
            var fullNameStudents = from s in students
                                   // временная переменная для генерации полного имени
                                   let fullName = s.Name + " Иванов" + 15 + " ещё что-то"
                                   let price = 143
                                   // проекция в новую сущность с использованием новой переменной
                                   select new
                                   {
                                       Name = fullName,
                                       Age = s.Age,
                                       Price = price
                                   };

            foreach (var stud in fullNameStudents)
                Console.WriteLine(stud.Name + ", " + stud.Age + ", " + stud.Price);
            Console.ReadKey();
        }
    }
}