using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Console.WriteLine("Current time is " + DateTime.Now);*/
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();       // вводим имя
            Console.WriteLine($"Привет {name} " + "\n" + DateTime.Now);
            /* Dzima -> myApp comment from git*/
        }
    }
}
