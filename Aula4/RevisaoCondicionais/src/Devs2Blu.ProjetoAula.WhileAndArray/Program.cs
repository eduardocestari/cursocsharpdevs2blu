using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetoAula.WhileAndArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controle = 0;

            do
            {
                Console.WriteLine("\n\nInforme um dos códigos abaixo");
                Console.WriteLine("1 - Exemplo 1 - Do Professor");
                Console.WriteLine("2 - Exemplo 2 - Mostra todos os números ímpares de 1 até 100");
                Console.WriteLine("3 - Exemplo 3 - Mostra todos os números pares de 1 até 100");
                Console.WriteLine("4 - Exemplo 4 - Recebe inteiro e mostra os números pares e ímpares");
                Console.WriteLine("5 - Exemplo 5 - Programa mostra a média, aritmética, da turma.");
                Console.WriteLine("6 - Exemplo 7 - Jogo Acertar o Número");
                Int32.TryParse(Console.ReadLine(), out controle);

                switch (controle)
                {
                    case 1:
                        Exemplo1();
                        break;
                    case 2:
                        Exemplo2();
                        break;
                    case 3:
                        Exemplo3();
                        break;
                    case 4:
                        Exemplo4();
                        break;
                    case 5:
                        Exemplo5();
                        break;
                    case 6:
                        Exemplo6();
                        break;
                }

            } while (controle > 0);
        }

        static void Exemplo1()
        {
            int controle = 1;

            do
            {
                Console.WriteLine("Informe o código 0 para sair");
                Int32.TryParse(Console.ReadLine(), out controle);
            } while (controle > 0);
        }
        
        static void Exemplo2()
        {
            int i = 1;
            Console.Write("Números ímpares: ");
            while (i <= 100)
            {
                int resto = i % 2;               
                if (!resto.Equals(0))
                {
                    Console.Write($"{i} ");
                }
                i++;                
            }          
        }

        static void Exemplo3()
        {
            int i = 1;
            Console.Write("Números pares: ");
            while (i <= 100)
            {
                int resto = i % 2;
                if (resto.Equals(0))
                {
                    Console.Write($"{i} ");
                }
                i++;
            }
        }

        static void Exemplo4()
        {
            int i, controle;
            controle = 1;
            Console.WriteLine("Informe um número");
            Int32.TryParse(Console.ReadLine(), out i);
            Console.WriteLine("\nÍMPARES \tPARES");

            while (controle <= i)
            {
                int resto = controle % 2;
                if (!resto.Equals(0))
                {
                    Console.Write($"{controle}");                  
                }
                else
                {
                    Console.Write($"\t\t{controle}\n");
                }
                controle++;
            }
        }

        static void Exemplo5()
        {

            int qtdAluno, controle;
            double notaAluno, notaSala, mediaTurma;
            controle = 1;
            notaSala = 0;

            Console.Write("Informe a quantidade de alunos na sala: ");
            Int32.TryParse(Console.ReadLine(), out qtdAluno);
                        
            while (controle <= qtdAluno)
            {
                Console.Write($"Informe a nota do aluno {controle}: ");
                Double.TryParse(Console.ReadLine(), out notaAluno);
                notaSala += notaAluno;
                controle++;
            }
            Console.WriteLine($"\nNota Total da Sala é {notaSala}");
            mediaTurma = notaSala / qtdAluno;
            Console.WriteLine($"\nA Média da Turma é {mediaTurma}");
        }
        
        static void Exemplo6()
        {

            Random rd = new Random();
            int numAleatorio, controle, numUser;
            controle = 1;
            numAleatorio = rd.Next(1, 20);

            Console.WriteLine("\nJogo Acerta o Numero");
            Console.WriteLine($"Gerado número aleatório de 1 a 20, tente acerta!!! ----COLA:{numAleatorio}----");
            
            while (controle < 4)
            {
                Console.Write($"\nDigite um número: ");
                Int32.TryParse(Console.ReadLine(), out numUser);
                
                if(numAleatorio.Equals(numUser))
                {
                    Console.WriteLine($"VOCÊ GANHOU, o número gerado era {numUser}");
                    controle = 4;
                }
                else if(controle < 3)
                {
                    int chances = 3 - controle;
                    Console.WriteLine($"Tente outra vez, você tem mais {chances} chances");
                    controle++;
                }
                else controle++;

            }
            Console.WriteLine("\nFIM DE JOGO");
        }
    }
}
