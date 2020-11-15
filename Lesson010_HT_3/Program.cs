using System;

namespace Lesson010_HT_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee("Myroslav","Havrushko");
            Employee employee2 = new Employee("Oleh", "Havrushko");
            Employee employee3 = new Employee("Mykola", "Havrushko");
            Employee employee4 = new Employee("Maria", "Havrushko");
            employee1.GetInfo();
            employee1.Salary(8, "Admin");
            employee2.GetInfo();
            employee2.Salary(20, "Admin");
            employee3.GetInfo();
            employee3.Salary(5, "Teacher");
            employee4.GetInfo();
            employee4.Salary(80, "Teacher");
        }
    }
}
