using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaDeCasa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcao;
            do
            {
                Console.WriteLine("Seja Bem-vindo\n\n");
                Console.WriteLine("Escolha o programa desejado:");
                Console.WriteLine("1 - Questão 1");
                Console.WriteLine("2 - Questão 2");
                Console.WriteLine("3 - Questão 3");
                Console.WriteLine("4 - Questão 4");
                Console.WriteLine("5 - Questão 5");
                Console.WriteLine("6 - Questão 6");
                Console.WriteLine("7 - Questão 7");
                Console.WriteLine("8 - Questão 8");
                Console.WriteLine("9 - Questão 9");
                Console.WriteLine("10 - Questão 10");
                Console.WriteLine("11 - Questão 11");
                Console.WriteLine("----------------");
                Console.WriteLine("0 - Sair");
                string optStr = Console.ReadLine();
                Int32.TryParse(optStr, out opcao);

                if (opcao == 1)
                {
                    Questao1();
                }
                else if (opcao == 2)
                {
                    Questao2();
                }
                else if (opcao == 3)
                {
                    Questao3();
                }
                else if (opcao == 4)
                {
                    Questao4();
                }
                else if (opcao == 5)
                {
                    Questao5();
                }
                 else if (opcao == 6)
                 {
                     Questao6();
                 }
                else if (opcao == 7)
                {
                    Questao7();
                }
                 else if (opcao == 9)
                 {
                     Questao9();
                 }
                 else if (opcao == 10)
                 {
                     Questao10();
                 }
                 else if (opcao == 11)
                 {
                     Questao11();
                 }
                else if (opcao == 0)
                {
                    Console.WriteLine("Muito grato. Volte Sempre! =D ");
                }
            } while (opcao != 0);

        }

            static void Questao1()
            {
                // Limpa o console
                Console.Clear();
                Console.WriteLine("****** Programa Exemplo 1 ******");
                Console.WriteLine("****** Gerar 2 Números Aleatórios (1 - 100) ******");
                Console.WriteLine("****** Mostrar o maior entre eles ******");

                int numero1, numero2;

                Random rd = new Random();
                numero1 = rd.Next(1, 100);
                numero2 = rd.Next(1, 100);

                Console.WriteLine($"Número 1 = {numero1}");
                Console.WriteLine($"Número 2 = {numero2}");

                if (numero1 > numero2)
                {
                    Console.WriteLine($"Número 1 é o maior. Número 1 = {numero1}");
                }
                else if (numero2 > numero1)
                {
                    Console.WriteLine($"Número 2 é o maior. Número 2 = {numero2}");
                }
                else
                {
                    Console.WriteLine($"Os números são iguais! Números = {numero1}, {numero2}");
                }

            }

            static void Questao2()
            {
            Console.Clear();
            int idade, anoNascimento;

            Console.WriteLine("Informe o ano de seu nascimento:");
            string anoSTR = Console.ReadLine();
            Int32.TryParse(anoSTR, out anoNascimento);

            idade = DateTime.Now.Year - anoNascimento;

            if (idade >= 16)
            {
                Console.WriteLine("Pode Votar!");
            }
            else
            {
                Console.WriteLine("Não pode votar!");
            }
            }

            static void Questao3()
        {
            Console.Clear();
            const string SENHA_SISTEMA = "1234";
            const string MSG_ACESSO_PERM = "Acesso Concedido!";
            const string MSG_ACESSO_NEG = "Acesso Negado!";
            string senhaUsuario;

            Console.WriteLine("Informe a senha para acessar o sistema:");
            senhaUsuario = Console.ReadLine();

            if (senhaUsuario.Equals(SENHA_SISTEMA))
            {
                Console.WriteLine(MSG_ACESSO_PERM);
            }
            else
            {
                Console.WriteLine(MSG_ACESSO_NEG);
            }
        }

            static void Questao4()
        {
            Console.Clear();
            int qtdMacas = 0;
            double valorTotal;

            Console.WriteLine("Informe a quantidade de maças desejadas");
            string inputQtd = Console.ReadLine();
            Int32.TryParse(inputQtd, out qtdMacas);

            if (qtdMacas < 12)
            {
                valorTotal = qtdMacas * 0.30;
            }
            else
            {
                valorTotal = qtdMacas * 0.25;
            }
            Console.WriteLine($"Você comprou {qtdMacas} e  o valor total ficou R${valorTotal} Reais");
        }

            static void Questao5()
        {
            // Limpa o console
            Console.Clear();
            Console.WriteLine("****** Gerar 3 números aleatórios ******");
            Console.WriteLine("****** Escrevê-los em ordem crescente ******");
            int numero1, numero2, numero3;
            string formataSaida = "";

            Random rd = new Random();
            numero1 = rd.Next(1, 100);
            numero2 = rd.Next(1, 100);
            numero3 = rd.Next(1, 100);

            if (numero1 < numero2 && numero1 < numero3)
            {
                formataSaida += $"{numero1}, ";
                if (numero2 < numero3)
                {
                    formataSaida += $"{numero2}, {numero3}";
                }
                else
                {
                    formataSaida += $"{numero3}, {numero2}";
                }
            }
            else if (numero2 < numero1 && numero2 < numero3)
            {
                formataSaida += $"{numero2}, ";
                if (numero1 < numero3)
                {
                    formataSaida += $"{numero1}, {numero3}";
                }
                else
                {
                    formataSaida += $"{numero3}, {numero1}";
                }
            }
            else
            {
                formataSaida += $"{numero3}, ";
                if (numero1 < numero2)
                {
                    formataSaida += $"{numero1}, {numero2}";
                }
                else
                {
                    formataSaida += $"{numero2}, {numero1}";
                }
            }

            Console.WriteLine($"Ordem crescente: {formataSaida}");
        }

            static void Questao6()
            {
            Console.Clear();

            double altura, peso;
            int sexo;
            

            Console.WriteLine("Informe sua Altura:");
            string srtAltura = Console.ReadLine();
            double.TryParse(srtAltura, out altura);
            Console.WriteLine("Informe seu sexo:");
            Console.WriteLine("1 - Feminino");
            Console.WriteLine("2 - Masculino");
            string srtSexo = Console.ReadLine();
            Int32.TryParse(srtSexo, out sexo);
            
            if (!sexo.Equals(1)) {

                peso = (72.7 * altura) - 58;
            } else
            {
                peso = (52.1 * altura) - 44.7;
            }

            Console.WriteLine($"Seu peso ideal é {peso}");


        }

            static int Questao7()
        {
            Console.Clear();
            int numeroLados;
            float comprimentoLado;

            Console.WriteLine("Informe o número de lados: ");
            string srtLados = Console.ReadLine();
            Int32.TryParse(srtLados, out numeroLados);
            Console.WriteLine("Informe a medida do lado em cm: ");
            string srtComprimento = Console.ReadLine();
            float.TryParse(srtComprimento, out comprimentoLado);


            switch (numeroLados)
            {
                case 3:
                    Console.WriteLine($"triângulo, {numeroLados} com comprimento de, {comprimentoLado}");
                    break;
                case 4:
                    Console.WriteLine($"triângulo, {numeroLados} com comprimento de, {comprimentoLado}");
                    break;
                case 5:
                    Console.WriteLine($"pentágono {numeroLados} com comprimento de, {comprimentoLado}");
                    break;
                default:
                    if (numeroLados < 3)
                    {
                        Console.WriteLine("O número de lados informados não formam um polígono! \n");

                    }
                    else
                    {
                        Console.WriteLine("Polígono não identificado! \n");
                    }

                    break;
            }

            return 0;

        }

            static void Questao9()
        {
            // Limpa o Console
            Console.Clear();
            Console.WriteLine("***** Gerar 3 Números Aleatórios (1 - 100) *****");
            Console.WriteLine("***** Mostrar o maior entre eles *****");
            int numero1, numero2, numero3;

            Random rd = new Random();
            numero1 = rd.Next(1, 100);
            numero2 = rd.Next(1, 100);
            numero3 = rd.Next(1, 100);

            Console.WriteLine($"Número 1 = {numero1}.");
            Console.WriteLine($"Número 2 = {numero2}.");
            Console.WriteLine($"Número 3 = {numero3}.");

            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine($"Número 1 é o maior. Numero 1 = {numero1}");
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                Console.WriteLine($"Número 2 é o maior. Numero 2 = {numero2}");
            }
            else if (numero3 > numero1 && numero3 > numero2)
            {
                Console.WriteLine($"Número 3 é o maior. Numero 3 = {numero3}");
            }
        }

            static void Questao10()
        {
            Console.Clear();
            float comprimentoLado1, comprimentoLado2, comprimentoLado3;

            Console.WriteLine("Informe a medida do lado 1: ");
            string srtComprimento1 = Console.ReadLine();
            float.TryParse(srtComprimento1, out comprimentoLado1);

            Console.WriteLine("Informe a medida do lado 2: ");
            string srtComprimento2 = Console.ReadLine();
            float.TryParse(srtComprimento2, out comprimentoLado2);

            Console.WriteLine("Informe a medida do lado 3: ");
            string srtComprimento3 = Console.ReadLine();
            float.TryParse(srtComprimento3, out comprimentoLado3);

            if (comprimentoLado1 == comprimentoLado2 && comprimentoLado1 == comprimentoLado3)
            {
                Console.WriteLine("Equilatero\n");
            }
            else if (comprimentoLado1 == comprimentoLado2 || comprimentoLado1 == comprimentoLado3 || comprimentoLado2 == comprimentoLado3)
            {

                Console.WriteLine("Isosceles\n");
            }
            else
            {
                Console.WriteLine("Escaleno\n");
            }
        }

            static void Questao11()
        {
            Console.Clear();
            float comprimentoLado1, comprimentoLado2, comprimentoLado3;

            Console.WriteLine("Informe a medida do lado 1: ");
            string srtComprimento1 = Console.ReadLine();
            float.TryParse(srtComprimento1, out comprimentoLado1);

            Console.WriteLine("Informe a medida do lado 2: ");
            string srtComprimento2 = Console.ReadLine();
            float.TryParse(srtComprimento2, out comprimentoLado2);

            Console.WriteLine("Informe a medida do lado 3: ");
            string srtComprimento3 = Console.ReadLine();
            float.TryParse(srtComprimento3, out comprimentoLado3);

            if (comprimentoLado1 == 90 || comprimentoLado2 == 90 || comprimentoLado3 == 90)
            {
                Console.WriteLine("Retângulo\n");
            }
            else if (comprimentoLado1 > 90 || comprimentoLado2 > 90 || comprimentoLado3 > 90)
            {

                Console.WriteLine("Obtusângulo\n");
            }
            else
            {
                Console.WriteLine("Acutângulo\n");
            }
        }
    }
}

