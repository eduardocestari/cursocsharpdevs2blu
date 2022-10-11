using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContato.Forms.Data
{
    public class EstadoRepository
    {
        public MySqlDataReader FetchAll()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            //DataSet dataSet = new DataSet();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_ESTADO, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myeExc)
            {
                MessageBox.Show(myeExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQLs
        private const String SQL_SELECT_ESTADO = "SELECT * FROM ESTADO";
        #endregion

    }

}

