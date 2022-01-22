using System;
using static System.Console;

namespace Листинг_6._6
{
    class myClass
    {
        public static int code = 100;
        public static void show()
        {
            WriteLine("Statichno  pole" + code);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass.show();
            myClass.code = 200;
            myClass.show();

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
