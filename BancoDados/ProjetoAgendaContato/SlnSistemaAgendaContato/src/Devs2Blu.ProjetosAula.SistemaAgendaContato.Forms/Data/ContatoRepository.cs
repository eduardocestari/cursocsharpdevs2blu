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
    public class ContatoRepository
    {
        public static void SaveContato(Contato contato)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {               
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_CONTATO, conn);
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 15).Value = contato.Nome;
                cmd.Parameters.Add("@celular", MySqlDbType.VarChar, 45).Value = contato.Celular;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = contato.Email;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 45).Value = contato.Sigla;


                cmd.ExecuteNonQuery();
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQLs
        private const String SQL_INSERT_CONTATO = @"INSERT INTO contato 
                                                                        (nome,
                                                                        celular,
                                                                        email,
                                                                        uf)
                                                                        VALUES
                                                                        (
                                                                        @nome,
                                                                        @celular,
                                                                        @email,                                                                        
                                                                        @uf)";

        #endregion
    }
}
