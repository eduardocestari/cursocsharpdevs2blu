﻿using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroPaciente
    {
        public CadastroPaciente()
        {
        }

        public void MenuCadastro()
        {
            Int32 opcao;

            do
            {
                Console.WriteLine("----- Cadastro de Paciente -----");
                Console.WriteLine("----- 1 - Lista de Paciente ------");
                Console.WriteLine("----- 2 - Cadastro de Paciente -----");
                Console.WriteLine("----- 3 - Alterar Paciente -----");
                Console.WriteLine("---------------------------");
                Console.WriteLine("----- 0 - Sair -----");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarPacientes();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));

        }

        public void ListarPacientes()
        {
            Console.Clear();

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convênio: {paciente.Convenio}");
                Console.WriteLine("--------------------------------------");

            }
        }

        public void CadastrarPaciente()
        {

        }

        public void AlterarPaciente()
        {

        }

        public void ExcluirPaciente()
        {

        }
    }
}
