using System;
using static System.Console;

namespace Задача_5
{
    class myClass
    {
        public int a;
        public void Meth()
        {
            this.a = 0;
            WriteLine(this.a);
        }
        public void Meth(int a)
        {
            if (a >= 100)
            {
                this.a = 100;
                WriteLine(this.a);
            }
        }
        public myClass()
        {
            this.a = 0;
            WriteLine(this.a);
        }
        public myClass(int a)
        {
            if (a >= 100)
            {
                this.a = 100;
                WriteLine(this.a);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                myClass obj = new myClass();
                obj.Meth();
                obj.Meth(101);
                myClass obj2 = new myClass(101);

                WriteLine("Press any key to close...");
                ReadKey(true);
            }
        }
    }
}

