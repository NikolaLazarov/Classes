using System;
using static System.Console;

namespace Задача_6
{
    class myClass
    {
        private int min = 4;
        private int max = 45;
        public void Meth(int x)
        {
            if (x > max)
            {
                min = max;
                max = x;
                WriteLine("Min: " + min);
                WriteLine("Max: " + x);
            }
            else if (x < min)
            {
                min = x;
                WriteLine("Min: " + x);
                WriteLine("Max: " + max);
            }
        }
        public void Meth(int x, int y)
        {
            if (x > y)
            {
                min = y;
                max = x;
                WriteLine("Min: " + min);
                WriteLine("Max: " + max);
            }
            if (x < y)
            {
                min = x;
                max = y;
                WriteLine("Min: " + min);
                WriteLine("Max: " + max);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass();
            obj.Meth(65);
            obj.Meth(25);
            obj.Meth(3, 9);
            obj.Meth(7, 3);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
