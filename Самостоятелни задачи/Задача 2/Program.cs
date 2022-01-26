using System;
using static System.Console;

namespace Задача_2
{
    class myClass
    {
        public char a;
        public char b;
        public void Meth()
        {
            char[] chars = new char[254];
            int A = (int)a;
            int B = (int)b;
            chars[A - 1] = a;
            WriteLine(a);
            chars[B - 1] = b;
            for (int i = A + 1; i < B - 1; i++)
            {
                chars[i] = (char)i;
                Write(chars[i] + "\n");
            }
            WriteLine(b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass clas = new myClass();
            clas.a = 'A';
            clas.b = 'Z';
            clas.Meth();

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
