using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modificar para mostrar a e b antes de cada operação. Repor variáveis
            int a = 5;
            int b = -6;
            int c;
            int d;
            int e;
            int f = 0;

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
