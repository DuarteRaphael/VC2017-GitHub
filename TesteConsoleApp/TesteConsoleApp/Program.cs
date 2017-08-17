using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mensagem exibida na tela.
            Console.WriteLine("Exemplo de uso do GitHub");

            //Adicionando título ao console application (Primeira alteração)
            //testando commit / changes
            Console.Title = "Exemplo do GitHub";

            //aguardar uma tecla ser pressionada.
            Console.ReadKey();
        }
    }
}
