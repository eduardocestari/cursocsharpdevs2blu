using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContato.Models.Model
{
    public class Contato
    {
        public Int32 Id { get; set; }
        public Contato contato { get; set; }    
        public Estado Sigla { get; set; }
        public String Nome { get; set; }
        public String Celular { get; set; }
        public String Email { get; set; }


        public Contato()
        {

        }

        public Contato(int id, Contato contato, Estado sigla, string nome, string celular, string email)
        {
            Id = id;
            this.contato = contato;
            Sigla = sigla;
            Nome = nome;
            Celular = celular;
            Email = email;
        }
    }
}
