namespace hwModule19
{
    class User
    {
        public string _name;
        public string _lastName;
        public string _password;
        public string _eMail;

        public User(string name, string lastName, string password, string eMail)
        {
            _name = name;
            _lastName = lastName;
            _password = password;
            _eMail = eMail;
        }
    }
    public class Users<User>
    {
        //public User[] users;
        public List<User> users = new List<User>();
        public void ShowInfo()
        {
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Users<User> us = new Users<User>();
            us.users.Add(new User("Tom", "Anderson", "password", "qwerty@mail.com"));
            us.users.Add(new User("John", "Jefferson", "psswrd", "ASD@mail.com"));
            us.users.Add(new User("Lisa", "Ann", "BraZZerS", "prnstr@mail.com"));
            us.users.Add(new User("Sienna", "East", "twystis", "sprMilf@mail.com"));

            foreach (var user in us.users)
            {
                Console.WriteLine(user._name + " " +
                    user._lastName + " " + 
                    user._eMail + " " + 
                    user._password);
            }

            
            Console.WriteLine("Добавление нового пользователя: ");
            Console.Write("Имя нового пользователя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Фамилия нового пользователя: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Пароль нового пользователя: ");
            string passw = Console.ReadLine();
            Console.WriteLine("е-Почта нового пользователя: ");
            string eMail = Console.ReadLine();
            User newUser = new User(name, lastName, passw, eMail);

            foreach (var user in us.users)
            {
                if (user._eMail != newUser._eMail)
                {
                    us.users.Add(newUser);
                    break;
                }
            }
            Console.WriteLine("----------------new list----------------");
            foreach (var user in us.users)
            {
                Console.WriteLine(user._name + " " +
                    user._lastName + " " +
                    user._eMail + " " +
                    user._password);
            }


            Console.ReadKey();
        }
    }
}