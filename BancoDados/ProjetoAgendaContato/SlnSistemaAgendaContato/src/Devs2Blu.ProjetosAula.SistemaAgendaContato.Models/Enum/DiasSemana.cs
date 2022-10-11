using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContato.Models.Enum
{
    public enum DiasSemana
    {
        [Description("Segunda Feira")]
        SEG = 0,
        [Description("Terça Feria")]
        TER = 1,
        [Description("Quarta Feira")]
        QUA = 2,
        [Description("Quinta Feira")]
        QUI = 3,
        [Description("Sexta Feira")]
        SEX = 4,
        [Description("Sábado")]
        SAB = 5,
        [Description("Domingo")]
        DOM = 6

    }
}
