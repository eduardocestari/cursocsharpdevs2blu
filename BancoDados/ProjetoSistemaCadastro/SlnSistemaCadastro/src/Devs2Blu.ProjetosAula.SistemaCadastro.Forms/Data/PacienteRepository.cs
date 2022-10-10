using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data
{
    public class PacienteRepository
    {
        public Pessoa Save(Pessoa pessoa, Paciente paciente, Convenio convenio)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                pessoa.Id = SavePessoa(pessoa, conn);
                paciente.Id = SavePaciente(paciente, conn, pessoa.Id, convenio.Id);

                return pessoa;

            }
            catch (MySqlException myeExc)
            {
                MessageBox.Show(myeExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;

            }
        }

        private Int32 SavePessoa(Pessoa pessoa, MySqlConnection conn)
        {
           
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PESSOA, conn);
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = pessoa.Nome;
                cmd.Parameters.Add("@cgccpf", MySqlDbType.VarChar, 25).Value = pessoa.CGCCPF;
                cmd.Parameters.Add("@tipopessoa", MySqlDbType.Enum).Value = pessoa.TipoPessoa;
                cmd.ExecuteNonQuery();
                return (Int32)cmd.LastInsertedId;
            }
            catch (MySqlException myeExc)
            {
                MessageBox.Show(myeExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;

            }
       
        }

        private Int32 SavePaciente(Paciente paciente, MySqlConnection conn, Int32 idPessoa, Int32 idConvenio)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PACIENTE, conn);
                cmd.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = idPessoa;
                cmd.Parameters.Add("@id_convenio", MySqlDbType.Int32).Value = idConvenio;
                cmd.Parameters.Add("@numero_prontuario", MySqlDbType.Int32).Value = paciente.NrProntuario;
                cmd.Parameters.Add("@paciente_risco", MySqlDbType.VarChar, 5).Value = paciente.PacienteRisco;

                cmd.ExecuteNonQuery();
                return (Int32)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        internal object GetPessoas()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GRID, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myeExc)
            {
                MessageBox.Show(myeExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;


            }
        }

        public bool Delete(Pessoa pessoa)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_PESSOA, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = pessoa.Id;

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

        public bool DeletePaciente(Pessoa pessoa)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_PACIENTE, conn);
                //cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = ;

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

        public void Update(Pessoa pessoa)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_PESSOA, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = pessoa.Id;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = pessoa.Nome;
                cmd.Parameters.Add("@cgccpf", MySqlDbType.VarChar, 25).Value = pessoa.CGCCPF;
                cmd.Parameters.Add("@tipopessoa", MySqlDbType.Enum).Value = pessoa.TipoPessoa;
                

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void UpdatePaciente(Paciente paciente)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_Paciente, conn);
                //cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = ;

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        #region SQLs
        private const String SQL_INSERT_PESSOA = @"INSERT INTO pessoa
                                                                    (nome,
                                                                    cgccpf,
                                                                    tipopessoa,
                                                                    flstatus)
                                                                    VALUES
                                                                    (@nome,
                                                                    @cgccpf,
                                                                    @tipopessoa,
                                                                    'A')";

                private const String SQL_INSERT_PACIENTE = @"INSERT INTO paciente
                                                                        (id_pessoa,
                                                                        id_convenio,
                                                                        numero_prontuario,
                                                                        paciente_risco,
                                                                        flstatus,
                                                                        flobito)
                                                                        VALUES
                                                                        (@id_pessoa,
                                                                        @id_convenio,
                                                                        @numero_prontuario,
                                                                        @paciente_risco,
                                                                        'A',
                                                                        0)";

        private const String SQL_SELECT_PESSOA = @"Select id, nome, cgccpf, flstatus from pessoa";
        private const String SQL_SELECT_PACIENTE = @"SELECT id_pessoa, id_convenio, numero_prontuario, paciente_risco, flstatus, flobito FROM paciente";
        private const String SQL_SELECT_GRID = @"SELECT p.id as Código, 
	                                                               p.nome Nome, 
                                                                   cgccpf CPF, 
                                                                   p.flstatus Status, 
                                                                   pa.numero_prontuario Prontuário, 
                                                                   pa.paciente_risco as Risco, 
                                                                   (select nome from convenio where id = pa.id_convenio) Convênio, 
                                                                   e.CEP, 
                                                                   Rua, 
                                                                   numero as Número, 
                                                                   Bairro,
                                                                   Cidade, 
                                                                   UF as Estado		
                                                                    FROM pessoa p 
                                                                    LEFT JOIN endereco e ON p.id = e.id_pessoa
                                                                    LEFT JOIN paciente pa ON p.id = pa.id_pessoa";

        private const String SQL_UPDATE_PESSOA = @"UPDATE pessoa
                                                                SET
                                                                nome = @nome,
                                                                cgccpf = @cgccpf,
                                                                tipopessoa = @tipopessoa
                                                                WHERE id = @id;";

        private const String SQL_UPDATE_Paciente = @"UPDATE paciente
                                                                SET
                                                                id_convenio = @convenio,
                                                                WHERE id_pessoa = @id;";
        private const String SQL_DELETE_PACIENTE = @"DELETE FROM paciente WHERE id_pessoa = @id ";
        private const String SQL_DELETE_PESSOA = @"DELETE FROM pessoa WHERE id = @id ";
        #endregion
    }
}
