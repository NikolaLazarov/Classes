using System;
using static System.Console;

namespace Задача_6v2
{
    class myClass{
        private int min = 4;
        private int max = 45;

        public myClass(int x){
            if(x>max){
                min = max;
                max = x;
                WriteLine("Min: " + min);
                WriteLine("Max: " + x);
            }else if(x<min){
                min = x;
                WriteLine("Min: " + x);
                WriteLine("Max: "+ max);
            }
        }
        public myClass(int x, int y){
            if(x>y){
                max = x;
                min = y;
                WriteLine("Min: " + min);
                WriteLine("Max: " + max);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass(65);
            myClass obj1 = new myClass(25);
            myClass obj2 = new myClass(3,7);
            myClass obj3 = new myClass(9,3);
            
            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
