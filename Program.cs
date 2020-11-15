using System;

namespace Lesson010_HT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            User user1 = new User("20.12.2020");
            user1.login = "MY";
            user1.name = "Myroslav";
            user1.surname = "Havrushko";
            user1.age = 18;
            user1.GetInfo();
            Console.WriteLine($"{user1.login}, {user1.name}, {user1.surname}, {user1.age}");
        }
    }
}
