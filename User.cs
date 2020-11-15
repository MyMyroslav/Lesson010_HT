using System;
namespace Lesson010_HT
{
    public class User
    {
        public string login { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        private string data;
        
        public User()
        {
        }
        public User(string data)
        {
            this.data = data;   
        }
        public void GetInfo()
        {
            Console.WriteLine($"Data: {data}");
        }
    }
}
