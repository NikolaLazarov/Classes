using System;
using static System.Console;

namespace Листинг_6._7
{
    class myMath
    {
        public const double Pi = 3.141592;
        private static int N = 100;
        public static double exp(double x)
        {
            double s = 0, q = 1;
            for (int i = 0; i < N; i++)
            {
                s += q;
                q *= x / (i + 1);
            }
            return s;
        }
        public static double sin(double x)
        {
            double s = 0, q = x;
            for (int i = 0; i < N; i++)
            {
                s += q;
                q *= (-1) * x * x / (2 * i + 2) / (2 * i + 3);
            }
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double z = 1;
            WriteLine("sin({0})={1}", z, myMath.exp(z));
            WriteLine("kontrolna stoinost: {0}", Math.Exp(z));
            z = myMath.Pi / 4;
            WriteLine("sin({0})={1}", z, myMath.sin(z));
            WriteLine("kontrolna stoinost: {0}", Math.Sin(z));
            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
    }
}
