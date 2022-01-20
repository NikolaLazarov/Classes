using System;
using static System.Console;

namespace Листинг_6._2
{
    class myClass{
        public int number;
        public void show(){
            WriteLine("Стойност на полето: "+number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass A,B;
            A = new myClass();
            B = A;

            A.number=123;
            B.show();
            B.number=321;
            A.show();
            
            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
