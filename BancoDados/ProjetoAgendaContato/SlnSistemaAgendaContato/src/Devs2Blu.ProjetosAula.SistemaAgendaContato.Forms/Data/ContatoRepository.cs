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

        public void Update(Contato contato)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_CONTATO, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = contato.Id;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = contato.Nome;
                cmd.Parameters.Add("@celular", MySqlDbType.VarChar, 45).Value = contato.Celular;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar, 25).Value = contato.Email;
                cmd.Parameters.Add("@uf", MySqlDbType.Enum).Value = contato.Sigla;


                cmd.ExecuteNonQuery();
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public bool Delete(Contato contato)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_CONTATO, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = contato.Id;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException myExc)
            {
                return false;
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

        private const String SQL_UPDATE_CONTATO = @"UPDATE contato
                                                                SET
                                                                nome = @nome,
                                                                celular = @celular,
                                                                email = @email,
                                                                uf = @uf
                                                                WHERE id = @id;";


        private const String SQL_DELETE_CONTATO = @"DELETE FROM contato WHERE id = @id ";

        #endregion
    }
}
