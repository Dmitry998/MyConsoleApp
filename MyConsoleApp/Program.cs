using System;

namespace MyConsoleApp
{
    delegate void Output();
    class A
    {
        Output output;

        public Output Output { get { return output; } set { output = value; } }
        public A(Output output)
        {
            this.output = output;
        }

        public void Method()
        {
            output.Invoke();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A my_a = new A(Message);
            my_a.Method();
            my_a.Output = Message2;
            my_a.Method();
            Console.Read();

            void Message()
            {
                Console.WriteLine("Так");
            }
            void Message2()
            {
                Console.WriteLine("Сяк");
            }
        }
    }
}
