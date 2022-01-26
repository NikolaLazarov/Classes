using System;
using static System.Console;

namespace Задача_4
{
    class myClass
    {
        public int a;
        public char b;
        public double c;
        public myClass(double c)
        {
            int b = Convert.ToInt32(c);
            this.b = (char)b;
            WriteLine(this.b);
            double d = b;
            this.a = Convert.ToInt32((c - b) * 100);
            WriteLine(this.a);
        }
        public myClass(int a, char b)
        {
            double d = (int)b;
            double c = a;
            this.c = d + (c / 100);
            WriteLine(this.c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass(89.2323);
            myClass obj2 = new myClass(23, 'Y');

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
