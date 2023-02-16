using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3._6;

namespace Task_3._6
{
    public class User
    {
        public readonly DateTime date;

        public User(string login, string name, int age, DateTime date)
        {
            Login = login;
            Name = name;
            Age = age;
            this.date = date;
        }
        public string Login{set; get;}
        public string Name { set; get; }
        public int Age { set; get; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("MyLogin", "Dina", 26, DateTime.Now);
            Console.WriteLine(
                $"My login: {user.Login} \nName: {user.Name} \nAge: {user.Age} \nMy account created: {user.date}");
            Console.ReadLine();
        }
    }
}
