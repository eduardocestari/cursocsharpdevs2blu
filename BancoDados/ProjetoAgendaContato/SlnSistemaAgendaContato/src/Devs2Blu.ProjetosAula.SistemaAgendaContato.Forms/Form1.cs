using Devs2Blu.ProjetosAula.SistemaAgendaContato.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaAgendaContato.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContato.Forms
{
    public partial class FormAgendaContato : Form
    {

        public MySqlConnection Conn { get; set; }
        public EstadoRepository EstadoRepository = new EstadoRepository();
        public ContatoRepository ContatoRepository = new ContatoRepository();

        public FormAgendaContato()
        {
            InitializeComponent();
        }

        private void FormContato_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            PopulaComboEstado();
            PopulaDataGrid();
        }

        private void PopulaComboEstado()
        {
            var listEstado = EstadoRepository.FetchAll();
            cboEstado.DataSource = new BindingSource(listEstado, null);
            cboEstado.DisplayMember = "nome";
            cboEstado.ValueMember = "sigla";
        }

        public object GetCompromissos()
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

        private const String SQL_SELECT_GRID = @"select id Código, Nome, Celular, email 'E-mail', UF from contato";

        private void PopulaDataGrid()
        {
            var listCompromissos = GetCompromissos();
            gridCompromissos.DataSource = new BindingSource(listCompromissos, null);

        }

        private void btnSalvarContato_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.Nome = txtNome.Text;
            contato.Celular = txtCelular.Text;
            contato.Email = txtEmail.Text;
            contato.Sigla = (string)cboEstado.SelectedValue;
            ContatoRepository.SaveContato(contato);
            PopulaDataGrid();
        }
    }
}
