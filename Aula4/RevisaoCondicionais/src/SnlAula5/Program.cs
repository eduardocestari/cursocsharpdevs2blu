using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SnlAula5
{
    internal class Program
    {
        const string A21 = "A21";
        const string A22 = "A22";
        const string A23 = "A23";
        const string A24 = "A24";
        const string A35 = "A35";
        const string Z16 = "Z16";

        const string MACA = "MAÇA";
        const string KIWI = "KIWI";
        const string MELANCIA = "MELANCIA";

        const string HATCH = "HATCH";
        const string SEDAM = "SEDAM";
        const string MOTOCICLETA = "MOTOCICLETA";
        const string CAMINHONETE = "CAMINHONETE";

        const string SOMA = "SOMA";
        const string SUBTRACAO = "SUBTRAÇÃO";
        const string MULTIPLICACAO = "MULTIPLICAÇÃO";
        const string DIVISAO = "DIVISÃO";



        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("\n\nPrograma Aula 5:");
                Console.WriteLine("1 - Exemplo 1");
                Console.WriteLine("2 - Exercicio 1");
                Console.WriteLine("3 - Exercicio 2");
                Console.WriteLine("4 - Exercicio 3");
                Console.WriteLine("5 - Exercicio 5");
                Console.WriteLine("0 - Sair");
                string optStr = Console.ReadLine();
                Int32.TryParse(optStr, out opcao);

                if (opcao == 1)
                {
                    exemplo1();
                }
                else if (opcao == 2)
                {
                    exercicio1();
                }
                else if (opcao == 3)
                {
                    exercicio2();
                }
                else if (opcao == 4)
                {
                    exercicio3();
                }
                else if (opcao == 5)
                {
                    exercicio5();
                }
                else if (opcao == 0)
                {
                    Console.WriteLine("Muito grato. Volte Sempre! =D ");
                }

            } while (opcao != 0);
        }

        static void exemplo1()
        {

            Console.Clear();
            /*
             *  - "A23" : Materiais
                - "A35": Produtos Perecíveis
                - "Z16": Produtos Químicos
             */
            string codigo;

            Console.WriteLine("Escolha um código para ver a descrição");
            Console.WriteLine("- A21");
            Console.WriteLine("- A22");
            Console.WriteLine("- A23");
            Console.WriteLine("- A24");
            Console.WriteLine("- A35");
            Console.WriteLine("- Z16");

            codigo = Console.ReadLine();

            switch (codigo.ToUpper())
            {
                case A21:
                case A22:
                case A23:
                case A24:
                    Console.WriteLine("Materiais.");
                    break;
                case A35:
                    Console.WriteLine("A35: Produtos Perecíveis.");
                    break;
                case Z16:
                    Console.WriteLine("Z16: Produtos Químicos.");
                    break;

                default:
                    Console.WriteLine("Produto Não Cadastrado.");
                    break;
            }
        }

        static void exercicio1()
        {
            Console.Clear();
            string fruta;
            Console.WriteLine("Informe o nome da fruta desejada");
            Console.WriteLine("--- MAÇA, KIWI, MELANCIA ---");
            fruta = Console.ReadLine();

            switch (fruta.ToUpper())
            {
                case MACA:
                    Console.WriteLine("Não vendemos esta fruta aqui");
                    break;
                case KIWI:
                    Console.WriteLine("Estamos com escassez de kiwis");
                    break;
                case MELANCIA:
                    Console.WriteLine("Aqui está, são 3 reais o quilo");
                    break;

                default:
                    Console.WriteLine("Fruta Não Cadastrada");
                    break;
            }
        }

        static void exercicio2()
        {
            Console.Clear();
            string modelo;
            Console.WriteLine("Informe o modelo de carro desejado.");
            Console.WriteLine("--- HATCH, SEDAM, MOTOCICLETA, CAMINHONETE ---");
            modelo = Console.ReadLine();

            switch (modelo.ToUpper())
            {
                case HATCH:
                    Console.WriteLine("Compra efetuada com sucesso");
                    break;
                case SEDAM:
                case MOTOCICLETA:
                case CAMINHONETE:
                    Console.WriteLine("Tem certeza que não prefere este modelo?");
                    break;
                default:
                    Console.WriteLine("Não trabalhamos com este tipo de automóvel aqui");
                    break;
            }
        }

        static void exercicio3()
        {
            Console.Clear();
            string operacao;
            int num1, num2, resultado;
            Console.WriteLine("Informe a operacao desejada.");
            Console.WriteLine("--- SOMA, SUBTRAÇÃO, MULTIPLICAÇÂO, DIVISÃO ---");
            operacao = Console.ReadLine();
            Console.WriteLine("Informe o número 1");
            string inputNum1 = Console.ReadLine();
            Int32.TryParse(inputNum1, out num1);
            Console.WriteLine("Informe o número 2");
            string inputNum2 = Console.ReadLine();
            Int32.TryParse(inputNum2, out num2);

            switch (operacao.ToUpper())
            {
                case SOMA:
                    resultado = num1 + num2;
                    Console.WriteLine($"o resultado da operação soma é {resultado}");
                    break;
                case SUBTRACAO:
                    resultado = num1 - num2;
                    Console.WriteLine($"o resultado da operação subtração é {resultado}");
                    break;
                case MULTIPLICACAO:
                    resultado = num1 * num2;
                    Console.WriteLine($"o resultado da operação multiplicação é {resultado}");
                    break;
                case DIVISAO:
                    resultado = num1 / num2;
                    Console.WriteLine($"o resultado da operação divisão é {resultado}");
                    break;

                default:
                    Console.WriteLine("Operação não encontrada");
                    break;
            }
        }

        static void exercicio5()
        {
            Console.Clear();
            
            int UserNum1, Num1, somaNum, somaNum2, TotalUser, TotalPc;
            Random rd = new Random();

            Console.WriteLine("\nPrimeira Rodada");

            Console.WriteLine("\nRodada do Usuário");
            Console.Write("Informe um número de 1 a 20: ");
            string inputUserNum1 = Console.ReadLine();
            Int32.TryParse(inputUserNum1, out UserNum1);
            Num1 = rd.Next(1, 20);
            Console.WriteLine($"Número aleatório gerado {Num1}");
            somaNum = UserNum1 + Num1;
            Console.WriteLine($"\nSoma dos números do Usuário: {somaNum}");

            Console.WriteLine("\nRodada do Computador");
            Console.Write("Informe um número de 1 a 20: ");
            inputUserNum1 = Console.ReadLine();
            Int32.TryParse(inputUserNum1, out UserNum1);
            Num1 = rd.Next(1, 20);
            Console.WriteLine($"Número aleatório gerado {Num1}");
            somaNum2 = UserNum1 + Num1;          
            Console.WriteLine($"\nSoma dos números do Computador: {somaNum2}\n");

            switch (somaNum)
            {
                case 7:
                    TotalUser = 10;
                    break;
                case 14:
                    TotalUser = 20;
                    break;
                case 21:
                    TotalUser = 30;
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    TotalUser = 1;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    TotalUser = 5;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    TotalUser = 6;
                    break;
                default:
                    TotalUser = 0;
                    break;
            }
            Console.WriteLine($"Usuário ganhou {TotalUser} pontos");

            switch (somaNum2)
            {
                case 7:
                    TotalPc = 10;
                    break;
                case 14:
                    TotalPc = 20;
                    break;
                case 21:
                    TotalPc = 30;
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    TotalPc = 1;

                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    TotalPc = 5;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    TotalPc = 6;
                    break;
                default:
                    TotalPc = 0;
                    break;
            }
            Console.WriteLine($"Computador ganhou {TotalPc} pontos");
        }
    }
}
