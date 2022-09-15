using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDev2Blu.ProjetosAulas.ProjetoAula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Variáveis
            string nomeAluno;
            int idadeAluno, notaAluno;


            //Entrada de Dados

            Console.WriteLine("|***** Bem vindo ao sistema SchoolSystem! ******|\n\n");
            
            Console.Write("Informe o nome do Aluno: ");
            nomeAluno = Console.ReadLine(); 
            
            Console.Write("Informe a idade do Aluno ");
            string idadeInput = Console.ReadLine();
            if (true)
            {

                idadeAluno = Int16.Parse(Console.ReadLine());
            } 


            
            //Processamento


            //Apresentação de Dados
            //Console.WriteLine(formatacaoDados);

            //Pausa antes de encerrar
            Console.WriteLine("Pressione qualquer tecla para sair...");
            var input = Console.ReadLine();

        }
    }
}
