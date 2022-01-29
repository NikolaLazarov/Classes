using System;

namespace Задача_7
{
    class myClass
    {
        private char x;
        private string y;
        public void Meth(char x)
        {
            this.x = x;
            Console.WriteLine("{0}", this.x);
        }
        public void Meth(string y)
        {
            this.y = y;
            Console.WriteLine("{0}", this.y);
        }
        public void Meth(char[] arrChars)
        {
            y = "";
            if (arrChars.Length > 1)
            {
                arrChars.ToString();
                foreach (char c in arrChars)
                {
                    y += c;
                }
                Console.WriteLine("{0}", y);
            }
            else
            {
                arrChars.ToString();
                y += arrChars[0];
                Console.WriteLine("{0}", y);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
