using System;
using static System.Console;

namespace Листинг_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass A = new myClass();
            myClass B = new myClass();
            
            A.number = 123;
            A.symbol = 'A';
            B.number = 123;
            B.symbol = 'B';

            WriteLine("Първи обект");
            A.show();
            WriteLine("Втори обект");
            B.show();

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
    class myClass
    {
        public int number;
        public char symbol;

        public void show()
        {
            WriteLine("Целочислено поле: " + number);
            WriteLine("Символно поле: " + symbol);
        }
    }
}
