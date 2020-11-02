using System;

namespace MyConsoleApp
{
    class A
    {
        private int _a = 4;
        private int _b = 5;

        public int Method()
        {
            return _a + _b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A my_a = new A();
            Console.WriteLine(my_a.Method());
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
