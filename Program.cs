using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Console.WriteLine("Current time is " + DateTime.Now);
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name} " + "\n" + DateTime.Now);
            */
            //first task - #1 of 2: variables initializing
            bool activePeriod = true;
            byte monthInPeriod = 11;
            sbyte bit = -10;
            short balance = -1200;
            ushort positiveBalance = 1200;
            int totalEmployee = 6000;
            uint totalViews = 99;
            long relativeSpeed = -890;
            ulong totalBudget = 500000;
            float sensorIndicator = 5.4f;
            double microWeight = 0.00001;
            decimal length = 2.1m;
            char z = 'z';
            string greating = "Hello";
            object someObject = "Object 1";
            dynamic dynamicVariable = 1;
            
            
            // second task - #2 of 2: operators
            int a = 3;
            int b = 2;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine(a++);
            Console.WriteLine(++a);
            Console.WriteLine(a--);
            Console.WriteLine(--a);
        }
    }
}
