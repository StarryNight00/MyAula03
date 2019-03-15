using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar vars
            string s, cStr;
            char c;
            //Pedir input (string) user
            Console.WriteLine("Insira uma frase:");
            s = Console.ReadLine();
            //Pedir char user
            Console.WriteLine("\nInsira um caracter:");
            cStr = Console.ReadLine();

            //Convert String in char
            c = cStr[0];

            //Percorrer String
            foreach(char cInStr in s){
                //se char atual != char user -- imprimir char
                //String - Char
                if (cInStr != c)
                {
                    //Imprimir result                
                    Console.Write(cInStr);
                }

            }

            Console.WriteLine();


        }
    }
}
