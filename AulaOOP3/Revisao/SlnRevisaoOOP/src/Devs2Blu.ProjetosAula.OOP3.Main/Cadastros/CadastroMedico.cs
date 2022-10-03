using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroMedico : IMenuCadastro
    {
        public CadastroMedico()
        {
        }
        public Int32 MenuCadastro()
        {
            Int32 opcao;

            Console.Clear();
            Console.WriteLine("Cadastro de Medicos \n");
            Console.WriteLine("1 - Lista de Medicos");
            Console.WriteLine("2 - Cadastro de Medicos");
            Console.WriteLine("3 - Alterar Medicos");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("0 - Sair");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;

        }
        public void CadastrarMedico(Medico novoMedico)
        {
            Program.Mock.ListaMedicos.Add(novoMedico);
        }
        public void Cadastrar()
        {
            Console.Clear();
            Medico medico = new Medico();

            Console.WriteLine("Informe o Nome do Medico");
            medico.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do Medico");
            medico.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o CRM do Medico");
            medico.CRM = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe a especialidade do Médico");
            medico.Especialidade = Console.ReadLine();


            Random rd = new Random();
            medico.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            medico.CodigoMedico = Int32.Parse($"{medico.Codigo}{rd.Next(100, 999)}");

            CadastrarMedico(medico);

        }

        public void ListarMedico()
        {
            Console.Clear();

            foreach (var medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine($"Medico: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine("------------------");
            }
            Console.ReadLine();
        }
        public void Listar()
        {
            ListarMedico();
        }

        private void ListarMedicosByCodeAndName()
        {
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.Write($"| {medico.CodigoMedico} - {medico.Nome} ");
            }
            Console.WriteLine("\n");
        }
        public void AlterarMedico(Medico medico)
        {
            var pact = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == medico.CodigoMedico);
            int index = Program.Mock.ListaMedicos.IndexOf(pact);
            Program.Mock.ListaMedicos[index] = medico;
        }
        public void Alterar()
        {
            Console.Clear();
            Medico medico;
            int codigoMedico;

            Console.WriteLine("Informe o Medico que Deseja Alterar:\n");
            ListarMedicosByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            medico = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == codigoMedico);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Medico: {medico.Codigo}/{medico.CodigoMedico} | Nome: {medico.Nome} | CPF: {medico.CGCCPF} | CRM: {medico.CRM} | Especialidade: {medico.Especialidade}\"");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 CRM | 04 Especilidade | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        medico.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        medico.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo CRM:");
                        medico.CRM = Int32.Parse(Console.ReadLine());
                        break;
                    case "04":
                        Console.WriteLine("Informe uma nova especialidade:");
                        medico.Especialidade = Console.ReadLine();
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

            AlterarMedico(medico);
        }

        private void ExcluirMedico(Medico medico)
        {
            Program.Mock.ListaMedicos.Remove(medico);
        }
        public void Excluir()
        {
            Console.Clear();
            Medico medico;
            int codigoMedico;

            Console.WriteLine("Informe o Medico que Deseja Excluir:\n");
            ListarMedicosByCodeAndName();
            Int32.TryParse(Console.ReadLine(), out codigoMedico);
            medico = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == codigoMedico);

            string opcaoAlterar;

            Console.WriteLine($"Você irá excluir o médico: {medico.CodigoMedico} - {medico.Nome} ");
            Console.WriteLine("Digite 01 para confirmar ou 00 para Abortar");
            opcaoAlterar = Console.ReadLine();

            switch (opcaoAlterar)
            {
                case "01":
                    ExcluirMedico(medico);
                    Console.WriteLine("Medico Excluído com Sucesso!");
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
