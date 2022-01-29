using System;
using static System.Console;

namespace Задача_8
{
    class myClass
    {
        private static int n = 0;
        public void Meth()
        {
            WriteLine(n);
            n++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass();
            obj.Meth();
            obj.Meth();
            obj.Meth();

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
