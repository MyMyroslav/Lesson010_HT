using System;

namespace Lesson010_HT_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Converter converter = new Converter(28, 30, 7);
            converter.GetInfo();
            Console.WriteLine(" ");
            converter.FromHrn(12);
            converter.FromUsd(10233);
            converter.FromEur(5644);
            converter.FromZlt(346);

        }
    }
}
