using Devs2Blu.ProjetosAula.SistemaAgendaContato.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContato.Forms.Data
{
    public class CompromissoRepository
    {

        public static void SaveCompromisso(Compromisso compromisso)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_COMPROMISSO, conn);
                cmd.Parameters.Add("@id_contato", MySqlDbType.Int32).Value = compromisso.Contato.Id;
                cmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 45).Value = compromisso.Titulo;
                cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = compromisso.Descricao;
                cmd.Parameters.Add("@dataini", MySqlDbType.DateTime).Value = compromisso.dataini;
                cmd.Parameters.Add("@datafim", MySqlDbType.DateTime).Value = compromisso.datafim;
                cmd.Parameters.Add("@status", MySqlDbType.VarChar, 45).Value = compromisso.Status;


                cmd.ExecuteNonQuery();
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void Update(Compromisso compromisso)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_COMPROMISSO, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = compromisso.Id;
                cmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 45).Value = compromisso.Titulo;
                cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = compromisso.Descricao;
                cmd.Parameters.Add("@dataini", MySqlDbType.DateTime).Value = compromisso.dataini;
                cmd.Parameters.Add("@datafim", MySqlDbType.DateTime).Value = compromisso.datafim;
                cmd.Parameters.Add("@status", MySqlDbType.VarChar, 45).Value = compromisso.Status;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQLs
        private const String SQL_INSERT_COMPROMISSO = @"INSERT INTO compromisso 
(id_contato,
titulo,
descricao,
dataini,
datafim,
status)
VALUES
(
@id_contato,
@titulo,
@descricao,
@dataini,                                                                        
@datafim,
@status)";

        private const String SQL_UPDATE_COMPROMISSO = @"UPDATE compromisso set 
titulo = @titulo,
descricao = @descricao,
dataini = @dataini,
datafim = @datafim,
status = @status
where id = @id";
        #endregion
    }
}
