using Devs2Blu.ProjetosAula.SistemaAgendaContato.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaAgendaContato.Models.Enum;
using Devs2Blu.ProjetosAula.SistemaAgendaContato.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
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

        public static IList<T> EnumStatusCompromisso<T>()
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T isn't an enumerated type");

            IList<T> list = new List<T>();
            Type type = typeof(T);
            if (type != null)
            {
                Array enumValues = Enum.GetValues(type);
                foreach (T value in enumValues)
                {
                    list.Add(value);
                }
            }
            return list;
        }

        private void LoadStatusCompromisso()
        {

            this.cboStatus.DataSource = EnumStatusCompromisso<StatusCompromisso>();
        }
        private void FormContato_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            PopulaComboEstado();
            LoadStatusCompromisso();
            PopulaDataGrid();
            

        }
        private void PopulaComboEstado()
        {
            var listEstado = EstadoRepository.FetchAll();
            cboEstado.DataSource = new BindingSource(listEstado, null);
            cboEstado.DisplayMember = "nome";
            cboEstado.ValueMember = "sigla";
        }
        public object GetContatos()
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
        public object GetCompromissos()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GRID2, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                return dataReader;
            }
            catch (MySqlException myeExc)
            {
                MessageBox.Show(myeExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;


            }
        }
        public object GetCompromissos2() //INATIVO
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GRID3, conn);
                Contato contato = new Contato();

                cmd.Parameters.Add("@id_contato", MySqlDbType.VarChar, 15).Value = contato.Id;
                MySqlDataReader dataReader = cmd.ExecuteReader();
                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private const String SQL_SELECT_GRID = @"select id Código, Nome, Celular, email 'E-mail', UF 
from contato";
        private const String SQL_SELECT_GRID2 = @"select cp.id 'Código', c.Nome Contato, Titulo 'Título', dataini 'De', datafim 'Até', 
            case Status when 'A' then 'Ativo'
			when 'I' then 'Inativo'
            when 'C' then 'Concluído'
            when 'R' then 'Remarcado' end Status,
            Descricao 'Observação' from compromisso cp, contato c where cp.id_contato = c.id";
        private const String SQL_SELECT_GRID3 = @"select cp.id 'Código', c.Nome Contato, Titulo 'Título', dataini 'De', datafim 'Até', 
            case Status when 'A' then 'Ativo'
			when 'I' then 'Inativo'
            when 'C' then 'Concluído'
            when 'R' then 'Remarcado' end Status,
            Descricao 'Observação' from compromisso cp, contato c where cp.id_contato = c.id
            where id_contato = @id_contato";

        private void PopulaDataGrid()
        {
            var listContatos =  GetContatos();
            gridContato.DataSource = new BindingSource(listContatos, null);           

        }
        private void PopulaDataGrid2()
        {
            var listCompromissos = GetCompromissos();
            gridCompromissos.DataSource = new BindingSource(listCompromissos, null);

        }

        public void gridContato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Contato contato = new Contato();
            contato.Id = int.Parse(gridContato.CurrentRow.Cells[0].Value.ToString());
            txtNome.Text = gridContato.CurrentRow.Cells[1].Value.ToString();
            txtCelular.Text = gridContato.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = gridContato.CurrentRow.Cells[3].Value.ToString();
            cboEstado.Text = gridContato.CurrentRow.Cells[4].Value.ToString();
            PopulaDataGrid2();
        }
        private void gridCompromissos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Compromisso compromisso = new Compromisso();
            compromisso.Id = int.Parse(gridCompromissos.CurrentRow.Cells[0].Value.ToString());
            txtTitulo.Text = gridCompromissos.CurrentRow.Cells[2].Value.ToString();
            dtDataIni.Text = gridCompromissos.CurrentRow.Cells[3].Value.ToString();
            dtDataFim.Text = gridCompromissos.CurrentRow.Cells[4].Value.ToString();
            cboStatus.Text = gridCompromissos.CurrentRow.Cells[5].Value.ToString();
            txtDescricao.Text = gridCompromissos.CurrentRow.Cells[6].Value.ToString();
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
            LimpaForms();
        }

        private void btnSalvarCompromisso_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = new Compromisso();
            Contato contato = new Contato();
            contato.Id = int.Parse(gridContato.CurrentRow.Cells[0].Value.ToString());
            compromisso.Contato = contato;
            compromisso.Titulo = txtTitulo.Text;
            compromisso.Descricao = txtDescricao.Text;
            compromisso.dataini = dtDataIni.Value;
            compromisso.datafim = dtDataFim.Value;
            compromisso.Status = (StatusCompromisso)this.cboStatus.SelectedItem;
            CompromissoRepository.SaveCompromisso(compromisso);
            PopulaDataGrid2();
            LimpaForms();
        }
        
        private void btnAlterarContato_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.Id = int.Parse(gridContato.CurrentRow.Cells[0].Value.ToString());
            contato.Nome = txtNome.Text;
            contato.Celular = txtCelular.Text;
            contato.Email = txtEmail.Text;
            contato.Sigla = (string)cboEstado.SelectedValue;
            ContatoRepository.Update(contato);
            PopulaDataGrid();
            LimpaForms();
        }

        private void btnExcluirContato_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.Id = (int)gridContato.CurrentRow.Cells[0].Value;
            if (ContatoRepository.Delete(contato))
            {
                MessageBox.Show("Contato apagado com sucesso", "Deletar contato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Contato já possui compromissos, não pode ser apagado!", "Deletar contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            PopulaDataGrid();
            LimpaForms();
        }

        private void btnAlterarCompromisso_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = new Compromisso();
            compromisso.Id = int.Parse(gridCompromissos.CurrentRow.Cells[0].Value.ToString());
            compromisso.Titulo = txtTitulo.Text;
            compromisso.Descricao = txtDescricao.Text;
            compromisso.dataini = dtDataIni.Value;
            compromisso.datafim = dtDataFim.Value;
            compromisso.Status = (StatusCompromisso)this.cboStatus.SelectedItem;
            CompromissoRepository.Update(compromisso);
            PopulaDataGrid2();
            LimpaForms();
        }

        private void LimpaForms()
        {
            txtNome.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtDescricao.Text = "";
            txtTitulo.Text = "";
            
        }
    }
}
