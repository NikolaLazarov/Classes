using System;
using static System.Console;

namespace Задача_3
{
    class myClass
    {
        private int a;
        private int b;
        public myClass()
        {
            WriteLine("Конструктор без аргоменти.");
        }
        public myClass(int a)
        {
            this.a = a;
            WriteLine("Конструктор с един аргомент. " + this.a);
        }
        public myClass(int a, int b)
        {
            this.a = a;
            this.b = b;
            WriteLine("Конструктор с два аргомента. " + this.a + ", " + this.b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass();
            myClass obj1 = new myClass(7);
            myClass obj2 = new myClass(7, 1);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
