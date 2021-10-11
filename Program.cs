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
            int c = 5;
            // Arithmetic operators
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine(a++);
            Console.WriteLine(++a);
            Console.WriteLine(a--);
            Console.WriteLine(--a);
            
            // Comparison operators
            if (a >= b)
            // if (a <= b)
            // if (a != b)
            // if (a == b)
            // if (a < b)
            // if (a > b)
            // if (a != b)
            {
                Console.WriteLine($"Variable A is winner. The score is {a}");
            }
            else
            {
                Console.WriteLine("Next attempt");
            }
            
            // Logical operators
            if (a != b & a < c)
            // if (a ^ b)
            // if (a > b | a > c)
            // if (a > b && a < c)
            // if (a > b || a > c)
            {
                Console.WriteLine("Some action if condition returns true");
            }
            else
            {
                Console.WriteLine("Some action if condition returns false");
            }
            
            // Bitwise operators
            uint e = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
            uint f = ~e;
            Console.WriteLine(Convert.ToString(f, toBase: 2));
            
            
            uint g = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
            Console.WriteLine($"Before: {Convert.ToString(g, toBase: 2)}");

            uint h = g << 4;
            Console.WriteLine($"After:  {Convert.ToString(h, toBase: 2)}");
            
            // Equality operators
            int k = 1 + 2 + 3;
            int l = 6;
            Console.WriteLine(k == l);
            
            string s1 = "hello!";
            string s2 = "HeLLo!";
            Console.WriteLine(s1 == s2.ToLower());
            
            // Lambda expressions
            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
            greet("World");
            
            // Type-testing operators
            string someCoolString = "abc";
            Console.WriteLine(someCoolString is string);

            int q = 3;
            object r = 4;
            if (q is int && r is int)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Not ok");
            }
            
            // 'as' operator
            A objA = new A();
            B objB = new B();
            C objC = new C();
            objB = objA as B;

            if(objB == null)
            {
                Console.WriteLine("cannot cast objA to type B");
            }
            else
            {
                Console.WriteLine("I can cast objA to type B");
            }

            if (objB == null)
            {
                Console.WriteLine("cannot cast objA to type B");
            }
            else
            {
                Console.WriteLine("I can cast objA to type B");
            }
            
            double s = 1234.7;
            int t = (int)s;
            Console.WriteLine(t);
            
            // ternary operator
            string ScoreEvaluation(double scorePoints) => scorePoints < 10.0 ? "Bad." : "Cool";

            Console.WriteLine(ScoreEvaluation(15));
        }
    }
    class A
    {
        public int a;
    }
    class B : A
    {
        public int b;
    }
    
    class C: B
    {
        public int c;
    }
}
