using System;
namespace Lesson010_HT_3
{
    public class Employee
    {
        public string name;
        public string surname;
        public Employee()
        {
        }
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{name} {surname}");
        }
        public void Salary(int month, string job)
        {
            if (job == "Admin" && month <= 10)
            {
                decimal salary = 9000;
                double pod = 9000 * 0.15;
                Console.WriteLine($"{job} with {month} time of job salary is {salary},and tax {pod}");
            }
            else if (job == "Admin" && month >=11)
            {
                decimal salary = 15000;
                double pod = 15000 * 0.25;
                Console.WriteLine($"{job} with {month} time of job salary is {salary},and tax {pod}");
            }
            if (job == "Teacher" && month <= 10)
            {
                decimal salary = 7000;
                double pod = 9000 * 0.10;
                Console.WriteLine($"{job} with {month} time of job salary is {salary},and tax {pod}");
            }
            else if (job == "Teacher" && month >= 11)
            {
                decimal salary = 13000;
                double pod = 9000 * 0.20;
                Console.WriteLine($"{job} with {month} time of job salary is {salary}, and tax {pod}");
            }

        }
    }
}
