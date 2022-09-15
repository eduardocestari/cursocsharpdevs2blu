using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            string formatacaoDados = "Inicialização de Variável....\n";
            string nomeUsuario, cidadeUsuario;
                        
            // Entrada de Dados
            
            //Duplicar = Ctrl + D
            Console.Write("Informe seu nome: ");
            nomeUsuario = Console.ReadLine(); 

            Console.Write("Informe sua Cidade: ");
            cidadeUsuario = Console.ReadLine();


            // Processamento

            /* operadora += Concatenação ou Soma de Valores na mesma variável*/
            formatacaoDados += "Seja bem vindo, " + nomeUsuario + "!" + "\n\n";// + "Localidade: " + cidadeUsuario;
            
            formatacaoDados += $"Localidade: {cidadeUsuario}";

            // Apresentação dos dados
            /*Console.WriteLine("Seja bem vindo, " + nomeUsuario + "!");
              Console.WriteLine("Cidade: " + cidadeUsuario);*/
            Console.WriteLine(formatacaoDados);

            
            //Pausa antes de encerrar
            Console.WriteLine("Pressione qualquer tecla para sair...");
            var input = Console.ReadLine();
        }
    }
}
