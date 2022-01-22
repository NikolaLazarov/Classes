using System;
using static System.Console;

namespace Лиситнг_6._4
{
    class myClass{
        private int num;
        private char sym;
        private string txt;
        public void show(){
            WriteLine("Poleta: {0},\'{1}\' i \"{2}\"",num,sym,txt);
        }
        public  myClass(){
            num=100;
            sym='A';
            txt="cherven";
        }
        public myClass(int n){
            num = n;
            sym = 'B';
            txt="kafqv";
        }
        public myClass(int n,char s){
            num = n;
            sym  =  s;
            txt = "cheren";
        }
        public myClass(int n,char s,string t){
            num =n;
            sym=s;
            txt  = t;
        }
        public myClass(string t){
            num = 0;
            sym = 'Z';
            txt = t;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass A = new myClass();
            A.show();

            myClass B  = new myClass(200);
            B.show();

            myClass C  = new myClass(300,'C');
            C.show();

            myClass D  =  new myClass(400,'D',"Lilavo");
            D.show();

            myClass E = new myClass('A');
            E.show();

            myClass F = new myClass("Siv");
            F.show();
            
            
            WriteLine("Press any key to close...");
            ReadKey(true); 
        }
    }
}
