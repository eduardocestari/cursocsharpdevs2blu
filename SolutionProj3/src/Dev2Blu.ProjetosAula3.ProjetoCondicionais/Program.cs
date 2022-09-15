using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev2Blu.ProjetosAula3.ProjetoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Exercicio2Professor2();

        }

        static void Exercicio1()
        {
            int valor1, valor2;
            string textoSaida2;

            Console.Write("Informe o Valor 1: ");
            string valor1STR = Console.ReadLine();
            valor1 = Int16.Parse(valor1STR);
            Console.Write("Informe o Valor 2: ");
            string valor2STR = Console.ReadLine();
            valor2 = Int16.Parse(valor2STR);

            if (valor1 < valor2)
            {
                textoSaida2 = $"Exercicio 1 - (Valor {valor1} é Menor que {valor2})\n";
            }
            else
            {
                textoSaida2 = $"Exercicio 1 - (Valor {valor1} é Maior que {valor2})\n";
            }



            Console.WriteLine(textoSaida2);          
        }
        
        static void Exercicio1Professor()
        {
            int valor1, valor2;

            Console.Write("Informe o Valor 1: ");
            string valor1STR = Console.ReadLine();
            Int32.TryParse(valor1STR, out valor1);  
            Console.Write("Informe o Valor 2: ");
            string valor2STR = Console.ReadLine();
            Int32.TryParse(valor2STR, out valor2);

            if (valor1 > valor2)
            {
                Console.WriteLine($"O primeiro valor é maior! ({valor1})");
            }
            else if (valor2 > valor1)
            {
                Console.WriteLine($"O segundo valor é maior! ({valor2})");
            } else
            {
                Console.WriteLine($"Valores Iguais");
            }

        }

        static void Exercicio2()
        {
            int valor1, valor2, valor3, valor4;

            Console.Write("Programa que verifica qual menor valor entre quatro valores...\n\n");
            Console.Write("Informe o Valor 1: ");
            string valor1STR = Console.ReadLine();
            Int32.TryParse(valor1STR, out valor1);
            Console.Write("Informe o Valor 2: ");
            string valor2STR = Console.ReadLine();
            Int32.TryParse(valor2STR, out valor2);
            Console.Write("Informe o Valor 3: ");
            string valor3STR = Console.ReadLine();
            Int32.TryParse(valor3STR, out valor3);
            Console.Write("Informe o Valor 4: ");
            string valor4STR = Console.ReadLine();
            Int32.TryParse(valor4STR, out valor4);

            if (valor1 < valor2 && valor1 < valor3 && valor1 < valor4)
            {
                Console.WriteLine($"O menor valor é o valor 1 ({valor1})");
            }
            else if (valor2 < valor1 && valor2 < valor3 && valor2 < valor4)
            {
                Console.WriteLine($"O menor valor é o valor 2 ({valor2})");
            }
            else if (valor3 < valor1 && valor3 < valor2 && valor3 < valor4)
            {
                Console.WriteLine($"O menor valor é o valor 3 ({valor3})");
            }
            else if (valor4 < valor1 && valor4 < valor2 && valor4 < valor3)
            {
                Console.WriteLine($"O menor valor é o valor 4 ({valor4})");
            }
            else
            {
                Console.WriteLine($"Um ou Mais Valores Iguais");
            }
        }
        
        static void Exercicio2Professor()
        {
            int valor1, valor2, valor3, valor4;

            Console.Write("Programa que verifica qual menor valor entre quatro valores...\n\n");
            Console.Write("Informe o Valor 1: ");
            string valor1STR = Console.ReadLine();
            Int32.TryParse(valor1STR, out valor1);
            Console.Write("Informe o Valor 2: ");
            string valor2STR = Console.ReadLine();
            Int32.TryParse(valor2STR, out valor2);
            Console.Write("Informe o Valor 3: ");
            string valor3STR = Console.ReadLine();
            Int32.TryParse(valor3STR, out valor3);
            Console.Write("Informe o Valor 4: ");
            string valor4STR = Console.ReadLine();
            Int32.TryParse(valor4STR, out valor4);

            if (valor1 < valor2 && valor1 < valor3 && valor1 < valor4)
            {
                Console.WriteLine($"O menor valor é o valor 1 ({valor1})");
            }
            else if (valor2 < valor3 && valor2 < valor4)
            {
                Console.WriteLine($"O menor valor é o valor 2 ({valor2})");
            }
            else if (valor3 < valor4)
            {
                Console.WriteLine($"O menor valor é o valor 3 ({valor3})");
            }
            else
            {
                Console.WriteLine($"O menor valor é o valor 4 ({valor4})");
            }           

        }
        
        static void Exercicio2Professor2()
        {
            int valor1, valor2, valor3, valor4;
            int menorValor = 999999999;

            Console.Write("Programa que verifica qual menor valor entre quatro valores...\n\n");
            Console.Write("Informe o Valor 1: ");
            string valor1STR = Console.ReadLine();
            Int32.TryParse(valor1STR, out valor1);
            Console.Write("Informe o Valor 2: ");
            string valor2STR = Console.ReadLine();
            Int32.TryParse(valor2STR, out valor2);
            Console.Write("Informe o Valor 3: ");
            string valor3STR = Console.ReadLine();
            Int32.TryParse(valor3STR, out valor3);
            Console.Write("Informe o Valor 4: ");
            string valor4STR = Console.ReadLine();
            Int32.TryParse(valor4STR, out valor4);

            if (valor1 < menorValor)
            {
                menorValor = valor1;
                                  
            } 
            if (valor2 < menorValor){
                menorValor = valor2;
            }
            if (valor3 < menorValor)
            {
                menorValor = valor3;
            }
            if (valor4 < menorValor)
            {
                menorValor = valor4;
            }

            Console.Write($"O menor valor é o {menorValor}\n");

        }
        static void Exemplo1()
        {
            string formatacaoDados, textoSaida;

            string nomeCandidato;
            int idade, nota;

            Console.WriteLine("|***** Bem vindo ao sistema SchoolSystem! ******|\n\n");
            Console.Write("Informe o Nome do Candidato: ");
            nomeCandidato = Console.ReadLine();

            Console.Write("Informe a Idade do Candidato: ");
            string idadeSTR = Console.ReadLine();

            if (idadeSTR.Equals(""))
            {
                Console.WriteLine("Valor inválido para idade!");
                return;
            }
            else
            {
                idade = Int16.Parse(idadeSTR);
            }

            Console.Write("Informe a Nota do Candidato: ");
            string notaSTR = Console.ReadLine();

            if (notaSTR.Equals(""))
            {
                Console.WriteLine("Valor inválido para nota!");
                return;
            }
            else
            {
                nota = Int16.Parse(notaSTR);
            }

            textoSaida = $"\nCandidato: {nomeCandidato}\n";
            textoSaida += $"Idade: {idade} ";

            if (idade < 18)
            {
                textoSaida += "(Menor de Idade)\n";

            }
            else
            {
                textoSaida += "(Maior de Idade)\n";
            }

            textoSaida += $"Nota Final: {nota}\n";

            if (nota >= 6)
            {
                textoSaida += @"*****************
*** Aprovado! ***
*****************";

            }
            else
            {
                textoSaida += "|---- Reprovado Estude Mais :( -----|";
            }


            Console.WriteLine(textoSaida);
            //formatacaoDados += "Seja bem vindo " + nome + "!" + "\nSua cidade é: " + cidade;
            //formatacaoDados += $"Seja bem vindo {nomeCandidato}, Localidade: ";
            ///Console.WriteLine(formatacaoDados);
        }

    }
}
