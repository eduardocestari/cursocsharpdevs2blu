using Devs2Blu.ProjetosAula.SistemaAgendaContato.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContato.Models.Model
{
    public class Compromisso
    {
        public Int32 Id { get; set; }
        public Contato Contato { get; set; }
        public String Titulo { get; set; }
        public String Descricao { get; set; }
        public DateTime dataini { get; set; }
        public DateTime datafim { get; set; }
        public StatusCompromisso Status { get; set; }

        public Compromisso()
        {
            Status = StatusCompromisso.A;
        }

        public Compromisso(int id, Contato contato, string titulo, string descricao, DateTime dataini, DateTime datafim, StatusCompromisso status)
        {
            Id = id;
            this.Contato = contato;
            Titulo = titulo;
            Descricao = descricao;
            this.dataini = dataini;
            this.datafim = datafim;
            Status = status;
        }
    }
}
