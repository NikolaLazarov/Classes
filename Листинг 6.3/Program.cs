using System;
using static System.Console;

namespace Листинг_6._3
{
    class myClass
    {
        private int number;
        private char symbol;
        public void show()
        {
            WriteLine("Poletata na obekta: " + number + "и" + symbol);
        }
        public void set(int n, char s)
        {
            number = n;
            symbol = s;
        }
        public void set(int n)
        {
            number = n;
            symbol = 'B';
        }
        public void set()
        {
            set(100, 'A');
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass();
            obj.set();
            obj.show();
            obj.set(200);
            obj.show();
            obj.set(300, 'C');
            obj.show();

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
