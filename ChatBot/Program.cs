using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            bool e = false;
            while (e != true)
            {
                Console.WriteLine("Hello, Im ChatBot!");
                // Variáveis auxiliares
                string question, response;

                // Colocar questão ao utilizador
                Console.Write("What's your question? ");
                question = Console.ReadLine();

                // Verificar se se trata de uma questão conhecida e determinar uma
                // resposta adequada
                switch (question)
                {
                    case "How are you?":
                        response = "I'm fine, thank you";
                        break;
                    case "What's your name?":
                        response = "ChatBot.";
                        break;
                    case "What's your mission?":
                        response = "Destroy mankind!";
                        break;
                    case "Who are you?":
                        response = "ChatBot... like I said... minutes ago.";
                        break;
                    case "What are you)":
                        response = "I'm a conversation-bot from #%&/*%& Inc.";
                        break;
                    case "What's your favorite color?":
                        response = "It's beyond your light spectrum perception. Don't bother, Human.";
                        break;
                    case "EXIT":
                        response = "TERMINATION OF CHAT";
                        e = true;
                        break;
                    default:
                        response = "I don't know what you mean.";
                        break;
                }

            }
        }
    }
}
