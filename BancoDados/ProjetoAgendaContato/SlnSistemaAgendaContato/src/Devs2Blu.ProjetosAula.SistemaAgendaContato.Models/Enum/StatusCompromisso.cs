using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContato.Models.Enum
{
    public enum StatusCompromisso
    {
        [Description("Aberto")]
        A = 0,
        [Description("Inativo")]
        I = 1,
        [Description("Concluído")]
        C = 2,
        [Description("Remarcado")]
        R = 3
    }
}
