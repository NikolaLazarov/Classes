using System;
using static System.Console;

namespace Листинг_6._5
{
    class myClass
    {
        private string name;
        public myClass(string txt)
        {
            name = txt;
            WriteLine("Suzdaden e obektat\"{0}\"", name);
        }
        ~myClass()
        {
            Console.WriteLine("Iztrit e obektat\"{0}\"", name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            static void maker(string txt)
            {
                new myClass(txt);
            }

            myClass A = new myClass("Purvi");
            new myClass("Vtori");
            A = new myClass("Treti");
            maker("Chetvurti");
            A = new myClass("Peti");

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
