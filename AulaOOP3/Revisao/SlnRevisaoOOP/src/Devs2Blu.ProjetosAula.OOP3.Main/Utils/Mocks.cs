using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Utils
{
    public class Mocks
    {
        public  List<Paciente> ListaPacientes { get; set; }

        public  List<Medico> ListaMedicos { get; set; }

        public  List<Recepcionista> ListaRecepcionitas { get; set; }

        public  List<Fornecedor> ListaFornecedores { get; set; }

        public Mocks()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
            ListaRecepcionitas = new List<Recepcionista>();
            ListaFornecedores = new List<Fornecedor>();

            CargaMock();
        }

        public void CargaMock()
        {
            CargaPacientes();
            CargaMedicos();
        }

        public void CargaPacientes()
        {
            for (int i = 0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i,$"Paciente {i+1}", $"{i}23{i}56{i}891{i}","Unimed");
                ListaPacientes.Add(paciente);
            }
        }

        public void CargaMedicos()
        {
            Random rd = new Random();
            string [] especialidades = {"OTORRINO","CLÍNICO GERAL","CARDOLOGISTA"};
            
            for (int i = 0; i < 5; i++)
            {
                int crm;
                Medico medico = new Medico(i, $"Medico {i + 1}", $"{i}23{i}56{i}891{i}", rd.Next(1,999), especialidades[rd.Next(0,especialidades.Length)]);
                ListaMedicos.Add(medico);
            }
        }
    }
}
