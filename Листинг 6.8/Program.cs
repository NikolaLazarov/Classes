using System;
using static System.Console;

namespace Листинг_6._8
{
    class myClass
    {
        private int code;
        public int get()
        {
            return this.code;
        }
        public void set(int code)
        {
            this.code = code;
        }
        public myClass(int code)
        {
            this.code = code;
            WriteLine("Suzdaden e obektat: " + this.get());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass(100);
            obj.set(200);
            WriteLine("Nova stoinost: " + obj.get());

            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
    }
}
