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
        public Contato contato { get; set; }    
        public DateTime data { get; set; }
        public String Celular { get; set; }
        public String Status { get; set; }
        public DiasSemana DiasSemana {get; set; }


        public Compromisso()
        {
            Status = "A";
        }
        public Compromisso(int id, Contato contato, DateTime data, string celular, string status, DiasSemana diasSemana)
        {
            Id = id;
            this.contato = contato;
            this.data = data;
            Celular = celular;
            Status = status;
            DiasSemana = diasSemana;
        }
    }
}
