using Devs2Blu.ProjetosAula.SistemaAgendaContato.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaAgendaContato.Models.Enum;
using Devs2Blu.ProjetosAula.SistemaAgendaContato.Models.Model;
using EnumsNET;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void PopulaStatusCompromisso()
        {
            this.cboStatus.DataSource = Enums.GetMembers<StatusCompromisso>().Select(x => x.AsString(EnumFormat.Description)).ToList();
        }
        private void FormContato_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            PopulaComboEstado();
            PopulaStatusCompromisso();
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
        public object GetCompromissos(int contatoId)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GRID3, conn);
                cmd.Parameters.Add("@id_contato", MySqlDbType.Int32).Value = contatoId;
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (!dataReader.HasRows)
                    return null;
                return dataReader;
            }
            catch (MySqlException myeExc)
            {
                MessageBox.Show(myeExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQL
        private const String SQL_SELECT_GRID = @"select id Código, Nome, Celular, email 'E-mail', UF from contato";
               
        private const String SQL_SELECT_GRID3 = @"select cp.id 'Código', Titulo 'Título', dataini 'De', datafim 'Até', 
            case Status when 'A' then 'Ativo'
			when 'I' then 'Inativo'
            when 'C' then 'Concluído'
            when 'R' then 'Remarcado' end Status,
            Descricao 'Observação' from compromisso cp, contato c where cp.id_contato = c.id and id_contato = @id_contato";

        #endregion

        private void PopulaDataGrid()
        {
            var listContatos = GetContatos();
            gridContato.DataSource = new BindingSource(listContatos, null);

        }
        private void PopulaDataGrid2(int contatoId)
        {
            gridCompromissos.Rows.Clear();
            var listCompromissos = GetCompromissos(contatoId);
            if (listCompromissos != null)
                gridCompromissos.DataSource = new BindingSource(listCompromissos, null);
        }

        private void btnSalvarContato_Click(object sender, EventArgs e)
        {

            Contato contato = new Contato();
            contato.Nome = txtNome.Text;
            contato.Celular = txtCelular.Text;
            contato.Email = txtEmail.Text;
            contato.Sigla = (string)cboEstado.SelectedValue;

            if (ValidaFormContato()) 
            { 
            if (txtCdContato.Text == "")
            {
                ContatoRepository.SaveContato(contato);
                MessageBox.Show("Contato salvo com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                contato.Id = int.Parse(gridContato.CurrentRow.Cells[0].Value.ToString());
                ContatoRepository.Update(contato);
                MessageBox.Show("Contato alterado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
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
            compromisso.Status = EnumHelper.GetValueFromDescription<StatusCompromisso>((string)cboStatus.SelectedItem);

            if (ValidaFormCompromisso())
            {
                if (txtCdCompromisso.Text == "")
                {
                    CompromissoRepository.SaveCompromisso(compromisso);
                    MessageBox.Show("Compromisso salvo com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    compromisso.Id = int.Parse(gridCompromissos.CurrentRow.Cells[0].Value.ToString());
                    CompromissoRepository.Update(compromisso);

                }
            }
            PopulaDataGrid2(contato.Id);
            LimpaForms();

        }

        private void btnAlterarContato_Click(object sender, EventArgs e)
        {
            /*Contato contato = new Contato();
            contato.Id = int.Parse(gridContato.CurrentRow.Cells[0].Value.ToString());
            contato.Nome = txtNome.Text;
            contato.Celular = txtCelular.Text;
            contato.Email = txtEmail.Text;
            contato.Sigla = (string)cboEstado.SelectedValue;
            ContatoRepository.Update(contato);
            PopulaDataGrid();
            */
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
            /*int contatoId = int.Parse(gridContato.CurrentRow.Cells[0].Value.ToString());
            Compromisso compromisso = new Compromisso();
            compromisso.Id = int.Parse(gridCompromissos.CurrentRow.Cells[0].Value.ToString());
            compromisso.Titulo = txtTitulo.Text;
            compromisso.Descricao = txtDescricao.Text;
            compromisso.dataini = dtDataIni.Value;
            compromisso.datafim = dtDataFim.Value;
            compromisso.Status = EnumHelper.GetValueFromDescription<StatusCompromisso>((string)cboStatus.SelectedItem);
            CompromissoRepository.Update(compromisso);
            PopulaDataGrid2(contatoId);*/
            LimpaForms();
        }

        private void LimpaForms()
        {
            txtNome.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtDescricao.Text = "";
            txtTitulo.Text = "";
            cboEstado.Text = "";
            txtCdContato.Text = null;
            txtCdCompromisso.Text = null;
            PopulaStatusCompromisso();

        }

        
        private void gridContato_SelectionChanged(object sender, EventArgs e)
        {
            if (gridContato.CurrentRow == null)
                return;
            int contatoId = int.Parse(gridContato.CurrentRow.Cells[0].Value.ToString());
            PopulaDataGrid2(contatoId);
            LimpaForms();
        }

        private void gridCompromissos_SelectionChanged(object sender, EventArgs e)
        {
      /*      if (gridCompromissos.CurrentRow == null)
                return;

            Compromisso compromisso = new Compromisso();
            compromisso.Id = int.Parse(gridCompromissos.CurrentRow.Cells[0].Value.ToString());
            txtCdCompromisso.Text = gridCompromissos.CurrentRow.Cells[0].Value.ToString();
            txtTitulo.Text = gridCompromissos.CurrentRow.Cells[2].Value.ToString();
            DateTime data;
            if (DateTime.TryParse(gridCompromissos.CurrentRow.Cells[3].Value.ToString(), out data))
                dtDataIni.Value = data;
            if (DateTime.TryParse(gridCompromissos.CurrentRow.Cells[4].Value.ToString(), out data))
                dtDataFim.Value = data;
            cboStatus.Text = gridCompromissos.CurrentRow.Cells[5].Value.ToString();
            txtDescricao.Text = gridCompromissos.CurrentRow.Cells[6].Value.ToString();   */       
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridCompromissos_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Compromisso compromisso = new Compromisso();
            compromisso.Id = int.Parse(gridCompromissos.CurrentRow.Cells[0].Value.ToString());
            txtCdCompromisso.Text = gridCompromissos.CurrentRow.Cells[0].Value.ToString();
            txtTitulo.Text = gridCompromissos.CurrentRow.Cells[1].Value.ToString();
            dtDataIni.Text = gridCompromissos.CurrentRow.Cells[2].Value.ToString();
            dtDataFim.Text = gridCompromissos.CurrentRow.Cells[3].Value.ToString();
            cboStatus.Text = gridCompromissos.CurrentRow.Cells[4].Value.ToString();
            txtDescricao.Text = gridCompromissos.CurrentRow.Cells[5].Value.ToString();
        }

     
        private void gridContato_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Contato contato = new Contato();
            contato.Id = int.Parse(gridContato.CurrentRow.Cells[0].Value.ToString());
            txtCdContato.Text = gridContato.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = gridContato.CurrentRow.Cells[1].Value.ToString();
            txtCelular.Text = gridContato.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = gridContato.CurrentRow.Cells[3].Value.ToString();
            cboEstado.Text = gridContato.CurrentRow.Cells[4].Value.ToString();
        }

        private bool ValidaFormContato()
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Favor informar um Nome!", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            if (cboEstado.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Favor informar um Estado!", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEstado.Focus();
                return false;
            }
            return true;
        }

        private bool ValidaFormCompromisso()
        {
            if (txtTitulo.Text.Equals(""))
            {
                MessageBox.Show("Favor informar um título!", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitulo.Focus();
                return false;
            }            
            return true;
        }
    }
}