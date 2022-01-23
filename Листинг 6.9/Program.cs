using System;
using static System.Console;

namespace Листинг_6._9
{
    class myClass{
        public int alpha;
        public int bravo;
        public myClass(int a){
            WriteLine("Konstruktor s edin argument");
            alpha = a;
            bravo=alpha;
            WriteLine("I poleta sa ravni na"+alpha);
        }
        public myClass(int a, int b):this(a){
            WriteLine("Konstruktor s dva argomenta");
            bravo = b;
            WriteLine("Poleta"+alpha+"i"+bravo);
        }
        public myClass():this(400,500){
            WriteLine("Konstruktor bez argomenti");
            WriteLine("Stoinost"+alpha+"i"+bravo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass A = new myClass(100);
            WriteLine();

            myClass B  = new myClass(200,300);
            WriteLine();

            myClass C = new myClass();
            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
    }
}
