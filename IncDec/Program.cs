using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mudificar para mostrar a e b antes de cada operação
            int a = 5;
            int b = -6;
            int c;
            int d;
            int e;
            int f;

            c = a++ + b++;
            d = ++a - ++b;
            e = a-- + ++b;
            f = --a - --b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("\n\n Resultados");
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
        }
    }
}
