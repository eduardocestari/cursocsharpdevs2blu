using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroFornecedor : IMenuCadastro
    {
        public CadastroFornecedor()
        {
        }
        public Int32 MenuCadastro()
        {
            Int32 opcao;

            Console.Clear();
            Console.WriteLine("Cadastro de Fornecedor \n");
            Console.WriteLine("1 - Lista de Fornecedor");
            Console.WriteLine("2 - Cadastro de Fornecedor");
            Console.WriteLine("3 - Alterar Fornecedor");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("0 - Sair");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;

        }
        public void CadastrarFornecedor(Fornecedor novoFornecedor)
        {
            Program.Mock.ListaFornecedores.Add(novoFornecedor);
        }
        public void Cadastrar()
        {
            Console.Clear();
            Fornecedor fornecedor = new Fornecedor();

            Console.WriteLine("Informe o Nome do Fornecedor");
            fornecedor.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CNPJ");
            fornecedor.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o tipo do Fornecedor");
            fornecedor.TipoFornecedor = Console.ReadLine();

            Random rd = new Random();
            fornecedor.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            fornecedor.CodigoFornecedor = Int32.Parse($"{fornecedor.Codigo}{rd.Next(100, 999)}");

            CadastrarFornecedor(fornecedor);

        }

        public void ListarFornecedor()
        {
            Console.Clear();

            foreach (var fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine($"fornecedor: {fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"Tipo: {fornecedor.TipoFornecedor}");
                Console.WriteLine("------------------");
            }
            Console.ReadLine();
        }
        public void Listar()
        {
            ListarFornecedor();
        }

        private void ListarFornecedoresByCodeAndName()
        {
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.Write($"| {fornecedor.CodigoFornecedor} - {fornecedor.Nome} ");
            }
            Console.WriteLine("\n");
        }
        public void AlterarFornecedor(Fornecedor fornecedor)
        {
            var pact = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == fornecedor.CodigoFornecedor);
            int index = Program.Mock.ListaFornecedores.IndexOf(pact);
            Program.Mock.ListaFornecedores[index] = fornecedor;
        }
        public void Alterar()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;

            Console.WriteLine("Informe o fornecedor que deseja Alterar:\n");
            ListarFornecedoresByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codigoFornecedor);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"recepcionista: {fornecedor.Codigo}/{fornecedor.CodigoFornecedor} | Nome: {fornecedor.Nome} | CPF: {fornecedor.CGCCPF} | Tipo: {fornecedor.TipoFornecedor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CNPJ | 03 Tipo | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CNPJ:");
                        fornecedor.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo Tipo:");
                        fornecedor.TipoFornecedor = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }

                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dado Alterado com Sucesso!");
                }
            } while (alterar);

            AlterarFornecedor(fornecedor);
        }

        private void ExcluirFornecedor(Fornecedor fornecedor)
        {
            Program.Mock.ListaFornecedores.Remove(fornecedor);
        }
        public void Excluir()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;

            Console.WriteLine("Informe o fornecedor que Deseja Excluir:\n");
            ListarFornecedoresByCodeAndName();
            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);
            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codigoFornecedor);

            string opcaoAlterar;

            Console.WriteLine($"Você irá excluir a fornecedor: {fornecedor.CodigoFornecedor} - {fornecedor.Nome} ");
            Console.WriteLine("Digite 01 para confirmar ou 00 para Abortar");
            opcaoAlterar = Console.ReadLine();

            switch (opcaoAlterar)
            {
                case "01":
                    ExcluirFornecedor(fornecedor);
                    Console.WriteLine("Forncedor Excluído com Sucesso!");
                    Console.ReadLine();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Abortado!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
