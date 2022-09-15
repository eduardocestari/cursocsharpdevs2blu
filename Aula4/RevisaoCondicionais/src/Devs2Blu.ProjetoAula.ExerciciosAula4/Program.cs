using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetoAula.ExerciciosAula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio3();       
            //Exercicio4();
            //Exemplo3();
            //Exercicio5();
            //Exercicio6();
            //Exemplo4();
            Exercicio7();
        }

        static void Exercicio3()
        {
            int numero;
            Random rd = new Random();
            numero = rd.Next(1, 100);

            Console.WriteLine("Exercicio 3\n");
            Console.WriteLine($"Número: {numero}");

            if (!(numero - numero/2*2 == 0))
            {
                Console.WriteLine($"O número é impar");
            } else
            {
                Console.WriteLine($"O número é par");
            }

        }

        static void Exercicio4()
        {           
            int codigo;
            Random rd = new Random();
            codigo = rd.Next(1, 5);

            Console.WriteLine("\nExercicio 4\n");
            Console.WriteLine($"codigo = {codigo}");
            
            if (codigo == 1)
            {
                Console.WriteLine($"O código {codigo} é Arroz");
            }
            else if (codigo == 2)
            {
                Console.WriteLine($"O código {codigo} é Feijão");
            }
            else if (codigo == 3)
            {
                Console.WriteLine($"O código {codigo} é Farinha");
            }
            else
            {
                Console.WriteLine($"O código {codigo} é Diversos");
            }

        }

        static void Exemplo3()
        {
            int idade;
            bool permissao;
            string nome;

            Console.WriteLine("\nExemplo 3\n");
            Console.WriteLine("Informe seu Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Informe sua Idade");
            string inputIdade = Console.ReadLine();
            Int32.TryParse(inputIdade, out idade);

            permissao = (idade >= 18) ? true : false;

            if (permissao)
            {
                Console.WriteLine($"Seja bem-vindo(a), {nome} (+18)");
            } else
            {
                Console.WriteLine($"Você não pode entrar, {nome} (-18)");
            }         

        }

        static void Exercicio5()
        {
            int anoNascimento, idade;
            bool permissao;
            
            Console.WriteLine("\nExercicio 5\n");
            Console.WriteLine("Informe o Ano de Nascimento:");
            string inputAno = Console.ReadLine();
            Int32.TryParse(inputAno, out anoNascimento);

            idade = DateTime.Today.Year - anoNascimento;

            permissao = (idade >= 16) ? true : false;

            if (permissao)
            {
                Console.WriteLine($"Você poderá Votar, sua idade {idade}");
            }
            else
            {
                Console.WriteLine($"Você não poderá Votar, sua idade {idade}");
            }

        }

        static void Exercicio6()
        {
            string senha;
            const string SENHA_ACESSO = "1234";
            bool permissao;

            Console.WriteLine("\nExercicio 6\n");
            Console.WriteLine("Informe sua senha:");           
            senha = Console.ReadLine();

            permissao = senha.Equals(SENHA_ACESSO) ? true : false;

            if (permissao)
            {
                Console.WriteLine($"Acesso Permitido");
            }
            else
            {
                Console.WriteLine($"Acesso Negado");
            }

        }

        static void Exemplo4()
        {
            int idade, tempoTrabalho;
            bool permissao;
            Random rd = new Random();

            idade = rd.Next(50, 80);
            tempoTrabalho = rd.Next(15, 40);


            Console.WriteLine("\nExemplo 4\n");
            Console.WriteLine($"Idade {idade} com {tempoTrabalho} anos trabalhando\n");


            permissao = ((idade > 65) || (tempoTrabalho > 25)) ? true : false;

            //if ((idade > 65) || (tempoTrabalho > 25))
            if(permissao)
            {
                Console.WriteLine($"Pessoa pode ser aposentar");
            }
            else
            {
                Console.WriteLine($"Trabalhe Mais");
            }

        }

        static void Exercicio7()
        {
            int qtdMacas = 0;
            double valorTotal;


            Console.WriteLine("\nExercicio 7\n");
            Console.WriteLine("Qual a quantidade de maças desejadas");
            string inputQtd = Console.ReadLine();
            Int32.TryParse(inputQtd, out qtdMacas);


            if (qtdMacas < 12)
            {
                valorTotal =  qtdMacas * 0.30;           
                
            }
            else
            {
                valorTotal = qtdMacas * 0.25;
            }

            Console.WriteLine($"Você comprou {qtdMacas} e  o valor total ficou R${valorTotal} Reais");

        }
    }
}
