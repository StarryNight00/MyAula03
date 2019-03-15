using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            string nLinhas;
            int n;

            //Pedir num. de linhas ao utilizador
            Console.WriteLine("Quantas linhas?");
            nLinhas = Console.ReadLine();
            n = Convert.ToInt32(nLinhas);
            
            //Ciclo
            for (int i = 0; i < n; i++)
            {
                //Declaração de variáveis
                int esp, ast;

                //Determinar qunts espaços  # n - i - 1
                esp = n - i - 1;

                //Determinar qunts **  # i * 2 + 1 (pascal??)
                ast = i * 2 + 1;

                //Imprimir espaços
                for (int j = 0; j < esp; j++)
                {
                    Console.Write(" ");
                }
                //Imprimir **
                for (int j = 0; j < ast; j++)
                {
                    Console.Write("*");
                }
                
                //Nova linha vazia
                Console.WriteLine(); //altern: Console.Write("\n");
            }
        }
    }
}
