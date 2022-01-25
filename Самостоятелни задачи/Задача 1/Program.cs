using System;
using static System.Console;

namespace Задача_1
{
    class myClass
    {
        private char s;
        public void Meth1(char s)
        {
            this.s = s;
            WriteLine("Символът: " + this.s);
            WriteLine("ASCII код на символа: " + (int)this.s);
            WriteLine($"UNICODE код на символа: \\u{(int)this.s:x4}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Write("Въведете символ: ");
            char s = char.Parse(Console.ReadLine());

            myClass classs = new myClass();
            classs.Meth1(s);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
