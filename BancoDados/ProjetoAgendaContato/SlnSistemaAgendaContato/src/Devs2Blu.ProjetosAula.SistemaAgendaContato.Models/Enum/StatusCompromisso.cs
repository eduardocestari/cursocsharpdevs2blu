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

    public static class EnumHelper
    {
        public static T GetValueFromDescription<T>(string description)
        {
            foreach (var field in typeof(T).GetFields())
            {
                if (Attribute.GetCustomAttribute(field,
                typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }

            throw new ArgumentException("Not found.", nameof(description));
        }
    }
}
