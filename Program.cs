using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program //Contador de Vogais
    {
        static void Main(string[] args)
        {
            int vogal = 0;
            char[] caracteres = { 'a', 'e', 'i', 'o', 'u' };
            
            Console.WriteLine("Digite uma palavra: ");

            char[] frase_completa = Console.ReadLine().ToLower().ToCharArray();

            for (int conta = 0; conta < frase_completa.Length; conta++)
            {
                if (caracteres.Contains(frase_completa[conta]))
                {
                    vogal++;
                }
            }
            Console.WriteLine("Total de {0} vogais ", vogal, caracteres[0]);
            Console.Read();

            Console.ReadKey();
        }
        }
}