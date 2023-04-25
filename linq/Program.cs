//Есть массив строк:
//string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" }
//Задача: выбрать имена на букву А и отсортировать в алфавитном порядке.

namespace linq
{

    internal class Program
    {
        static void Main(string[] args)
        {
/*
* было
*/
            string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян", "Аланбек"};

            // список, куда будем сохранять выборку
            var orderedList = new List<string>();

            // пробежимся по массиву и добавим искомое в наш список
            foreach (string person in people)
            {
                if (person.ToUpper().StartsWith("А"))
                    orderedList.Add(person);
            }

            // отсортируем список
            orderedList.Sort();
            foreach (string s in orderedList)
                Console.WriteLine(s);
            /*
            *стало  //надо не забывать применять using System.Linq;
            */
            Console.WriteLine("----------------------------1---------------------------");
            string[] people1 = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян", "Аланбек" };

            var selectedPeople = from p in people1 // промежуточная переменная p 
                                 where p.StartsWith("А") // фильтрация по условию
                                 orderby p // сортировка по возрастанию (дефолтная)
                                 select p; // выбираем объект и сохраняем в выборку

            foreach (string s in selectedPeople)
                Console.WriteLine(s);

            /*
            * или вообще так 
            * при помощи методов расширения
            */
            Console.WriteLine("----------------------------2---------------------------");
            string[] people2 = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян", "Аланбек" };

            var selectedPeople2 = people2.Where(p => p.StartsWith("А")).OrderBy(p => p);

            foreach (string s in selectedPeople2)
                Console.WriteLine(s);
            /*
            * а можно и сочетать
            */
            Console.WriteLine("----------------------------3---------------------------");
            string[] people3 = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };

            var selectedPeople3 = (from p in people3 where p.ToUpper().StartsWith("А") orderby p select p).Count();

            Console.WriteLine($"В выборке {selectedPeople3} чел");
            Console.ReadKey();
        }
    }
}